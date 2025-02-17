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
namespace Kinovea.Camera.DirectShow
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
      this.btnDeviceProperties = new System.Windows.Forms.Button();
      this.btnApply = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblStreamFormat = new System.Windows.Forms.Label();
      this.cmbFormat = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblAuto = new System.Windows.Forms.Label();
      this.cmbImageSize = new System.Windows.Forms.ComboBox();
      this.lblImageSize = new System.Windows.Forms.Label();
      this.cmbFramerate = new System.Windows.Forms.ComboBox();
      this.lblFramerate = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tbAlias = new System.Windows.Forms.TextBox();
      this.lblSystemName = new System.Windows.Forms.Label();
      this.btnIcon = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnDeviceProperties
      // 
      this.btnDeviceProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDeviceProperties.Location = new System.Drawing.Point(255, 267);
      this.btnDeviceProperties.Name = "btnDeviceProperties";
      this.btnDeviceProperties.Size = new System.Drawing.Size(167, 24);
      this.btnDeviceProperties.TabIndex = 150;
      this.btnDeviceProperties.Text = "Device property pages";
      this.btnDeviceProperties.UseVisualStyleBackColor = true;
      this.btnDeviceProperties.Click += new System.EventHandler(this.btnDeviceProperties_Click);
      // 
      // btnApply
      // 
      this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnApply.Location = new System.Drawing.Point(249, 417);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(99, 24);
      this.btnApply.TabIndex = 200;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(354, 417);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(99, 24);
      this.btnCancel.TabIndex = 202;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // lblStreamFormat
      // 
      this.lblStreamFormat.BackColor = System.Drawing.Color.Transparent;
      this.lblStreamFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStreamFormat.ForeColor = System.Drawing.Color.Black;
      this.lblStreamFormat.Location = new System.Drawing.Point(21, 26);
      this.lblStreamFormat.Name = "lblStreamFormat";
      this.lblStreamFormat.Size = new System.Drawing.Size(187, 23);
      this.lblStreamFormat.TabIndex = 80;
      this.lblStreamFormat.Text = "Stream format:";
      this.lblStreamFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmbFormat
      // 
      this.cmbFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFormat.FormattingEnabled = true;
      this.cmbFormat.Location = new System.Drawing.Point(214, 26);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(151, 21);
      this.cmbFormat.TabIndex = 82;
      this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.lblAuto);
      this.groupBox1.Controls.Add(this.btnDeviceProperties);
      this.groupBox1.Controls.Add(this.cmbImageSize);
      this.groupBox1.Controls.Add(this.lblImageSize);
      this.groupBox1.Controls.Add(this.cmbFramerate);
      this.groupBox1.Controls.Add(this.lblFramerate);
      this.groupBox1.Controls.Add(this.cmbFormat);
      this.groupBox1.Controls.Add(this.lblStreamFormat);
      this.groupBox1.Location = new System.Drawing.Point(12, 94);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(441, 308);
      this.groupBox1.TabIndex = 80;
      this.groupBox1.TabStop = false;
      // 
      // lblAuto
      // 
      this.lblAuto.BackColor = System.Drawing.Color.Transparent;
      this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAuto.ForeColor = System.Drawing.Color.Black;
      this.lblAuto.Location = new System.Drawing.Point(379, 130);
      this.lblAuto.Name = "lblAuto";
      this.lblAuto.Size = new System.Drawing.Size(56, 23);
      this.lblAuto.TabIndex = 100;
      this.lblAuto.Text = "Auto";
      this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmbImageSize
      // 
      this.cmbImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbImageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbImageSize.FormattingEnabled = true;
      this.cmbImageSize.Location = new System.Drawing.Point(214, 57);
      this.cmbImageSize.Name = "cmbImageSize";
      this.cmbImageSize.Size = new System.Drawing.Size(151, 21);
      this.cmbImageSize.TabIndex = 84;
      this.cmbImageSize.SelectedIndexChanged += new System.EventHandler(this.cmbImageSize_SelectedIndexChanged);
      // 
      // lblImageSize
      // 
      this.lblImageSize.BackColor = System.Drawing.Color.Transparent;
      this.lblImageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblImageSize.ForeColor = System.Drawing.Color.Black;
      this.lblImageSize.Location = new System.Drawing.Point(21, 57);
      this.lblImageSize.Name = "lblImageSize";
      this.lblImageSize.Size = new System.Drawing.Size(187, 23);
      this.lblImageSize.TabIndex = 89;
      this.lblImageSize.Text = "Image size:";
      this.lblImageSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmbFramerate
      // 
      this.cmbFramerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFramerate.FormattingEnabled = true;
      this.cmbFramerate.Location = new System.Drawing.Point(214, 91);
      this.cmbFramerate.Name = "cmbFramerate";
      this.cmbFramerate.Size = new System.Drawing.Size(151, 21);
      this.cmbFramerate.TabIndex = 86;
      this.cmbFramerate.SelectedIndexChanged += new System.EventHandler(this.cmbFramerate_SelectedIndexChanged);
      // 
      // lblFramerate
      // 
      this.lblFramerate.BackColor = System.Drawing.Color.Transparent;
      this.lblFramerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFramerate.ForeColor = System.Drawing.Color.Black;
      this.lblFramerate.Location = new System.Drawing.Point(21, 91);
      this.lblFramerate.Name = "lblFramerate";
      this.lblFramerate.Size = new System.Drawing.Size(187, 23);
      this.lblFramerate.TabIndex = 87;
      this.lblFramerate.Text = "Framerate:";
      this.lblFramerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.tbAlias);
      this.groupBox2.Controls.Add(this.lblSystemName);
      this.groupBox2.Controls.Add(this.btnIcon);
      this.groupBox2.Location = new System.Drawing.Point(12, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(441, 76);
      this.groupBox2.TabIndex = 50;
      this.groupBox2.TabStop = false;
      // 
      // tbAlias
      // 
      this.tbAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbAlias.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.tbAlias.Location = new System.Drawing.Point(73, 22);
      this.tbAlias.Name = "tbAlias";
      this.tbAlias.Size = new System.Drawing.Size(349, 15);
      this.tbAlias.TabIndex = 54;
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
      this.btnIcon.TabIndex = 52;
      this.btnIcon.UseVisualStyleBackColor = false;
      this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
      // 
      // FormConfiguration
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(465, 453);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.btnCancel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormConfiguration";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Camera configuration";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblStreamFormat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDeviceProperties;
        private System.Windows.Forms.ComboBox cmbImageSize;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.ComboBox cmbFramerate;
        private System.Windows.Forms.Label lblFramerate;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnIcon;
    }
}
