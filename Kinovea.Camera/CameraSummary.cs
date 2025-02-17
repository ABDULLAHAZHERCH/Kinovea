﻿#region License
/*
Copyright © Joan Charmant 2012.
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
using Kinovea.Services;

namespace Kinovea.Camera
{
    /// <summary>
    /// This class contains the necessary info to represent, identify and connect to a camera.
    /// It has a pointer to its manager and a blob of manager-specific data.
    /// </summary>
    public class CameraSummary
    {
        #region Properties
        /// <summary>
        /// User defined alias for the device.
        /// </summary>
        public string Alias { get; private set;}
        
        /// <summary>
        /// Vendor defined name of the device, typically the model.
        /// </summary>
        public string Name { get; private set;}
        
        /// <summary>
        /// Unique string identifying the device.
        /// </summary>
        public string Identifier { get; private set;}
        
        /// <summary>
        /// Custom icon assigned to the device.
        /// </summary>
        public Bitmap Icon { get; private set; }
        
        /// <summary>
        /// Where to paint the camera image in the viewport.
        /// </summary>
        public Rectangle DisplayRectangle { get; set; }
        
        /// <summary>
        /// Custom aspect ratio to display images at.
        /// </summary>
        public CaptureAspectRatio AspectRatio { get; private set; }
        
        /// <summary>
        /// Whether to rotate the image.
        /// </summary>
        public ImageRotation Rotation { get; private set; }
        
        /// <summary>
        /// Whether we should mirror the image horizontally.
        /// </summary>
        public bool Mirror { get; private set; }
        
        /// <summary>
        /// Opaque dada structure specific to the camera type.
        /// This contains user values for camera properties. 
        /// </summary>
        public object Specific { get; private set;}
        
        /// <summary>
        /// Parent camera manager that discovered this device.
        /// </summary>
        public CameraManager Manager { get; private set;}
        #endregion

        /// <summary>
        /// Build a full camera summary.
        /// This is normally used when we have obtained all the info from an XML blurb of that camera.
        /// </summary>
        public CameraSummary(string alias, string name, string identifier, Bitmap icon, Rectangle displayRectangle, CaptureAspectRatio aspectRatio, ImageRotation rotation, bool mirror, object specific, CameraManager manager)
        {
            this.Alias = alias;
            this.Name = name;
            this.Identifier = identifier;
            this.Icon = icon;
            this.DisplayRectangle = displayRectangle;
            this.AspectRatio = aspectRatio;
            this.Rotation = rotation;
            this.Mirror = mirror;
            this.Specific = specific;
            this.Manager = manager;
        }

        /// <summary>
        /// Build a default camera summary.
        /// This is used for certain camera types.
        /// </summary>
        public CameraSummary(string alias, string name, string identifier, Bitmap icon, CameraManager manager)
        {
            this.Alias = alias;
            this.Name = name;
            this.Identifier = identifier;
            this.Icon = icon;
            this.DisplayRectangle = Rectangle.Empty;
            this.AspectRatio = CaptureAspectRatio.Auto;
            this.Rotation = ImageRotation.Rotate0;
            this.Mirror = false;
            this.Specific = null;
            this.Manager = manager;
        }

        /// <summary>
        /// Build an invalid camera summary containing just the camera alias.
        /// This is used to prepare a capture screen that will then listen to new cameras being plugged in and try to match them against the alias.
        /// </summary>
        public CameraSummary(string alias)
        {
            this.Alias = alias;
            this.Name = null;
            this.Identifier = null;
            this.Icon = null;
            this.DisplayRectangle = Rectangle.Empty;
            this.AspectRatio = CaptureAspectRatio.Auto;
            this.Rotation = ImageRotation.Rotate0;
            this.Mirror = false;
            this.Specific = null;
            this.Manager = null;
        }
        
        public void UpdateAlias(string alias, Bitmap icon)
        {
            this.Alias = alias;
            this.Icon = icon;
        }
        
        public void UpdateDisplayRectangle(Rectangle imageLocation)
        {
            this.DisplayRectangle = imageLocation;
        }
        
        public void UpdateAspectRatio(CaptureAspectRatio aspectRatio)
        {
            if(aspectRatio == this.AspectRatio)
                return;
                
            this.AspectRatio = aspectRatio;
        }

        public void UpdateRotation(ImageRotation rotation)
        {
            this.Rotation = rotation;
        }
        
        public void UpdateMirror(bool mirror)
        {
            this.Mirror = mirror;
        }

        public void UpdateSpecific(object specific)
        {
            this.Specific = specific;
        }
    }
}
