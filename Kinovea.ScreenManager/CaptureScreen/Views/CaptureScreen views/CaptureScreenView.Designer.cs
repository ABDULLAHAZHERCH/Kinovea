#region License
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
namespace Kinovea.ScreenManager
{
    partial class CaptureScreenView
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDrawingToolsBar = new System.Windows.Forms.Panel();
            this.btnFoldCapturedVideosPanel = new System.Windows.Forms.Button();
            this.pnlCapturedVideos = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.fnbVideo = new Kinovea.ScreenManager.FilenameBox();
            this.fnbImage = new Kinovea.ScreenManager.FilenameBox();
            this.pnlCaptureDock = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGrab = new System.Windows.Forms.Button();
            this.btnArm = new System.Windows.Forms.Button();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.sldrDelay = new Kinovea.ScreenManager.SliderLinear();
            this.lblDelay = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.infobarCapture = new Kinovea.ScreenManager.InfobarCapture();
            this.btnIcon = new System.Windows.Forms.Button();
            this.lblCameraTitle = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.pnlControls.SuspendLayout();
            this.pnlDrawingToolsBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.pnlCaptureDock.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlControls.Controls.Add(this.button1);
            this.pnlControls.Controls.Add(this.pnlDrawingToolsBar);
            this.pnlControls.Controls.Add(this.pnlCapturedVideos);
            this.pnlControls.Controls.Add(this.buttonPlay);
            this.pnlControls.Controls.Add(this.btnRecord);
            this.pnlControls.Controls.Add(this.nudDelay);
            this.pnlControls.Controls.Add(this.fnbVideo);
            this.pnlControls.Controls.Add(this.fnbImage);
            this.pnlControls.Controls.Add(this.pnlCaptureDock);
            this.pnlControls.Controls.Add(this.sldrDelay);
            this.pnlControls.Controls.Add(this.lblDelay);
            this.pnlControls.Location = new System.Drawing.Point(0, 720);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlControls.MinimumSize = new System.Drawing.Size(262, 100);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1261, 100);
            this.pnlControls.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Kinovea.ScreenManager.Properties.Resources.check_mark1;
            this.button1.Location = new System.Drawing.Point(110, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.MinimumSize = new System.Drawing.Size(45, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDrawingToolsBar
            // 
            this.pnlDrawingToolsBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawingToolsBar.AutoScroll = true;
            this.pnlDrawingToolsBar.BackColor = System.Drawing.Color.White;
            this.pnlDrawingToolsBar.Controls.Add(this.btnFoldCapturedVideosPanel);
            this.pnlDrawingToolsBar.Location = new System.Drawing.Point(1230, 64);
            this.pnlDrawingToolsBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDrawingToolsBar.Name = "pnlDrawingToolsBar";
            this.pnlDrawingToolsBar.Size = new System.Drawing.Size(31, 43);
            this.pnlDrawingToolsBar.TabIndex = 5;
            this.pnlDrawingToolsBar.Visible = false;
            this.pnlDrawingToolsBar.DoubleClick += new System.EventHandler(this.BtnCapturedVideosFold_Click);
            // 
            // btnFoldCapturedVideosPanel
            // 
            this.btnFoldCapturedVideosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoldCapturedVideosPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnFoldCapturedVideosPanel.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.dock16x16;
            this.btnFoldCapturedVideosPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFoldCapturedVideosPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoldCapturedVideosPanel.FlatAppearance.BorderSize = 0;
            this.btnFoldCapturedVideosPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFoldCapturedVideosPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFoldCapturedVideosPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoldCapturedVideosPanel.Location = new System.Drawing.Point(-3, -6);
            this.btnFoldCapturedVideosPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFoldCapturedVideosPanel.Name = "btnFoldCapturedVideosPanel";
            this.btnFoldCapturedVideosPanel.Size = new System.Drawing.Size(30, 31);
            this.btnFoldCapturedVideosPanel.TabIndex = 17;
            this.btnFoldCapturedVideosPanel.UseVisualStyleBackColor = false;
            this.btnFoldCapturedVideosPanel.Click += new System.EventHandler(this.BtnCapturedVideosFold_Click);
            // 
            // pnlCapturedVideos
            // 
            this.pnlCapturedVideos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCapturedVideos.AutoScroll = true;
            this.pnlCapturedVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlCapturedVideos.Location = new System.Drawing.Point(1200, 54);
            this.pnlCapturedVideos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCapturedVideos.Name = "pnlCapturedVideos";
            this.pnlCapturedVideos.Size = new System.Drawing.Size(0, 53);
            this.pnlCapturedVideos.TabIndex = 4;
            this.pnlCapturedVideos.Visible = false;
            this.pnlCapturedVideos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCapturedVideos_Paint);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::Kinovea.ScreenManager.Properties.Resources.flatplay;
            this.buttonPlay.Location = new System.Drawing.Point(50, 20);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlay.MinimumSize = new System.Drawing.Size(45, 38);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(52, 53);
            this.buttonPlay.TabIndex = 49;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Image = global::Kinovea.ScreenManager.Properties.Capture.record_start;
            this.btnRecord.Location = new System.Drawing.Point(8, 23);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecord.MinimumSize = new System.Drawing.Size(30, 38);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(55, 50);
            this.btnRecord.TabIndex = 24;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.BtnRecordClick);
            // 
            // nudDelay
            // 
            this.nudDelay.DecimalPlaces = 2;
            this.nudDelay.Location = new System.Drawing.Point(821, 121);
            this.nudDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(78, 26);
            this.nudDelay.TabIndex = 48;
            this.nudDelay.Visible = false;
            this.nudDelay.ValueChanged += new System.EventHandler(this.NudDelay_ValueChanged);
            // 
            // fnbVideo
            // 
            this.fnbVideo.BackColor = System.Drawing.Color.Transparent;
            this.fnbVideo.Editable = true;
            this.fnbVideo.Filename = "";
            this.fnbVideo.Image = global::Kinovea.ScreenManager.Properties.Capture.folder_camera;
            this.fnbVideo.InfoText = "Video:";
            this.fnbVideo.Location = new System.Drawing.Point(1180, 62);
            this.fnbVideo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.fnbVideo.Name = "fnbVideo";
            this.fnbVideo.Size = new System.Drawing.Size(63, 42);
            this.fnbVideo.TabIndex = 42;
            this.fnbVideo.Visible = false;
            this.fnbVideo.ImageClick += new System.EventHandler(this.FNBVideo_ImageClick);
            this.fnbVideo.FilenameChanged += new System.EventHandler(this.FnbVideo_FilenameChanged);
            // 
            // fnbImage
            // 
            this.fnbImage.BackColor = System.Drawing.Color.Transparent;
            this.fnbImage.Editable = true;
            this.fnbImage.Filename = "";
            this.fnbImage.Image = global::Kinovea.ScreenManager.Properties.Capture.folder_image;
            this.fnbImage.InfoText = "Image:";
            this.fnbImage.Location = new System.Drawing.Point(1206, 58);
            this.fnbImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.fnbImage.Name = "fnbImage";
            this.fnbImage.Size = new System.Drawing.Size(68, 42);
            this.fnbImage.TabIndex = 41;
            this.fnbImage.Visible = false;
            this.fnbImage.ImageClick += new System.EventHandler(this.FNBImage_ImageClick);
            this.fnbImage.FilenameChanged += new System.EventHandler(this.FnbImage_FilenameChanged);
            this.fnbImage.Load += new System.EventHandler(this.fnbImage_Load);
            // 
            // pnlCaptureDock
            // 
            this.pnlCaptureDock.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.capturedock5;
            this.pnlCaptureDock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCaptureDock.Controls.Add(this.btnSettings);
            this.pnlCaptureDock.Controls.Add(this.btnGrab);
            this.pnlCaptureDock.Controls.Add(this.btnArm);
            this.pnlCaptureDock.Controls.Add(this.btnSnapshot);
            this.pnlCaptureDock.Location = new System.Drawing.Point(1200, 77);
            this.pnlCaptureDock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCaptureDock.Name = "pnlCaptureDock";
            this.pnlCaptureDock.Size = new System.Drawing.Size(98, 65);
            this.pnlCaptureDock.TabIndex = 40;
            this.pnlCaptureDock.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::Kinovea.ScreenManager.Properties.Capture.settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.MinimumSize = new System.Drawing.Size(45, 38);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 38);
            this.btnSettings.TabIndex = 39;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettingsClick);
            // 
            // btnGrab
            // 
            this.btnGrab.BackColor = System.Drawing.Color.Transparent;
            this.btnGrab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrab.FlatAppearance.BorderSize = 0;
            this.btnGrab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrab.Image = global::Kinovea.ScreenManager.Properties.Capture.grab_pause;
            this.btnGrab.Location = new System.Drawing.Point(53, 0);
            this.btnGrab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrab.MinimumSize = new System.Drawing.Size(45, 38);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(45, 38);
            this.btnGrab.TabIndex = 0;
            this.btnGrab.UseVisualStyleBackColor = false;
            this.btnGrab.Visible = false;
            this.btnGrab.Click += new System.EventHandler(this.BtnGrabClick);
            // 
            // btnArm
            // 
            this.btnArm.BackColor = System.Drawing.Color.Transparent;
            this.btnArm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArm.FlatAppearance.BorderSize = 0;
            this.btnArm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArm.Image = global::Kinovea.ScreenManager.Properties.Capture.speaker;
            this.btnArm.Location = new System.Drawing.Point(106, 0);
            this.btnArm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArm.MinimumSize = new System.Drawing.Size(45, 38);
            this.btnArm.Name = "btnArm";
            this.btnArm.Size = new System.Drawing.Size(45, 38);
            this.btnArm.TabIndex = 40;
            this.btnArm.UseVisualStyleBackColor = false;
            this.btnArm.Visible = false;
            this.btnArm.Click += new System.EventHandler(this.btnArm_Click);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.BackColor = System.Drawing.Color.Transparent;
            this.btnSnapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSnapshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnapshot.FlatAppearance.BorderSize = 0;
            this.btnSnapshot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSnapshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapshot.Image = global::Kinovea.ScreenManager.Properties.Resources.camerasingle;
            this.btnSnapshot.Location = new System.Drawing.Point(148, 9);
            this.btnSnapshot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSnapshot.MinimumSize = new System.Drawing.Size(38, 38);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(45, 38);
            this.btnSnapshot.TabIndex = 30;
            this.btnSnapshot.Tag = "";
            this.btnSnapshot.UseVisualStyleBackColor = false;
            this.btnSnapshot.Visible = false;
            this.btnSnapshot.Click += new System.EventHandler(this.BtnSnapshot_Click);
            // 
            // sldrDelay
            // 
            this.sldrDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sldrDelay.Location = new System.Drawing.Point(1174, 62);
            this.sldrDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sldrDelay.Maximum = 100D;
            this.sldrDelay.Minimum = 0D;
            this.sldrDelay.Name = "sldrDelay";
            this.sldrDelay.Size = new System.Drawing.Size(94, 35);
            this.sldrDelay.Sticky = false;
            this.sldrDelay.StickyValue = 0D;
            this.sldrDelay.TabIndex = 43;
            this.sldrDelay.Text = "sliderLinear1";
            this.sldrDelay.Value = 0D;
            this.sldrDelay.Visible = false;
            this.sldrDelay.Click += new System.EventHandler(this.sldrDelay_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.BackColor = System.Drawing.Color.Transparent;
            this.lblDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.Location = new System.Drawing.Point(907, 125);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(69, 17);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay (s):";
            this.lblDelay.Visible = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.infobarCapture);
            this.pnlTitle.Controls.Add(this.btnIcon);
            this.pnlTitle.Controls.Add(this.lblCameraTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1261, 37);
            this.pnlTitle.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.closegrey;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1227, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // infobarCapture
            // 
            this.infobarCapture.AutoSize = true;
            this.infobarCapture.BackColor = System.Drawing.Color.Transparent;
            this.infobarCapture.Enabled = false;
            this.infobarCapture.Location = new System.Drawing.Point(188, 3);
            this.infobarCapture.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.infobarCapture.Name = "infobarCapture";
            this.infobarCapture.Size = new System.Drawing.Size(868, 34);
            this.infobarCapture.TabIndex = 0;
            this.infobarCapture.Visible = false;
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(8, 3);
            this.btnIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(30, 31);
            this.btnIcon.TabIndex = 6;
            this.btnIcon.UseVisualStyleBackColor = false;
            this.btnIcon.Click += new System.EventHandler(this.LblCameraInfoClick);
            // 
            // lblCameraTitle
            // 
            this.lblCameraTitle.AutoSize = true;
            this.lblCameraTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCameraTitle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraTitle.Location = new System.Drawing.Point(45, 9);
            this.lblCameraTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCameraTitle.Name = "lblCameraTitle";
            this.lblCameraTitle.Size = new System.Drawing.Size(117, 20);
            this.lblCameraTitle.TabIndex = 4;
            this.lblCameraTitle.Text = "Camera title";
            this.lblCameraTitle.Click += new System.EventHandler(this.LblCameraInfoClick);
            // 
            // pnlViewport
            // 
            this.pnlViewport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlViewport.Location = new System.Drawing.Point(0, 38);
            this.pnlViewport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewport.MinimumSize = new System.Drawing.Size(518, 38);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1261, 684);
            this.pnlViewport.TabIndex = 6;
            this.pnlViewport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlViewport_Paint);
            // 
            // toolTips
            // 
            this.toolTips.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTips_Popup);
            // 
            // CaptureScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlControls);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "CaptureScreenView";
            this.Size = new System.Drawing.Size(1261, 828);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlDrawingToolsBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.pnlCaptureDock.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }
        private Kinovea.ScreenManager.FilenameBox fnbImage;
        private Kinovea.ScreenManager.FilenameBox fnbVideo;
        private System.Windows.Forms.Button btnFoldCapturedVideosPanel;
        private System.Windows.Forms.Panel pnlDrawingToolsBar;
        private System.Windows.Forms.Label lblCameraTitle;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlCapturedVideos;
        private System.Windows.Forms.Label lblDelay;
        public System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.ToolTip toolTips;
        private InfobarCapture infobarCapture;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Button btnArm;
        private System.Windows.Forms.Panel pnlCaptureDock;
        private System.Windows.Forms.Button buttonPlay;
        private SliderLinear sldrDelay;
        private System.Windows.Forms.Button button1;
    }
}
