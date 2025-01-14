﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BGAPI2;
using System.Drawing.Imaging;
using System.Threading;

namespace Kinovea.Camera.Baumer
{
    /// <summary>
    /// Helper class to wrap Baumer camera.
    /// Provide open/close and acquisition once / acquisition continuous in a separate thread.
    /// </summary>
    public class BaumerProvider
    {
        public event EventHandler<BufferEventArgs> BufferProduced;

        public bool IsOpen 
        {
            get { return opened; }
        }

        public Device Device
        {
            get { return device; }
        }

        private ulong bufferFilledTimeoutMS = 1000;
        private BGAPI2.System system;
        private BGAPI2.Interface interf;
        private BGAPI2.Device device;
        private BGAPI2.DataStream dataStream;
        private BGAPI2.BufferList bufferList;
        private bool opened;
        private bool started;
        private bool grabThreadRun = true;
        private Thread grabThread;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Open a specific device and allocate buffers.
        /// </summary>
        public bool Open(string systemKey, string interfaceKey, string deviceKey)
        {
            Close();

            try
            {
                // Look for the device.
                SystemList systemList = SystemList.Instance;
                systemList.Refresh();
                foreach (KeyValuePair<string, BGAPI2.System> systemPair in systemList)
                {
                    if (systemPair.Key != systemKey)
                        continue;

                    system = systemPair.Value;
                    if (!system.IsOpen)
                        system.Open();

                    break;
                }

                if (system == null || !system.IsOpen)
                    return false;

                system.Interfaces.Refresh(100);
                foreach (KeyValuePair<string, BGAPI2.Interface> interfacePair in system.Interfaces)
                {
                    if (interfacePair.Key != interfaceKey)
                        continue;

                    interf = interfacePair.Value;
                    if (!interf.IsOpen)
                        interf.Open();
                    break;
                }

                if (interf == null || !interf.IsOpen)
                    return false;
                

                interf.Devices.Refresh(100);
                foreach (KeyValuePair<string, BGAPI2.Device> devicePair in interf.Devices)
                {
                    if (devicePair.Key != deviceKey)
                        continue;

                    device = devicePair.Value;
                    if (!device.IsOpen)
                        device.Open();
                    break;
                }

                if (device == null || !device.IsOpen)
                    return false;

                DataStreamList dataStreamList = device.DataStreams;
                dataStreamList.Refresh();
                foreach (KeyValuePair<string, BGAPI2.DataStream> dataStreamPair in dataStreamList)
                {
                    if (string.IsNullOrEmpty(dataStreamPair.Key))
                        continue;

                    dataStream = dataStreamPair.Value;
                    dataStream.Open();
                    break;
                }

                if (dataStream == null)
                {
                    CloseDevice();
                    return false;
                }

                // Use buffers internal to the API.
                bufferList = dataStream.BufferList;
                int countBuffers = 4;
                for (int i = 0; i < countBuffers; i++)
                {
                    BGAPI2.Buffer buffer = new BGAPI2.Buffer();
                    bufferList.Add(buffer);
                    //ulong memSize = buffer.MemSize;
                    //log.DebugFormat("Buffer mem size: {0}", memSize);
                }

                // Make buffers available to the Baumer producer.
                if (bufferList != null && bufferList.Count == countBuffers)
                {
                    foreach (KeyValuePair<string, BGAPI2.Buffer> bufferPair in bufferList)
                        bufferPair.Value.QueueBuffer();
                }

                opened = true;
            }
            catch (Exception e)
            {
                log.ErrorFormat("Failed to open device. {0}", e);
                DiscardBuffers();
                CloseDataStream();
                CloseDevice();
            }

            return opened;
        }

        /// <summary>
        /// Close the currently opened device and deallocate buffers.
        /// </summary>
        public void Close()
        {
            if (!opened)
                return;

            if (started)
                Stop();

            opened = false;

            DiscardBuffers();
            CloseDataStream();
            CloseDevice();
            //CloseInterface();
            //CloseSystem();
        }

