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
using System.Linq;

using Kinovea.Camera;
using Kinovea.FileBrowser.Languages;

namespace Kinovea.FileBrowser
{
    public partial class FormCameraWizard : Form
    {
        public CameraSummary Result
        {
            get 
            {
                if(currentWizard == null)
                    return null;
                
                return currentWizard.GetResult();
            }
        }
        private List<CameraManager> cameraManagers;
        private IConnectionWizard currentWizard;
        
        public FormCameraWizard()
        {
            InitializeComponent();
            
            cameraManagers = CameraTypeManager.CameraManagers.Where(m => m.HasConnectionWizard).ToList();
            cameraManagers.Sort((a, b) => a.CameraType.CompareTo(b.CameraType));

            Initialize();
            Populate();
        }
        
        private void Initialize()
        {
            this.Text = FileBrowserLang.FormCameraWizard_Title;
            lblCameraType.Text = FileBrowserLang.FormCameraWizard_CameraType;
            gpParameters.Text = FileBrowserLang.FormCameraWizard_Parameters;
            btnTest.Text = FileBrowserLang.FormCameraWizard_Test;
            btnApply.Text = FileBrowserLang.FormCameraWizard_Create;
            btnCancel.Text = FileBrowserLang.Generic_Cancel;
        }

        private void Populate()
        {
            // Fill main combo
            foreach(CameraManager manager in cameraManagers)
                cbCameraType.Items.Add(manager);
            
            if(cbCameraType.Items.Count > 0)
                cbCameraType.SelectedIndex = 0;
        }
        
        private void CbCameraTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            gpParameters.Controls.Clear();
            
            CameraManager manager = cbCameraType.SelectedItem as CameraManager;
            if(manager == null)
                return;
            
            Control wizard = manager.GetConnectionWizard();
            wizard.Location = new Point(8, 18);
            currentWizard = wizard as IConnectionWizard;
            gpParameters.Controls.Add(wizard);
        }
        
        private void BtnTest_Click(object sender, EventArgs e)
        {
            currentWizard.TestCamera();
        }
    }
}
