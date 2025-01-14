﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using BGAPI2;

namespace Kinovea.Camera.Baumer
{
    /// <summary>
    /// Reads and writes a list of supported camera properties from/to the device.
    /// </summary>
    public static class CameraPropertyManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static Dictionary<string, CameraProperty> Read(Device device, string fullName)
        {
            Dictionary<string, CameraProperty> properties = new Dictionary<string, CameraProperty>();

            if (device == null || !device.IsOpen)
                return properties;

            try
            {
                properties.Add("width", ReadIntegerProperty(device, "Width", "WidthMax"));
                properties.Add("height", ReadIntegerProperty(device, "Height", "HeightMax"));

                // Camera properties in Kinovea combine the value and the "auto" flag.
                // We potentially need to read several properties to create one Kinovea camera property.
                ReadFramerate(device, properties);
                ReadExposure(device, properties);
                ReadGain(device, properties);
                ReadCompressionQuality(device, properties);
            }
            catch (Exception e)
            {
                log.ErrorFormat("Error while reading Baumer camera properties. {0}.", e.Message);
            }

            return properties;
        }

        /// <summary>
        /// Commit value of properties that can be written during streaming and don't require a reconnect to be applied.
        /// This is used by the configuration, to update the image while configuring.
        /// </summary>
        public static void Write(Device device, CameraProperty property)
        {
            if (!property.Supported || string.IsNullOrEmpty(property.Identifier) || device == null || !device.IsOpen)
                return;

            try
            {
                switch (property.Identifier)
                {
                    case "AcquisitionFrameRate":
                    case "AcquisitionFrameRateAbs":
                    case "ExposureTime":
                    case "ExposureTimeAbs":
                    case "Gain":
                    case "GainRaw":
                    case "ImageCompressionQuality":
                        WriteProperty(device, property);
                        break;
                    case "Width":
                    case "Height":
                        // Do nothing. These properties must be changed from WriteCriticalProperties below.
                        break;
                    default:
                        log.ErrorFormat("Baumer property not supported: {0}.", property.Identifier);
                        break;
                }
            }
            catch (Exception e)
            {
                log.ErrorFormat("Error while writing Baumer property {0}. {1}", property.Identifier, e.Message);
            }
        }

        /// <summary>
        /// Push values from XML based simple properties into current list of properties.
        /// </summary>
        public static void MergeProperties(Dictionary<string, CameraProperty> dest, Dictionary<string, CameraProperty> source)
        {
            // This is used to import values from simple XML based representation into properties instances.
            foreach (var pair in source)
            {
                if (!dest.ContainsKey(pair.Key))
                    continue;

                dest[pair.Key].Automatic = pair.Value.Automatic;
                dest[pair.Key].CurrentValue = pair.Value.CurrentValue;
            }
        }

        public static void WriteCriticalProperties(Device device, Dictionary<string, CameraProperty> properties)
        {
            if (properties == null || properties.Count == 0)
                return;

            try
            {
                foreach (var pair in properties)
                {
                    if (pair.Key == "width")
                        WriteSize(device, pair.Value, "OffsetX");
                    else if (pair.Key == "height")
                        WriteSize(device, pair.Value, "OffsetY");
                    else
                        WriteProperty(device, pair.Value);
                }
            }
            catch (Exception e)
            {
                log.ErrorFormat("Error while writing Baumer property. {0}", e.Message);
            }
        }

