﻿#region License
/*
Copyright © Joan Charmant 2020.
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
using System.Xml;

using Kinovea.Services;

namespace Kinovea.ScreenManager
{
    public class GenericPosturePolyline
    {
        public string Name { get; private set; }
        public List<int> Points { get; private set;}
        public SegmentLineStyle Style { get; private set;}
        public int Width { get; private set;}
        public bool ArrowEnd { get; private set; }
        public bool ArrowBegin { get; private set; }
        public Color Color { get; private set; }
        public string OptionGroup { get; private set;}
        
        public GenericPosturePolyline(XmlReader r)
        {
            // <Polyline name="Spinal cord" points="0;1;2;3" style="Solid" width="2" color="#FF0000" />
            Name = "";
            Width = 2;
            Style = SegmentLineStyle.Solid;
            Color = Color.Transparent;
            OptionGroup = "";
            
            bool isEmpty = r.IsEmptyElement;

            if (r.MoveToAttribute("name"))
                Name = r.ReadContentAsString();

            if (r.MoveToAttribute("points"))
                Points = XmlHelper.ParseIntList(r.ReadContentAsString());

            if(r.MoveToAttribute("style"))
                Style = (SegmentLineStyle) Enum.Parse(typeof(SegmentLineStyle), r.ReadContentAsString());
            
            if(r.MoveToAttribute("width"))
                Width = r.ReadContentAsInt();

            if(r.MoveToAttribute("arrowBegin"))
                ArrowBegin = XmlHelper.ParseBoolean(r.ReadContentAsString());

            if (r.MoveToAttribute("arrowStart"))
                ArrowBegin = XmlHelper.ParseBoolean(r.ReadContentAsString());

            if (r.MoveToAttribute("arrowEnd"))
                ArrowEnd = XmlHelper.ParseBoolean(r.ReadContentAsString());
            
            if(r.MoveToAttribute("color"))
                Color = XmlHelper.ParseColor(r.ReadContentAsString(), Color);
            
            if(r.MoveToAttribute("optionGroup"))
                OptionGroup = r.ReadContentAsString();
                
            r.ReadStartElement();
            
            if(isEmpty)
                return;
            
            // Read sub elements.
            //r.ReadEndElement();
        }
    }
}