        /// <summary>
        /// Start acquisition, get one frame synchronously, convert to RGB24 Bitmap, stop acquisition.
        /// </summary>
        public void AcquireOne()
        {
            if (!opened)
                return;

            if (started)
                Stop();

            dataStream.StartAcquisition();
            //device.RemoteNodeList["AcquisitionMode"].Value = "Continuous";
            device.RemoteNodeList["AcquisitionStart"].Execute();
            started = true;

            // Wait for one frame.
            BGAPI2.Buffer bufferFilled = dataStream.GetFilledBuffer(bufferFilledTimeoutMS);
            if (bufferFilled == null || bufferFilled.IsIncomplete || bufferFilled.MemPtr == IntPtr.Zero)
            {
                // Timeout or error while waiting for the frame.
                Stop();
                return;
            }

            // At this point we have an image buffer available.
            // .MemPtr contains native memory of the raw frame.
            if (BufferProduced != null)
                BufferProduced(this, new BufferEventArgs(bufferFilled));

            // Make the buffer available again.
            bufferFilled.QueueBuffer();
            Stop();
        }

        public void AcquireContinuous()
        {
            // Start a background thread and post new buffers.
            if (!opened)
                return;

            if (!dataStream.IsOpen)
                return;

            // setup
            dataStream.StartAcquisition();
            device.RemoteNodeList["AcquisitionMode"].Value = "Continuous";
            device.RemoteNodeList["AcquisitionStart"].Execute();

            started = true;

            // TODO: use ThreadPool instead ?
            grabThreadRun = true;
            grabThread = new Thread(Grab);
            grabThread.Start();
        }

        public void Stop()
        {
            if (!opened || !started)
                return;

            if (grabThread != null && grabThread.IsAlive)
            {
                grabThreadRun = false;
                grabThread.Join();
            }

            if (device.RemoteNodeList.GetNodePresent("AcquisitionAbort"))
                device.RemoteNodeList["AcquisitionAbort"].Execute();

            device.RemoteNodeList["AcquisitionStop"].Execute();
            dataStream.StopAcquisition();
        }
        
        /// <summary>
        /// Thread method.
        /// </summary>
        private void Grab()
        {
            // raise event start grabbing.
            try
            {
                // setup.

                while (grabThreadRun)
                {
                    // Wait for the next buffer.
                    BGAPI2.Buffer bufferFilled = dataStream.GetFilledBuffer(1000);
                    if (bufferFilled == null || bufferFilled.IsIncomplete || bufferFilled.MemPtr == IntPtr.Zero)
                    {
                        // Grab timeout or error.
                        throw new Exception("A grab timeout or error occurred.");
                    }

                    // Post image event.
                    if (BufferProduced != null)
                        BufferProduced(this, new BufferEventArgs(bufferFilled));

                    // Make the buffer available to Baumer internals again.
                    bufferFilled.QueueBuffer();
                }

                // Normal cancellation of the grabbing thread.
                // Cleanup.
            }
            catch(Exception)
            {
                grabThreadRun = false;

                // Cleanup.
            }

            // Normal thread death.
        }

        private void DiscardBuffers()
        {
            try
            {
                if (bufferList != null)
                {
                    bufferList.DiscardAllBuffers();
                    while (bufferList.Count > 0)
                    {
                        BGAPI2.Buffer buffer = (BGAPI2.Buffer)bufferList.Values.First();
                        bufferList.RevokeBuffer(buffer);
                    }

                    bufferList = null;
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }

        private void CloseDataStream()
        {
            try
            {
                if (dataStream != null)
                {
                    if (dataStream.IsOpen)
                        dataStream.Close();

                    dataStream = null;
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }

        private void CloseDevice()
        {
            try
            {
                if (device != null)
                {
                    if (device.IsOpen)
                        device.Close();

                    device = null;
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }

        private void CloseInterface()
        {
            try
            {
                if (interf != null)
                {
                    if (interf.IsOpen)
                        interf.Close();

                    interf = null;
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }

        private void CloseSystem()
        {
            try
            {
                if (system != null)
                {
                    if (system.IsOpen)
                        system.Close();

                    system = null;
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }
    }
}
