﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Kinovea.Services;
using System.Windows.Forms;
using BGAPI2;
using System.Xml;
using System.IO;
using System.Threading;
using System.Globalization;

namespace Kinovea.Camera.Baumer
{
    /// <summary>
    /// The main camera manager for Baumer cameras.
    /// Camera discovery, instanciating snapshotter and framegrabber.
    /// </summary>
    public class CameraManagerBaumer : CameraManager
    {
        #region Properties
        public override bool Enabled
        {
            get { return true; }
        }

        public override string CameraType
        {
            get { return "67cfc2e8-696b-4ed6-9caa-02baee8872bc"; }
        }
        public override string CameraTypeFriendlyName
        {
            get { return "Baumer"; }
        }
        public override bool HasConnectionWizard
        {
            get { return false; }
        }
        #endregion

        #region Members
        private List<SnapshotRetriever> snapshotting = new List<SnapshotRetriever>();
        private Dictionary<string, CameraSummary> cache = new Dictionary<string, CameraSummary>();
        private Bitmap defaultIcon;
        private BGAPI2.SystemList systemList;
        private Dictionary<string, BGAPI2.System> systems = new Dictionary<string, BGAPI2.System>();
        private Dictionary<string, uint> deviceIndices = new Dictionary<string, uint>();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public CameraManagerBaumer()
        {
            defaultIcon = IconLibrary.GetIcon("baumer");
        }

        #region Public methods - CameraManager implementation
        public override bool SanityCheck()
        {
            bool result = false;
            try
            {
                systemList = SystemList.Instance;
                result = true;
            }
            catch (Exception e)
            {
                log.DebugFormat("Baumer Camera subsystem not available.");
                log.ErrorFormat(e.Message);
            }

            return result;
        }

