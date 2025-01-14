﻿#region License
/*
Copyright © Joan Charmant 2013.
jcharmant@gmail.com 
 
This file is part of Kinovea.

Kinovea is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

Kinovea is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Kinovea. If not, see http://www.gnu.org/licenses/.
*/
#endregion
using System;
using System.Drawing;
using System.Threading;
using AForge.Video;
using Kinovea.Pipeline;
using Kinovea.Services;

namespace Kinovea.Camera.HTTP
{
    /// <summary>
    /// Retrieve a single snapshot, simulating a synchronous function. Used for thumbnails.
    /// </summary>
    public class SnapshotRetriever
    {
        public event EventHandler<CameraThumbnailProducedEventArgs> CameraThumbnailProduced;
        
        public string Identifier 
        { 
            get { return this.summary.Identifier;}
        }

        public string Alias
        {
            get { return summary.Alias; }
        }

        public Thread Thread
        {
            get { return snapperThread; }
        }


        #region Members
        private static readonly int timeout = 5000;
        private Bitmap image;
        private ImageDescriptor imageDescriptor = ImageDescriptor.Invalid;
        private CameraSummary summary;
        private EventWaitHandle waitHandle = new AutoResetEvent(false);
        private bool cancelled;
        private bool hadError;
        private ICameraHTTPClient device;
        private Thread snapperThread;
        private object locker = new object();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        
        public SnapshotRetriever(CameraManagerHTTP manager, CameraSummary summary)
        {
            this.summary = summary;

            string url = "";
            SpecificInfo specific = summary.Specific as SpecificInfo;
            if(specific != null)
                url = URLHelper.BuildURL(specific);
            
            if(specific.Format == "MJPEG")
                device = new CameraHTTPClientMJPEG(url, specific.User, specific.Password);
            else if(specific.Format == "JPEG")
                device = new CameraHTTPClientJPEG(url, specific.User, specific.Password);
        }

        public void Start()
        {
            snapperThread = new Thread(Run) { IsBackground = true };
            snapperThread.Name = string.Format("{0} thumbnailer", summary.Alias);
            snapperThread.Start();
        }

        /// <summary>
        /// Start the device for a frame grab, wait a bit and then return the result.
        /// This method MUST raise a CameraThumbnailProduced event, even in case of error.
        /// </summary>
        public void Run(object data)
        {
            log.DebugFormat("Starting {0} for thumbnail.", summary.Alias);

            if (device == null)
            {
                if (CameraThumbnailProduced != null)
                    CameraThumbnailProduced(this, new CameraThumbnailProducedEventArgs(summary, null, imageDescriptor, true, false));

                return;
            }

            device.NewFrame += Device_NewFrame;
            device.VideoSourceError += Device_VideoSourceError;
            
            device.Start();

            waitHandle.WaitOne(timeout, false);

            lock (locker)
            {
                if (!cancelled)
                {
                    device.NewFrame -= Device_NewFrame;
                    device.VideoSourceError -= Device_VideoSourceError;
                    device.SignalToStop();
                }
            }
            
            if(CameraThumbnailProduced != null)
                CameraThumbnailProduced(this, new CameraThumbnailProducedEventArgs(summary, image, imageDescriptor, hadError, cancelled));
        }

        public void Cancel()
        {
            // Runs in UI thread.
            log.DebugFormat("Cancelling thumbnail for {0}.", Alias);

            lock (locker)
            {
                device.NewFrame -= Device_NewFrame;
                device.VideoSourceError -= Device_VideoSourceError;
                device.SignalToStop();

                cancelled = true;
            }

            waitHandle.Set();
        }
        
        private void Device_NewFrame(object sender, NewFrameEventArgs e)
        {
            image = new Bitmap(e.Frame.Width, e.Frame.Height, e.Frame.PixelFormat);
            using (Graphics g = Graphics.FromImage(image))
            {
                g.DrawImageUnscaled(e.Frame, Point.Empty);
            }

            int bufferSize = ImageFormatHelper.ComputeBufferSize(image.Width, image.Height, ImageFormat.RGB24);
            imageDescriptor = new ImageDescriptor(ImageFormat.RGB24, image.Width, image.Height, true, bufferSize);
            
            waitHandle.Set();
        }
        
        private void Device_VideoSourceError(object sender, VideoSourceErrorEventArgs e)
        {
            log.ErrorFormat("Error received trying to get a thumbnail for {0}", summary.Alias);
            log.Error(e.Description);

            hadError = true;
            waitHandle.Set();
        }

    }
}