        private static CameraProperty ReadFramerate(Device device, Dictionary<string, CameraProperty> properties)
        {
            CameraProperty p = new CameraProperty();
            p.Identifier = "AcquisitionFrameRate";
            p.Supported = false;
            p.Type = CameraPropertyType.Float;

            bool present = device.RemoteNodeList.GetNodePresent(p.Identifier);
            if (!present)
            {
                p.Identifier = "AcquisitionFrameRateAbs";
                present = device.RemoteNodeList.GetNodePresent(p.Identifier);
                if (!present)
                    return p;
            }

            Node node = device.RemoteNodeList[p.Identifier];
            if (!node.IsImplemented || !node.IsAvailable || !node.IsReadable)
                return p;

            p.ReadOnly = false;
            p.Supported = true;

            double currentValue = node.Value;
            double min = node.Min;
            double max = node.Max;
            double step = 1.0;
            min = Math.Max(1.0, min);
            
            p.Minimum = min.ToString(CultureInfo.InvariantCulture);
            p.Maximum = max.ToString(CultureInfo.InvariantCulture);
            p.CurrentValue = currentValue.ToString(CultureInfo.InvariantCulture);
            p.Step = step.ToString(CultureInfo.InvariantCulture);

            // Fix values that should be log.
            bool highRange = (Math.Log10(max) - Math.Log10(min)) >= 4.0;
            p.Representation = highRange ? CameraPropertyRepresentation.LogarithmicSlider : CameraPropertyRepresentation.LinearSlider;

            // AcquisitionFrameRateEnable=false: the framerate is automatically set to the max value possible (auto = true).
            // AcquisitionFrameRateEnable=true: use the custom framerate set by the user in AcquisitionFrameRate (auto = false).

            string autoIdentifier = "AcquisitionFrameRateEnable";
            p.AutomaticIdentifier = autoIdentifier;
            p.Automatic = false;
            p.CanBeAutomatic = false;
            Node autoNode = null;
            bool autoPresent = device.RemoteNodeList.GetNodePresent(p.AutomaticIdentifier);
            if (autoPresent)
            {
                autoNode = device.RemoteNodeList[p.AutomaticIdentifier];
                p.CanBeAutomatic = autoNode.IsWriteable;
            }
 
            if (p.CanBeAutomatic)
            {
                string currentAutoValue = ((bool)autoNode.Value).ToString(CultureInfo.InvariantCulture).ToLower();
                p.Automatic = currentAutoValue == GetAutoTrue(autoIdentifier);
            }

            if (properties != null)
                properties.Add("framerate", p);

            return p;
        }

        private static void ReadExposure(Device device, Dictionary<string, CameraProperty> properties)
        {
            CameraProperty p = ReadFloatProperty(device, "ExposureTime");
            if (!p.Supported)
                p = ReadFloatProperty(device, "ExposureTimeAbs");

            string autoIdentifier = "ExposureAuto";
            p.AutomaticIdentifier = autoIdentifier;
            p.CanBeAutomatic = false;
            p.Automatic = false;
            bool autoReadable = BaumerHelper.NodeIsReadable(device, p.AutomaticIdentifier);
            if (autoReadable)
            {
                p.CanBeAutomatic = true;
                string autoValue = BaumerHelper.GetString(device, p.AutomaticIdentifier);
                p.Automatic = autoValue == GetAutoTrue(autoIdentifier);
            }

            properties.Add("exposure", p);
        }

        private static void ReadGain(Device device, Dictionary<string, CameraProperty> properties)
        {
            CameraProperty p = ReadFloatProperty(device, "Gain");
            if (!p.Supported)
                p = ReadIntegerProperty(device, "GainRaw", null);

            string autoIdentifier = "GainAuto";
            p.AutomaticIdentifier = autoIdentifier;
            p.CanBeAutomatic = false;
            p.Automatic = false;
            bool autoReadable = BaumerHelper.NodeIsReadable(device, p.AutomaticIdentifier);
            if (autoReadable)
            {
                p.CanBeAutomatic = true;
                string autoValue = BaumerHelper.GetString(device, p.AutomaticIdentifier);
                p.Automatic = autoValue == GetAutoTrue(autoIdentifier);
            }

            properties.Add("gain", p);
        }

        private static void ReadCompressionQuality(Device device, Dictionary<string, CameraProperty> properties)
        {
            CameraProperty p = ReadIntegerProperty(device, "ImageCompressionQuality", "");

            p.AutomaticIdentifier = "";
            p.CanBeAutomatic = false;
            p.Automatic = false;

            properties.Add("compressionQuality", p);
        }

        private static CameraProperty ReadIntegerProperty(Device device, string symbol, string symbolMax)
        {
            CameraProperty p = new CameraProperty();
            p.Identifier = symbol;

            bool readable = BaumerHelper.NodeIsReadable(device, symbol);
            if (!readable)
            {
                log.WarnFormat("Could not read Baumer property {0}: the property is not supported.", symbol);
                return p;
            }

            p.Supported = true;
            p.Type = CameraPropertyType.Integer;
            p.ReadOnly = false;

            Node node = device.RemoteNodeList[symbol];
            int currentValue = (int)node.Value;
            int min = (int)node.Min;
            int max = (int)node.Max;
            int step = (int)node.Inc;

            // Get the real max from another property, the bare max depends on the current offset.
            if (!string.IsNullOrEmpty(symbolMax))
            {
                bool maxReadable = BaumerHelper.NodeIsReadable(device, symbolMax);
                if (maxReadable)
                    max = (int)device.RemoteNodeList[symbolMax].Value;
            }

            bool highRange = (Math.Log10(max) - Math.Log10(min)) > 4;
            
            p.Minimum = min.ToString(CultureInfo.InvariantCulture);
            p.Maximum = max.ToString(CultureInfo.InvariantCulture);
            p.Step = step.ToString(CultureInfo.InvariantCulture);
            p.Representation = highRange ? CameraPropertyRepresentation.LogarithmicSlider : CameraPropertyRepresentation.LinearSlider;
            p.CurrentValue = currentValue.ToString(CultureInfo.InvariantCulture);

            return p;
        }

