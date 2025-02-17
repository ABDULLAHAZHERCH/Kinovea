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
using System.Collections.Generic;
using System.Drawing;
using Kinovea.Services;

namespace Kinovea.ScreenManager
{
    /// <summary>
    /// List of the last captured files (for this session).
    /// </summary>
    public class CapturedFiles
    {
        public CapturedFilesView View
        {
            get { return view;}
        }
        public bool HasThumbnails
        {
            get { return view.HasThumbnails; }
        }
        
        private CapturedFilesView view;
        
        public CapturedFiles()
        {
            view = new CapturedFilesView();
            
        }
        public void AddFile(string filename, Bitmap image, bool video, ImageRotation rotation)
        {
            CapturedFile capturedFile = new CapturedFile(filename, image, video, rotation);
            view.AddFile(capturedFile);
        }
    }
}
