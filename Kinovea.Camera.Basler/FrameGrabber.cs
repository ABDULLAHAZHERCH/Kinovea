﻿#region License
/*
Copyright © Joan Charmant 2014.
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
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using Kinovea.Pipeline;
using Kinovea.Services;
using PylonC.NETSupportLibrary;
using PylonC.NET;

namespace Kinovea.Camera.Basler
{
    /// <summary>
    /// The main grabbing class for Basler devices.
    /// </summary>
    public class FrameGrabber : ICaptureSource
    {
        public event EventHandler<FrameProducedEventArgs> FrameProduced;
        public event EventHandler GrabbingStatusChanged;
        
        #region Property
        public bool Grabbing
        {
            get { return grabbing; }
        }
        public float Framerate
        {
            get { return resultingFramerate; }
        }
        public double LiveDataRate
        {
            // Note: this variable is written by the stream thread and read by the UI thread.
            // We don't lock because freshness of values is not paramount and torn reads are not catastrophic either.
            // We eventually get an approximate value good enough for the purpose.
            get { return dataRateAverager.Average; }
        }
        #endregion

        #region Members
        private CameraSummary summary;
        private uint deviceIndex;
        private PYLON_DEVICE_HANDLE deviceHandle;
        private ImageProvider imageProvider = new ImageProvider();
        private bool grabbing;
        private bool firstOpen = true;
        private float resultingFramerate = 0;
        private Finishline finishline = new Finishline();
        private Stopwatch swDataRate = new Stopwatch();
        private Averager dataRateAverager = new Averager(0.02);
        private const double megabyte = 1024 * 1024;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Public methods
        public FrameGrabber(CameraSummary summary, uint deviceIndex)
        {
            this.summary = summary;
            this.deviceIndex = deviceIndex;
        }

        /// <summary>
        /// Configure device and report frame format that will be used during streaming.
        /// This method must return a proper ImageDescriptor so we can pre-allocate buffers.
        /// </summary>
        public ImageDescriptor Prepare()
        {
            Open();
            
            if (deviceHandle == null || !deviceHandle.IsValid)
                return ImageDescriptor.Invalid;

            firstOpen = false;

            // Get the configured framerate for recording support.
            resultingFramerate = PylonHelper.GetResultingFramerate(deviceHandle);

            SpecificInfo specific = summary.Specific as SpecificInfo;
            string streamFormatSymbol = specific.StreamFormat;

            bool hasWidth = Pylon.DeviceFeatureIsReadable(deviceHandle, "Width");
            bool hasHeight = Pylon.DeviceFeatureIsReadable(deviceHandle, "Height");
            bool hasPixelFormat = Pylon.DeviceFeatureIsReadable(deviceHandle, "PixelFormat");
            bool canComputeImageDescriptor = hasWidth && hasHeight && hasPixelFormat;

            if (!canComputeImageDescriptor)
                return ImageDescriptor.Invalid;

            int width = (int)Pylon.DeviceGetIntegerFeature(deviceHandle, "Width");
            int height = (int)Pylon.DeviceGetIntegerFeature(deviceHandle, "Height");
            string pixelFormat = Pylon.DeviceFeatureToString(deviceHandle, "PixelFormat");

            EPylonPixelType pixelType = Pylon.PixelTypeFromString(pixelFormat);
            if (pixelType == EPylonPixelType.PixelType_Undefined)
                return ImageDescriptor.Invalid;

            // Note: the image provider will perform the Bayer conversion itself and only output two formats.
            // - Y800 for anything monochrome.
            // - RGB32 for anything color.
            imageProvider.SetDebayering(specific.Bayer8Conversion);

            bool isBayer = Pylon.IsBayer(pixelType);
            bool isBayer8 = PylonHelper.IsBayer8(pixelType);
            bool bayerColor = (isBayer && !isBayer8) || (isBayer8 && specific.Bayer8Conversion == Bayer8Conversion.Color);
            bool color = !Pylon.IsMono(pixelType) || bayerColor;
            ImageFormat format = color ? ImageFormat.RGB32 : ImageFormat.Y800;

            finishline.Prepare(width, height, format, resultingFramerate);
            if (finishline.Enabled)
            {
                height = finishline.Height;
                resultingFramerate = finishline.ResultingFramerate;
            }

            int bufferSize = ImageFormatHelper.ComputeBufferSize(width, height, format);
            bool topDown = true;
            
            return new ImageDescriptor(format, width, height, topDown, bufferSize);
        }

        /// <summary>
        /// In case of configure failure, we would have retrieved a single image and the corresponding image descriptor.
        /// A limitation of the single snapshot retriever is that the format is always RGB24, even though the grabber may
        /// use a different format.
        /// </summary>
        public ImageDescriptor GetPrepareFailedImageDescriptor(ImageDescriptor input)
        {
            return input;
        }

        public void Start()
        {
            if (!imageProvider.IsOpen)
                Open();

            if (deviceHandle == null || !deviceHandle.IsValid || !imageProvider.IsOpen)
                return;

            log.DebugFormat("Starting device {0}, {1}", summary.Alias, summary.Identifier);

            imageProvider.GrabErrorEvent += imageProvider_GrabErrorEvent;
            imageProvider.GrabbingStartedEvent += imageProvider_GrabbingStartedEvent;
            imageProvider.DeviceRemovedEvent += imageProvider_DeviceRemovedEvent;
            imageProvider.ImageReadyEvent += imageProvider_ImageReadyEvent;

            try
            {
                imageProvider.ContinuousShot();
            }
            catch (Exception e)
            {
                LogError(e, imageProvider.GetLastErrorMessage());
            }
        }

        public void Stop()
        {
            log.DebugFormat("Stopping device {0}", summary.Alias);
            
            imageProvider.GrabErrorEvent -= imageProvider_GrabErrorEvent;
            imageProvider.GrabbingStartedEvent -= imageProvider_GrabbingStartedEvent;
            imageProvider.DeviceRemovedEvent -= imageProvider_DeviceRemovedEvent;
            imageProvider.ImageReadyEvent -= imageProvider_ImageReadyEvent;

            try
            {
                imageProvider.Stop();
            }
            catch (Exception e)
            {
                LogError(e, imageProvider.GetLastErrorMessage());
            }

            grabbing = false;
            if (GrabbingStatusChanged != null)
                GrabbingStatusChanged(this, EventArgs.Empty);
        }

        public void Close()
        {
            Stop();

            try
            {
                imageProvider.Close();
            }
            catch (Exception e)
            {
                LogError(e, imageProvider.GetLastErrorMessage());
            }
        }
        #endregion

        #region Private methods

        private void Open()
        {
            if (grabbing)
                Stop();

            try
            {
                deviceHandle = Pylon.CreateDeviceByIndex(deviceIndex);
                imageProvider.Open(deviceHandle);
            }
            catch (Exception e)
            {
                log.Error("Could not open Basler device.");
                LogError(e, imageProvider.GetLastErrorMessage());
                return;
            }

            if (!deviceHandle.IsValid)
                return;
            
            SpecificInfo specific = summary.Specific as SpecificInfo;
            if (specific == null)
                return;

            // Store the handle into the specific info so that we can retrieve device informations from the configuration dialog.
            specific.Handle = deviceHandle;
            GenApiEnum currentStreamFormat = PylonHelper.ReadEnumCurrentValue(deviceHandle, "PixelFormat");

            if (!string.IsNullOrEmpty(specific.StreamFormat) && specific.StreamFormat != currentStreamFormat.Symbol)
                PylonHelper.WriteEnum(deviceHandle, "PixelFormat", specific.StreamFormat);

            // The bayer conversion mode will be set during Prepare().

            if (firstOpen)
            {
                // Restore camera parameters from the XML blurb.
                // Regular properties, including image size.
                // First we read the current properties from the API to get fully formed properties.
                // We merge the values saved in the XML into the properties.
                // (The restoration from the XML doesn't create fully formed properties, it just contains the values).
                // Then commit the properties to the camera.
                Dictionary<string, CameraProperty> cameraProperties = CameraPropertyManager.Read(deviceHandle, summary.Identifier);
                CameraPropertyManager.MergeProperties(cameraProperties, specific.CameraProperties);
                specific.CameraProperties = cameraProperties;
                CameraPropertyManager.WriteCriticalProperties(deviceHandle, specific.CameraProperties);
            }
            else
            {
                CameraPropertyManager.WriteCriticalProperties(deviceHandle, specific.CameraProperties);
            }
        }

        private void ComputeDataRate(int bytes)
        {
            double rate = ((double)bytes / megabyte) / swDataRate.Elapsed.TotalSeconds;
            dataRateAverager.Post(rate);
            swDataRate.Reset();
            swDataRate.Start();
        }
        #endregion

        #region device event handlers
        private void imageProvider_GrabbingStartedEvent()
        {
            grabbing = true;

            if (GrabbingStatusChanged != null)
                GrabbingStatusChanged(this, EventArgs.Empty);
        }

        private void imageProvider_ImageReadyEvent()
        {
            // Consume the Pylon queue (no copy).
            ImageProvider.Image pylonImage = imageProvider.GetLatestImage();
            if (pylonImage == null)
                return;
            
            if (finishline.Enabled)
            {
                bool flush = finishline.Consolidate(pylonImage.Buffer);
                imageProvider.ReleaseImage();

                if (flush)
                {
                    ComputeDataRate(finishline.BufferOutput.Length);

                    if (FrameProduced != null)
                        FrameProduced(this, new FrameProducedEventArgs(finishline.BufferOutput, finishline.BufferOutput.Length));
                }
            }
            else
            {
                ComputeDataRate(pylonImage.Buffer.Length);

                if (FrameProduced != null)
                    FrameProduced(this, new FrameProducedEventArgs(pylonImage.Buffer, pylonImage.Buffer.Length));

                imageProvider.ReleaseImage();
            }
        }

        private void imageProvider_GrabErrorEvent(Exception grabException, string additionalErrorMessage)
        {
            LogError(grabException, additionalErrorMessage);
        }

        private void imageProvider_DeviceRemovedEvent()
        {
            
        }

        private void LogError(Exception e, string additionalErrorMessage)
        {
            log.ErrorFormat("Error during Basler camera operation. {0}", summary.Alias);
            log.Error(e.ToString());
            log.Error(additionalErrorMessage);
        }
        #endregion

    }
}