        private static CameraProperty ReadFloatProperty(Device device, string symbol)
        {
            CameraProperty p = new CameraProperty();
            p.Identifier = symbol;

            bool readable = BaumerHelper.NodeIsReadable(device, symbol);
            if (!readable)
            {
                log.WarnFormat("Could not read Baumer property {0}: the property is not supported.", symbol);
                return p;
            }

            p.Supported = true;
            p.Type = CameraPropertyType.Float;
            p.ReadOnly = false;

            Node node = device.RemoteNodeList[symbol];
            double min = node.Min;
            double max = node.Max;
            string repr = node.Representation;
            double currentValue = node.Value;
            
            // We don't support a dedicated control for "pure numbers" just use the regular slider.
            if (repr == "PureNumber")
                repr = "Linear";

            // Fix values that should be log.
            if ((Math.Log10(max) - Math.Log10(min)) > 4.0)
                repr = "Logarithmic";

            p.Minimum = min.ToString(CultureInfo.InvariantCulture);
            p.Maximum = max.ToString(CultureInfo.InvariantCulture);
            p.Representation = ConvertRepresentation(repr);
            p.CurrentValue = currentValue.ToString(CultureInfo.InvariantCulture);

            return p;
        }

        /// <summary>
        /// Write either width or height as a centered region of interest.
        /// </summary>
        private static void WriteSize(Device device, CameraProperty property, string identifierOffset)
        {
            if (property.ReadOnly)
                return;

            NodeMap nodemap = device.RemoteNodeList;
            Node node = BaumerHelper.GetNode(nodemap, property.Identifier);
            if (node == null || !node.IsReadable || !node.IsWriteable)
                return;
            
            long value = long.Parse(property.CurrentValue, CultureInfo.InvariantCulture);
            long min = node.Min;
            long step = node.Inc;

            // Do not clamp on max, the max is based on the offset instead of the true max.
            value = Math.Max(value, min);
            long remainder = (value - min) % step;
            if (remainder != 0)
                value = value - remainder + step;

            // Offset handling.
            // Some cameras have a CenterX/CenterY property.
            // When it is set, the offset is automatic and becomes read-only.
            // If the offset can be written we use the normal computation.
            Node nodeOffset = BaumerHelper.GetNode(nodemap, identifierOffset);
            bool setOffset = nodeOffset != null && node.IsReadable && node.IsWriteable;
            if (setOffset)
            {
                long currentValue = node.Value;
                long max = currentValue + nodeOffset.Max;
                long offset = (max - value) / 2;
                long minOffset = nodeOffset.Min;
                long stepOffset = nodeOffset.Inc;
                
                long remainderOffset = (offset - minOffset) % stepOffset;
                if (remainderOffset != 0)
                    offset = offset - remainderOffset + stepOffset;

                // We need to be careful with the order and not write a value that doesn't fit due to the offset, or vice versa.
                if (value > currentValue)
                {
                    nodeOffset.Value = offset;
                    node.Value = value;
                }
                else
                {
                    node.Value = value;
                    nodeOffset.Value = offset;
                }
            }
            else
            {
                node.Value = value;
            }
        }

