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
using System.Windows.Forms;

using Kinovea.Camera;
using Kinovea.Services;
using Kinovea.Camera.Languages;

namespace Kinovea.Camera.HTTP
{
    public partial class FormConfiguration : Form
    {
        public bool AliasChanged
        {
            get { return iconChanged || tbAlias.Text != summary.Alias;}
        }
        
        public string Alias 
        { 
            get { return tbAlias.Text; }
        }
        
        public Bitmap PickedIcon
        { 
            get { return (Bitmap)btnIcon.BackgroundImage; }
        }
        
        public bool SpecificChanged
        {
            get { return wizard.GetSpecific() != (summary.Specific as SpecificInfo);}
        }
        
        public SpecificInfo Specific
        {
            get { return wizard.GetSpecific();}
        }
        
        private bool iconChanged;
        private ConnectionWizard wizard;
        private CameraSummary summary;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public FormConfiguration(CameraSummary summary)
        {
            this.summary = summary;
            
            InitializeComponent();

            Initialize();

            tbAlias.Text = summary.Alias;
            lblSystemName.Text = summary.Name;
            btnIcon.BackgroundImage = summary.Icon;
            
            wizard = (ConnectionWizard)summary.Manager.GetConnectionWizard();
            wizard.Location = new Point(8, 18);
            gpParameters.Controls.Add(wizard);
            wizard.Populate((summary.Specific as SpecificInfo).Clone());
        }

        private void Initialize()
        {
            this.Text = CameraLang.FormConfiguration_Title;
            btnTest.Text = CameraLang.FormConfiguration_Test;
            btnApply.Text = CameraLang.Generic_Apply;
            btnCancel.Text = CameraLang.Generic_Cancel;
        }
        
        private void BtnIconClick(object sender, EventArgs e)
        {
            FormIconPicker fip = new FormIconPicker(IconLibrary.Icons, 5);
            FormsHelper.Locate(fip);
            if(fip.ShowDialog() == DialogResult.OK)
            {
                btnIcon.BackgroundImage = fip.PickedIcon;
                iconChanged = true;
            }
            
            fip.Dispose();
        }
        
        private void BtnTest_Click(object sender, EventArgs e)
        {
            wizard.TestCamera();
        }
    }
}

