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
namespace Kinovea.Camera.FrameGenerator
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
      this.btnApply = new System.Windows.Forms.Button();
      this.btnIcon = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tbAlias = new System.Windows.Forms.TextBox();
      this.lblSystemName = new System.Windows.Forms.Label();
      this.gbProperties = new System.Windows.Forms.GroupBox();
      this.lblAuto = new System.Windows.Forms.Label();
      this.cmbFormat = new System.Windows.Forms.ComboBox();
      this.lblColorSpace = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.gbProperties.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnApply
      // 
      this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnApply.Location = new System.Drawing.Point(361, 308);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(99, 24);
      this.btnApply.TabIndex = 200;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      // 
      // btnIcon
      // 
      this.btnIcon.BackColor = System.Drawing.Color.Transparent;
      this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnIcon.FlatAppearance.BorderSize = 0;
      this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnIcon.Location = new System.Drawing.Point(24, 26);
      this.btnIcon.Name = "btnIcon";
      this.btnIcon.Size = new System.Drawing.Size(16, 16);
      this.btnIcon.TabIndex = 50;
      this.btnIcon.UseVisualStyleBackColor = false;
      this.btnIcon.Click += new System.EventHandler(this.BtnIconClick);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.tbAlias);
      this.groupBox1.Controls.Add(this.lblSystemName);
      this.groupBox1.Controls.Add(this.btnIcon);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(448, 74);
      this.groupBox1.TabIndex = 84;
      this.groupBox1.TabStop = false;
      // 
      // tbAlias
      // 
      this.tbAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbAlias.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.tbAlias.Location = new System.Drawing.Point(73, 26);
      this.tbAlias.Name = "tbAlias";
      this.tbAlias.Size = new System.Drawing.Size(223, 15);
      this.tbAlias.TabIndex = 52;
      this.tbAlias.Text = "Alias";
      // 
      // lblSystemName
      // 
      this.lblSystemName.AutoSize = true;
      this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
      this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSystemName.ForeColor = System.Drawing.Color.Black;
      this.lblSystemName.Location = new System.Drawing.Point(68, 45);
      this.lblSystemName.Name = "lblSystemName";
      this.lblSystemName.Size = new System.Drawing.Size(70, 13);
      this.lblSystemName.TabIndex = 85;
      this.lblSystemName.Text = "System name";
      this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // gbProperties
      // 
      this.gbProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbProperties.Controls.Add(this.lblAuto);
      this.gbProperties.Controls.Add(this.cmbFormat);
      this.gbProperties.Controls.Add(this.lblColorSpace);
      this.gbProperties.Location = new System.Drawing.Point(12, 98);
      this.gbProperties.Name = "gbProperties";
      this.gbProperties.Size = new System.Drawing.Size(448, 204);
      this.gbProperties.TabIndex = 89;
      this.gbProperties.TabStop = false;
      // 
      // lblAuto
      // 
      this.lblAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblAuto.BackColor = System.Drawing.Color.Transparent;
      this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAuto.ForeColor = System.Drawing.Color.Black;
      this.lblAuto.Location = new System.Drawing.Point(381, 61);
      this.lblAuto.Name = "lblAuto";
      this.lblAuto.Size = new System.Drawing.Size(52, 23);
      this.lblAuto.TabIndex = 102;
      this.lblAuto.Text = "Auto";
      this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmbFormat
      // 
      this.cmbFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFormat.FormattingEnabled = true;
      this.cmbFormat.Location = new System.Drawing.Point(214, 28);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(163, 21);
      this.cmbFormat.TabIndex = 80;
      this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
      // 
      // lblColorSpace
      // 
      this.lblColorSpace.BackColor = System.Drawing.Color.Transparent;
      this.lblColorSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblColorSpace.ForeColor = System.Drawing.Color.Black;
      this.lblColorSpace.Location = new System.Drawing.Point(21, 26);
      this.lblColorSpace.Name = "lblColorSpace";
      this.lblColorSpace.Size = new System.Drawing.Size(187, 23);
      this.lblColorSpace.TabIndex = 96;
      this.lblColorSpace.Text = "Stream format:";
      this.lblColorSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FormConfiguration
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(472, 344);
      this.Controls.Add(this.gbProperties);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnApply);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormConfiguration";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormConfiguration";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.gbProperties.ResumeLayout(false);
      this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblColorSpace;
        private System.Windows.Forms.Label lblAuto;
    }
}