        public override List<CameraSummary> DiscoverCameras(IEnumerable<CameraBlurb> blurbs)
        {
            List<CameraSummary> summaries = new List<CameraSummary>();
            List<CameraSummary> found = new List<CameraSummary>();

            //---------------------------------------------
            // Lifecycles of objects in the Baumer API:
            // - systemList: entire application.
            // - system: entire application. Should be kept open.
            // - interface: entire application. Allow listing of devices even if they are opened by another application.
            // - device: camera session.
            //---------------------------------------------

            if (systems.Count == 0)
            {
                systemList.Refresh();
                foreach (KeyValuePair<string, BGAPI2.System> systemPair in systemList)
                {
                    BGAPI2.System system = systemPair.Value;
                    if (string.IsNullOrEmpty(system.Id))
                        continue;

                    try
                    {
                        if (!system.Vendor.Contains("Baumer"))
                            continue;

                        if (!system.IsOpen)
                            system.Open();
                    
                        systems.Add(systemPair.Key, system);
                        log.DebugFormat("Opened system {0} ({1}).", systemPair.Value.DisplayName, systemPair.Value.Vendor);
                    }
                    catch
                    {
                        log.DebugFormat("Error while opening system {0} ({1}).", systemPair.Value.DisplayName, systemPair.Value.Vendor);
                    }
                }
            }

            try
            {
                foreach (KeyValuePair<string, BGAPI2.System> systemPair in systems)
                {
                    var system = systemPair.Value;
                    if (!system.Vendor.Contains("Baumer"))
                      continue;
                    
                    if (string.IsNullOrEmpty(system.Id))
                        continue;

                    if (!system.IsOpen)
                        continue;

                    system.Interfaces.Refresh(200);
                    foreach (KeyValuePair<string, Interface> interfacePair in system.Interfaces)
                    {
                        var interf = interfacePair.Value;
                        //log.DebugFormat("Opening interface {0}", iface.DisplayName);
                        if (!interf.IsOpen)
                            interf.Open();
                        
                        if (string.IsNullOrEmpty(interf.Id))
                            continue;

                        interf.Devices.Refresh(200);
                        foreach (KeyValuePair<string, Device> devicePair in interf.Devices)
                        {
                            var device = devicePair.Value;
                            //log.DebugFormat("Found device: {0} ({1})", device.DisplayName, device.Vendor);
                            
                            string identifier = device.SerialNumber;
                            bool cached = cache.ContainsKey(identifier);
                            if (cached)
                            {
                                // We've already seen this camera in the current Kinovea session.
                                //deviceIds[identifier] = device.GetDeviceID();
                                //log.DebugFormat("Known device from current session.");
                                summaries.Add(cache[identifier]);
                                found.Add(cache[identifier]);
                                continue;
                            }

                            string alias = device.DisplayName;
                            Bitmap icon = null;
                            SpecificInfo specific = new SpecificInfo();
                            Rectangle displayRectangle = Rectangle.Empty;
                            CaptureAspectRatio aspectRatio = CaptureAspectRatio.Auto;
                            ImageRotation rotation = ImageRotation.Rotate0;
                            bool mirror = false;

                            // Check if we already know this camera from a previous Kinovea session.
                            if (blurbs != null)
                            {
                                foreach (CameraBlurb blurb in blurbs)
                                {
                                    if (blurb.CameraType != this.CameraType || blurb.Identifier != identifier)
                                        continue;

                                    // We know this camera from a previous Kinovea session, restore the user custom values.
                                    log.DebugFormat("Known device from previous session.");
                                    alias = blurb.Alias;
                                    icon = blurb.Icon ?? defaultIcon;
                                    displayRectangle = blurb.DisplayRectangle;
                                    if (!string.IsNullOrEmpty(blurb.AspectRatio))
                                        aspectRatio = (CaptureAspectRatio)Enum.Parse(typeof(CaptureAspectRatio), blurb.AspectRatio);
                                    if (!string.IsNullOrEmpty(blurb.Rotation))
                                        rotation = (ImageRotation)Enum.Parse(typeof(ImageRotation), blurb.Rotation);
                                    mirror = blurb.Mirror;
                                    specific = SpecificInfoDeserialize(blurb.Specific);
                                    break;
                                }
                            }

                            // Keep temporary info in order to find it back later.
                            specific.SystemKey = systemPair.Key;
                            specific.InterfaceKey = interfacePair.Key;
                            specific.DeviceKey = devicePair.Key;
                            specific.Device = null;

                            icon = icon ?? defaultIcon;
                            CameraSummary summary = new CameraSummary(alias, device.DisplayName, identifier, icon, displayRectangle, aspectRatio, rotation, mirror, specific, this);

                            summaries.Add(summary);
                            found.Add(summary);
                            cache.Add(identifier, summary);
                        }

                        //iface.Close();
                    }

                    //system.Close();
                }
            }
            catch (Exception e)
            {
                log.ErrorFormat("Error while scanning for devices. {0}", e.Message);
            }
            
            List<CameraSummary> lost = new List<CameraSummary>();
            foreach (CameraSummary summary in cache.Values)
            {
                if (!found.Contains(summary))
                    lost.Add(summary);
            }

            foreach (CameraSummary summary in lost)
            {
                log.DebugFormat("Lost device: {0}", summary.Name);
                cache.Remove(summary.Identifier);
            }

            return summaries;
        }

        public override void ForgetCamera(CameraSummary summary)
        {
            if (cache.ContainsKey(summary.Identifier))
                cache.Remove(summary.Identifier);
        }

        public override CameraSummary GetCameraSummary(string alias)
        {
            return cache.Values.FirstOrDefault(s => s.Alias == alias);
        }

        public override void StartThumbnail(CameraSummary summary)
        {
            SnapshotRetriever snapper = snapshotting.FirstOrDefault(s => s.Identifier == summary.Identifier);
            if (snapper != null)
                return;

            snapper = new SnapshotRetriever(summary);
            snapper.CameraThumbnailProduced += SnapshotRetriever_CameraThumbnailProduced;
            snapshotting.Add(snapper);
            snapper.Start();
        }

        public override void StopAllThumbnails()
        {
            for (int i = snapshotting.Count - 1; i >= 0; i--)
            {
                SnapshotRetriever snapper = snapshotting[i];
                snapper.Cancel();
                snapper.Thread.Join(500);
                if (snapper.Thread.IsAlive)
                    snapper.Thread.Abort();

                snapper.CameraThumbnailProduced -= SnapshotRetriever_CameraThumbnailProduced;
                snapshotting.RemoveAt(i);
            }
        }