        /// <summary>
        /// Write generic property with optional auto flag.
        /// </summary>
        private static void WriteProperty(Device device, CameraProperty property)
        {
            if (property.ReadOnly)
                return;

            NodeMap nodeMap = device.RemoteNodeList;

            // Switch OFF the auto flag if needed, to be able to write the main property.
            if (!string.IsNullOrEmpty(property.AutomaticIdentifier))
            {
                Node nodeAuto = BaumerHelper.GetNode(nodeMap, property.AutomaticIdentifier);
                if (nodeAuto != null)
                {
                    bool writeable = nodeAuto.IsWriteable;
                    bool currentAuto = ReadAuto(nodeAuto, property.AutomaticIdentifier);
                    if (writeable && property.CanBeAutomatic && currentAuto && !property.Automatic)
                        WriteAuto(nodeAuto, property.AutomaticIdentifier, false);
                }
            }

            // At this point the auto flag is off. Write the main property.
            Node node = BaumerHelper.GetNode(nodeMap, property.Identifier);
            if (node == null)
                return;

            if (!node.IsReadable || !node.IsWriteable)
                return;

            try
            {
                switch (property.Type)
                {
                    case CameraPropertyType.Integer:
                        {
                            long value = long.Parse(property.CurrentValue, CultureInfo.InvariantCulture);
                            long min = node.Min;
                            long max = node.Max;
                            long step = node.Inc;
                            value = FixValue(value, min, max, step);
                            node.Value = value;
                            break;
                        }
                    case CameraPropertyType.Float:
                        {
                            double value = double.Parse(property.CurrentValue, CultureInfo.InvariantCulture);
                            double min = node.Min;
                            double max = node.Max;
                            value = FixValue(value, min, max);
                            node.Value = value;
                            break;
                        }
                    case CameraPropertyType.Boolean:
                        {
                            bool value = bool.Parse(property.CurrentValue);
                            node.Value = value;
                            break;
                        }
                    default:
                        break;
                }
            }
            catch
            {
                log.ErrorFormat("Error while writing Baumer GenICam property {0}.", property.Identifier);
            }

            // Finally, switch ON the auto flag if needed.
            if (!string.IsNullOrEmpty(property.AutomaticIdentifier))
            {
                Node nodeAuto = BaumerHelper.GetNode(nodeMap, property.AutomaticIdentifier);
                if (nodeAuto != null && nodeAuto.IsWriteable && property.CanBeAutomatic && property.Automatic)
                    WriteAuto(nodeAuto, property.AutomaticIdentifier, true);
            }
        }

        private static long FixValue(long value, long min, long max, long step)
        {
            value = Math.Min(max, Math.Max(min, value));

            long remainder = value % step;
            if (remainder > 0)
                value = value - remainder;

            return value;
        }

        private static double FixValue(double value, double min, double max)
        {
            return Math.Min(max, Math.Max(min, value));
        }

        private static CameraPropertyRepresentation ConvertRepresentation(string representation)
        {
            switch (representation)
            {
                case "Linear":
                    return CameraPropertyRepresentation.LinearSlider;
                case "Logarithmic":
                    return CameraPropertyRepresentation.LogarithmicSlider;
                case "Boolean":
                    return CameraPropertyRepresentation.Checkbox;
                case "PureNumber":
                    return CameraPropertyRepresentation.EditBox;
                case "HexNumber":
                case "_UndefinedRepresentation":
                default:
                    return CameraPropertyRepresentation.Undefined;
            }
        }

        /// <summary>
        /// Read the auto property value and put it into a boolean.
        /// </summary>
        private static bool ReadAuto(Node node, string identifier)
        {
            switch (identifier)
            {
                case "AcquisitionFrameRateEnable":
                    {
                        string currentAutoValue = ((bool)node.Value).ToString(CultureInfo.InvariantCulture).ToLower();
                        return currentAutoValue == GetAutoTrue(identifier);
                    }
                case "GainAuto":
                case "ExposureAuto":
                default:
                    {
                        string currentAutoValue = node.Value;
                        return currentAutoValue == GetAutoTrue(identifier);
                    }
            }
        }

        /// <summary>
        /// Takes a boolean of whether auto is ON or OFF, convert it to the correct representation and write it in the auto property.
        /// </summary>
        private static void WriteAuto(Node node, string identifier, bool isAuto)
        {
            string newValue = isAuto ? GetAutoTrue(identifier) : GetAutoFalse(identifier);

            switch (identifier)
            {
                case "AcquisitionFrameRateEnable":
                    {
                        bool newValueBool = bool.Parse(newValue);
                        node.Value = newValueBool;
                        break;
                    }
                case "GainAuto":
                case "ExposureAuto":
                default:
                    {
                        node.Value = newValue;
                        break;
                    }
            }
        }

        /// <summary>
        /// Returns a string representation of the value of the auto property corresponding to when the main property IS automatically set.
        /// </summary>
        private static string GetAutoTrue(string identifier)
        {
            switch (identifier)
            {
                case "AcquisitionFrameRateEnable":
                    return "false";
                case "GainAuto":
                case "ExposureAuto":
                default:
                    return "Continuous";
            }
        }

        /// <summary>
        /// Returns a string representation of the value of the auto property corresponding to when the main property is NOT automatically set.
        /// </summary>
        private static string GetAutoFalse(string identifier)
        {
            switch (identifier)
            {
                case "AcquisitionFrameRateEnable":
                    return "true";
                case "GainAuto":
                case "ExposureAuto":
                default:
                    return "Off";
            }
        }
    }
}