        public override CameraBlurb BlurbFromSummary(CameraSummary summary)
        {
            string specific = SpecificInfoSerialize(summary);
            CameraBlurb blurb = new CameraBlurb(CameraType, summary.Identifier, summary.Alias, summary.Icon, summary.DisplayRectangle, summary.AspectRatio.ToString(), summary.Rotation.ToString(), summary.Mirror, specific);
            return blurb;
        }

        public override ICaptureSource CreateCaptureSource(CameraSummary summary)
        {
            FrameGrabber grabber = new FrameGrabber(summary);
            return grabber;
        }

        public override bool Configure(CameraSummary summary)
        {
            throw new NotImplementedException();
        }

        public override bool Configure(CameraSummary summary, Action disconnect, Action connect)
        {
            bool needsReconnection = false;
            SpecificInfo info = summary.Specific as SpecificInfo;
            if (info == null)
                return false;

            FormConfiguration form = new FormConfiguration(summary, disconnect, connect);
            FormsHelper.Locate(form);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.AliasChanged)
                    summary.UpdateAlias(form.Alias, form.PickedIcon);

                if (form.SpecificChanged)
                {
                    info.StreamFormat = form.SelectedStreamFormat;
                    info.Demosaicing = form.Demosaicing;
                    info.Compression = form.Compression;
                    info.CameraProperties = form.CameraProperties;

                    summary.UpdateDisplayRectangle(Rectangle.Empty);
                    needsReconnection = true;
                }

                CameraTypeManager.UpdatedCameraSummary(summary);
            }

            form.Dispose();
            return needsReconnection;
        }

        public override string GetSummaryAsText(CameraSummary summary)
        {
            string result = "";
            string alias = summary.Alias;
            SpecificInfo info = summary.Specific as SpecificInfo;
            result = string.Format("{0}", alias);
            try
            {
                if (info != null &&
                    info.StreamFormat != null &&
                    info.CameraProperties.ContainsKey("width") &&
                    info.CameraProperties.ContainsKey("height") &&
                    info.CameraProperties.ContainsKey("framerate"))
                {
                    string format = info.StreamFormat;
                    int width = int.Parse(info.CameraProperties["width"].CurrentValue, CultureInfo.InvariantCulture);
                    int height = int.Parse(info.CameraProperties["height"].CurrentValue, CultureInfo.InvariantCulture);
                    double framerate = BaumerHelper.GetResultingFramerate(info.Device);
                    if (framerate == 0)
                        framerate = double.Parse(info.CameraProperties["framerate"].CurrentValue, CultureInfo.InvariantCulture);

                    result = string.Format("{0} - {1}×{2} @ {3:0.##} fps ({4}).", alias, width, height, framerate, format);
                }
            }
            catch
            {
            }

            return result;
        }

        public override Control GetConnectionWizard()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private methods
        private void SnapshotRetriever_CameraThumbnailProduced(object sender, CameraThumbnailProducedEventArgs e)
        {
            Invoke((Action)delegate { ProcessThumbnail(sender, e); });
        }

        private void ProcessThumbnail(object sender, CameraThumbnailProducedEventArgs e)
        {
            SnapshotRetriever snapper = sender as SnapshotRetriever;
            if (snapper == null)
                return;

            log.DebugFormat("Received thumbnail event for {0}. Cancelled: {1}.", snapper.Alias, e.Cancelled);
            snapper.CameraThumbnailProduced -= SnapshotRetriever_CameraThumbnailProduced;
            if (snapshotting.Contains(snapper))
                snapshotting.Remove(snapper);

            OnCameraThumbnailProduced(e);
        }

        private SpecificInfo SpecificInfoDeserialize(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                return null;

            SpecificInfo info = null;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(new StringReader(xml));

                info = new SpecificInfo();

                string streamFormat = "";
                XmlNode xmlStreamFormat = doc.SelectSingleNode("/Baumer/StreamFormat");
                if (xmlStreamFormat != null)
                    streamFormat = xmlStreamFormat.InnerText;

                bool demosaicing = false;
                XmlNode xmlDemosaicing = doc.SelectSingleNode("/Baumer/Demosaicing");
                if (xmlDemosaicing != null)
                    demosaicing = XmlHelper.ParseBoolean(xmlDemosaicing.InnerText);

                bool compression = false;
                XmlNode xmlCompression = doc.SelectSingleNode("/Baumer/Compression");
                if (xmlCompression != null)
                    compression = XmlHelper.ParseBoolean(xmlCompression.InnerText);

                Dictionary<string, CameraProperty> cameraProperties = new Dictionary<string, CameraProperty>();

                XmlNodeList props = doc.SelectNodes("/Baumer/CameraProperties/CameraProperty");
                foreach (XmlNode node in props)
                {
                    XmlAttribute keyAttribute = node.Attributes["key"];
                    if (keyAttribute == null)
                        continue;

                    string key = keyAttribute.Value;
                    CameraProperty property = new CameraProperty();

                    string xpath = string.Format("/Baumer/CameraProperties/CameraProperty[@key='{0}']", key);
                    XmlNode xmlPropertyValue = doc.SelectSingleNode(xpath + "/Value");
                    if (xmlPropertyValue != null)
                        property.CurrentValue = xmlPropertyValue.InnerText;
                    else
                        property.Supported = false;

                    XmlNode xmlPropertyAuto = doc.SelectSingleNode(xpath + "/Auto");
                    if (xmlPropertyAuto != null)
                        property.Automatic = XmlHelper.ParseBoolean(xmlPropertyAuto.InnerText);
                    else
                        property.Supported = false;

                    cameraProperties.Add(key, property);
                }

                info.StreamFormat = streamFormat;
                info.Demosaicing = demosaicing;
                info.Compression = compression;
                info.CameraProperties = cameraProperties;
            }
            catch (Exception e)
            {
                log.ErrorFormat(e.Message);
            }

            return info;
        }

        private string SpecificInfoSerialize(CameraSummary summary)
        {
            SpecificInfo info = summary.Specific as SpecificInfo;
            if (info == null)
                return null;

            XmlDocument doc = new XmlDocument();
            XmlElement xmlRoot = doc.CreateElement("Baumer");

            XmlElement xmlStreamFormat = doc.CreateElement("StreamFormat");
            xmlStreamFormat.InnerText = info.StreamFormat;
            xmlRoot.AppendChild(xmlStreamFormat);

            XmlElement xmlDemosaicing = doc.CreateElement("Demosaicing");
            xmlDemosaicing.InnerText = info.Demosaicing.ToString().ToLowerInvariant();
            xmlRoot.AppendChild(xmlDemosaicing);

            XmlElement xmlCompression = doc.CreateElement("Compression");
            xmlCompression.InnerText = info.Compression.ToString().ToLowerInvariant();
            xmlRoot.AppendChild(xmlCompression);

            XmlElement xmlCameraProperties = doc.CreateElement("CameraProperties");

            foreach (KeyValuePair<string, CameraProperty> pair in info.CameraProperties)
            {
                if (pair.Value == null)
                    continue;

                XmlElement xmlCameraProperty = doc.CreateElement("CameraProperty");
                XmlAttribute attr = doc.CreateAttribute("key");
                attr.Value = pair.Key;
                xmlCameraProperty.Attributes.Append(attr);

                XmlElement xmlCameraPropertyValue = doc.CreateElement("Value");
                xmlCameraPropertyValue.InnerText = pair.Value.CurrentValue;
                xmlCameraProperty.AppendChild(xmlCameraPropertyValue);

                XmlElement xmlCameraPropertyAuto = doc.CreateElement("Auto");
                xmlCameraPropertyAuto.InnerText = pair.Value.Automatic.ToString().ToLower();
                xmlCameraProperty.AppendChild(xmlCameraPropertyAuto);

                xmlCameraProperties.AppendChild(xmlCameraProperty);
            }

            xmlRoot.AppendChild(xmlCameraProperties);

            doc.AppendChild(xmlRoot);

            return doc.OuterXml;
        }
        #endregion

    }
}
