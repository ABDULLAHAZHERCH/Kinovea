using System;
namespace Kinovea.ScreenManager
{
    partial class PlayerScreenUserInterface
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerScreenUserInterface));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSidePanel = new System.Windows.Forms.Button();
            this.btnExitFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelVideoControls = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sldrSpeed = new Kinovea.ScreenManager.SliderLinear();
            this.pnlThumbnails = new System.Windows.Forms.Panel();
            this.lblTimeTip = new System.Windows.Forms.Label();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.lblSpeedTuner = new System.Windows.Forms.Label();
            this.trkFrame = new Kinovea.ScreenManager.FrameTracker();
            this.trkSelection = new Kinovea.ScreenManager.SelectionTracker();
            this.btnHandlersReset = new System.Windows.Forms.Button();
            this.btnSetHandlerRight = new System.Windows.Forms.Button();
            this.btnExportVideoWithPauses = new System.Windows.Forms.Button();
            this.btnSetHandlerLeft = new System.Windows.Forms.Button();
            this.btnExportVideo = new System.Windows.Forms.Button();
            this.btnExportVideoSlideshow = new System.Windows.Forms.Button();
            this.btnExportImageSequence = new System.Windows.Forms.Button();
            this.btn_HandlersLock = new System.Windows.Forms.Button();
            this.buttonGotoFirst = new System.Windows.Forms.Button();
            this.buttonGotoPrevious = new System.Windows.Forms.Button();
            this.buttonGotoNext = new System.Windows.Forms.Button();
            this.btnTimeOrigin = new System.Windows.Forms.Button();
            this.lblTimeCode = new System.Windows.Forms.Label();
            this.lblSelStartSelection = new System.Windows.Forms.Label();
            this.lblSelDuration = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonGotoLast = new System.Windows.Forms.Button();
            this.groupBoxSpeedTuner = new System.Windows.Forms.GroupBox();
            this.markerSpeedTuner = new System.Windows.Forms.Button();
            this.PrimarySelection = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.ImageResizerNE = new System.Windows.Forms.Label();
            this.ImageResizerNW = new System.Windows.Forms.Label();
            this.ImageResizerSW = new System.Windows.Forms.Label();
            this.ImageResizerSE = new System.Windows.Forms.Label();
            this.pbSurfaceScreen = new System.Windows.Forms.PictureBox();
            this.dbgAvailableRam = new System.Windows.Forms.Label();
            this.dbgDurationFrames = new System.Windows.Forms.Label();
            this.dbgCurrentFrame = new System.Windows.Forms.Label();
            this.dbgCurrentPositionRel = new System.Windows.Forms.Label();
            this.dbgStartOffset = new System.Windows.Forms.Label();
            this.dbgCurrentPositionAbs = new System.Windows.Forms.Label();
            this.dbgDrops = new System.Windows.Forms.Label();
            this.dbgSelectionDuration = new System.Windows.Forms.Label();
            this.dbgSelectionEnd = new System.Windows.Forms.Label();
            this.dbgSelectionStart = new System.Windows.Forms.Label();
            this.dbgFFps = new System.Windows.Forms.Label();
            this.dbgDurationTimeStamps = new System.Windows.Forms.Label();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.splitKeyframes = new System.Windows.Forms.SplitContainer();
            this.splitViewport_Properties = new System.Windows.Forms.SplitContainer();
            this.tabProperties = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imgListPropertyTabs = new System.Windows.Forms.ImageList(this.components);
            this.stripDrawingTools = new System.Windows.Forms.ToolStrip();
            this.btnDockBottom = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelVideoControls.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSpeedTuner.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitKeyframes)).BeginInit();
            this.splitKeyframes.Panel1.SuspendLayout();
            this.splitKeyframes.Panel2.SuspendLayout();
            this.splitKeyframes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitViewport_Properties)).BeginInit();
            this.splitViewport_Properties.Panel1.SuspendLayout();
            this.splitViewport_Properties.Panel2.SuspendLayout();
            this.splitViewport_Properties.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnSidePanel);
            this.panelTop.Controls.Add(this.btnExitFilter);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1298, 38);
            this.panelTop.TabIndex = 0;
            // 
            // btnSidePanel
            // 
            this.btnSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.btnSidePanel.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.sidepanel;
            this.btnSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSidePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSidePanel.FlatAppearance.BorderSize = 0;
            this.btnSidePanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSidePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidePanel.Location = new System.Drawing.Point(1223, 3);
            this.btnSidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSidePanel.Name = "btnSidePanel";
            this.btnSidePanel.Size = new System.Drawing.Size(30, 31);
            this.btnSidePanel.TabIndex = 28;
            this.btnSidePanel.UseVisualStyleBackColor = false;
            this.btnSidePanel.Visible = false;
            this.btnSidePanel.Click += new System.EventHandler(this.btnSidePanel_Click);
            // 
            // btnExitFilter
            // 
            this.btnExitFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnExitFilter.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.exit_filter;
            this.btnExitFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExitFilter.FlatAppearance.BorderSize = 0;
            this.btnExitFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFilter.Location = new System.Drawing.Point(1184, 3);
            this.btnExitFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitFilter.Name = "btnExitFilter";
            this.btnExitFilter.Size = new System.Drawing.Size(30, 31);
            this.btnExitFilter.TabIndex = 3;
            this.btnExitFilter.UseVisualStyleBackColor = false;
            this.btnExitFilter.Visible = false;
            this.btnExitFilter.Click += new System.EventHandler(this.btnExitFilter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.closegrey;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1262, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelVideoControls
            // 
            this.panelVideoControls.BackColor = System.Drawing.Color.White;
            this.panelVideoControls.Controls.Add(this.btnRecord);
            this.panelVideoControls.Controls.Add(this.button1);
            this.panelVideoControls.Controls.Add(this.panel1);
            this.panelVideoControls.Controls.Add(this.buttonPlay);
            this.panelVideoControls.Controls.Add(this.buttonGotoLast);
            this.panelVideoControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVideoControls.Location = new System.Drawing.Point(0, 728);
            this.panelVideoControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelVideoControls.MinimumSize = new System.Drawing.Size(262, 80);
            this.panelVideoControls.Name = "panelVideoControls";
            this.panelVideoControls.Size = new System.Drawing.Size(1298, 100);
            this.panelVideoControls.TabIndex = 2;
            this.panelVideoControls.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVideoControls_Paint);
            this.panelVideoControls.MouseEnter += new System.EventHandler(this.PanelVideoControls_MouseEnter);
            this.panelVideoControls.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Common_MouseWheel);
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
            this.btnRecord.TabIndex = 25;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Kinovea.ScreenManager.Properties.Resources.check_mark1;
            this.button1.Location = new System.Drawing.Point(120, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.MinimumSize = new System.Drawing.Size(45, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 57);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.ExportDock5;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sldrSpeed);
            this.panel1.Controls.Add(this.pnlThumbnails);
            this.panel1.Controls.Add(this.lblTimeTip);
            this.panel1.Controls.Add(this.btnExportImage);
            this.panel1.Controls.Add(this.lblSpeedTuner);
            this.panel1.Controls.Add(this.trkFrame);
            this.panel1.Controls.Add(this.trkSelection);
            this.panel1.Controls.Add(this.btnHandlersReset);
            this.panel1.Controls.Add(this.btnSetHandlerRight);
            this.panel1.Controls.Add(this.btnExportVideoWithPauses);
            this.panel1.Controls.Add(this.btnSetHandlerLeft);
            this.panel1.Controls.Add(this.btnExportVideo);
            this.panel1.Controls.Add(this.btnExportVideoSlideshow);
            this.panel1.Controls.Add(this.btnExportImageSequence);
            this.panel1.Controls.Add(this.btn_HandlersLock);
            this.panel1.Controls.Add(this.buttonGotoFirst);
            this.panel1.Controls.Add(this.buttonGotoPrevious);
            this.panel1.Controls.Add(this.buttonGotoNext);
            this.panel1.Controls.Add(this.btnTimeOrigin);
            this.panel1.Controls.Add(this.lblTimeCode);
            this.panel1.Controls.Add(this.lblSelStartSelection);
            this.panel1.Controls.Add(this.lblSelDuration);
            this.panel1.Location = new System.Drawing.Point(1209, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 42);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(89, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // sldrSpeed
            // 
            this.sldrSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sldrSpeed.Location = new System.Drawing.Point(28, 5);
            this.sldrSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sldrSpeed.Maximum = 100D;
            this.sldrSpeed.Minimum = 0D;
            this.sldrSpeed.Name = "sldrSpeed";
            this.sldrSpeed.Size = new System.Drawing.Size(47, 35);
            this.sldrSpeed.Sticky = false;
            this.sldrSpeed.StickyValue = 0D;
            this.sldrSpeed.TabIndex = 28;
            this.sldrSpeed.Text = "sliderLinear1";
            this.sldrSpeed.Value = 1D;
            this.sldrSpeed.Visible = false;
            this.sldrSpeed.ValueChanged += new System.EventHandler(this.sldrSpeed_ValueChanged);
            // 
            // pnlThumbnails
            // 
            this.pnlThumbnails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThumbnails.AutoScroll = true;
            this.pnlThumbnails.BackColor = System.Drawing.Color.Black;
            this.pnlThumbnails.Location = new System.Drawing.Point(158, 14);
            this.pnlThumbnails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlThumbnails.Name = "pnlThumbnails";
            this.pnlThumbnails.Size = new System.Drawing.Size(0, 16);
            this.pnlThumbnails.TabIndex = 3;
            this.pnlThumbnails.Visible = false;
            this.pnlThumbnails.DoubleClick += new System.EventHandler(this.pnlThumbnails_DoubleClick);
            this.pnlThumbnails.MouseEnter += new System.EventHandler(this.pnlThumbnails_MouseEnter);
            // 
            // lblTimeTip
            // 
            this.lblTimeTip.AutoSize = true;
            this.lblTimeTip.BackColor = System.Drawing.Color.DimGray;
            this.lblTimeTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeTip.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTip.ForeColor = System.Drawing.Color.White;
            this.lblTimeTip.Location = new System.Drawing.Point(47, 22);
            this.lblTimeTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeTip.Name = "lblTimeTip";
            this.lblTimeTip.Padding = new System.Windows.Forms.Padding(3);
            this.lblTimeTip.Size = new System.Drawing.Size(96, 26);
            this.lblTimeTip.TabIndex = 30;
            this.lblTimeTip.Text = "00:00.000";
            this.lblTimeTip.Visible = false;
            // 
            // btnExportImage
            // 
            this.btnExportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportImage.BackColor = System.Drawing.Color.Transparent;
            this.btnExportImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportImage.FlatAppearance.BorderSize = 0;
            this.btnExportImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportImage.Image = global::Kinovea.ScreenManager.Properties.Resources.image;
            this.btnExportImage.Location = new System.Drawing.Point(-164, 22);
            this.btnExportImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportImage.MinimumSize = new System.Drawing.Size(38, 38);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(45, 38);
            this.btnExportImage.TabIndex = 18;
            this.btnExportImage.Tag = "";
            this.btnExportImage.UseVisualStyleBackColor = false;
            this.btnExportImage.Visible = false;
            // 
            // lblSpeedTuner
            // 
            this.lblSpeedTuner.AutoSize = true;
            this.lblSpeedTuner.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSpeedTuner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSpeedTuner.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedTuner.ForeColor = System.Drawing.Color.Black;
            this.lblSpeedTuner.Location = new System.Drawing.Point(12, 8);
            this.lblSpeedTuner.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpeedTuner.Name = "lblSpeedTuner";
            this.lblSpeedTuner.Size = new System.Drawing.Size(63, 20);
            this.lblSpeedTuner.TabIndex = 10;
            this.lblSpeedTuner.Text = "99.99%";
            this.lblSpeedTuner.Visible = false;
            this.lblSpeedTuner.DoubleClick += new System.EventHandler(this.lblSpeedTuner_DoubleClick);
            // 
            // trkFrame
            // 
            this.trkFrame.AllowDrop = true;
            this.trkFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkFrame.LeftHairline = ((long)(0));
            this.trkFrame.Location = new System.Drawing.Point(132, -51);
            this.trkFrame.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.trkFrame.Maximum = ((long)(100));
            this.trkFrame.Minimum = ((long)(0));
            this.trkFrame.MinimumSize = new System.Drawing.Size(75, 31);
            this.trkFrame.Name = "trkFrame";
            this.trkFrame.Position = ((long)(0));
            this.trkFrame.RightHairline = ((long)(0));
            this.trkFrame.ShowCacheInTimeline = false;
            this.trkFrame.Size = new System.Drawing.Size(75, 98);
            this.trkFrame.TabIndex = 16;
            this.trkFrame.Visible = false;
            this.trkFrame.PositionChanging += new System.EventHandler<Kinovea.ScreenManager.TimeEventArgs>(this.trkFrame_PositionChanging);
            this.trkFrame.PositionChanged += new System.EventHandler<Kinovea.ScreenManager.TimeEventArgs>(this.trkFrame_PositionChanged);
            // 
            // trkSelection
            // 
            this.trkSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkSelection.Location = new System.Drawing.Point(59, 2);
            this.trkSelection.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.trkSelection.Maximum = ((long)(100));
            this.trkSelection.Minimum = ((long)(0));
            this.trkSelection.Name = "trkSelection";
            this.trkSelection.SelEnd = ((long)(100));
            this.trkSelection.SelLocked = false;
            this.trkSelection.SelPos = ((long)(0));
            this.trkSelection.SelStart = ((long)(0));
            this.trkSelection.Size = new System.Drawing.Size(0, 31);
            this.trkSelection.TabIndex = 17;
            this.trkSelection.ToolTip = "";
            this.trkSelection.Visible = false;
            this.trkSelection.SelectionChanging += new System.EventHandler(this.trkSelection_SelectionChanging);
            this.trkSelection.SelectionChanged += new System.EventHandler(this.trkSelection_SelectionChanged);
            this.trkSelection.TargetAcquired += new System.EventHandler(this.trkSelection_TargetAcquired);
            // 
            // btnHandlersReset
            // 
            this.btnHandlersReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHandlersReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHandlersReset.FlatAppearance.BorderSize = 0;
            this.btnHandlersReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHandlersReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandlersReset.Image = global::Kinovea.ScreenManager.Properties.Resources.outward4;
            this.btnHandlersReset.Location = new System.Drawing.Point(177, 5);
            this.btnHandlersReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHandlersReset.Name = "btnHandlersReset";
            this.btnHandlersReset.Size = new System.Drawing.Size(30, 31);
            this.btnHandlersReset.TabIndex = 24;
            this.btnHandlersReset.UseVisualStyleBackColor = true;
            this.btnHandlersReset.Visible = false;
            this.btnHandlersReset.Click += new System.EventHandler(this.btnHandlersReset_Click);
            // 
            // btnSetHandlerRight
            // 
            this.btnSetHandlerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetHandlerRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetHandlerRight.FlatAppearance.BorderSize = 0;
            this.btnSetHandlerRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetHandlerRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHandlerRight.Image = global::Kinovea.ScreenManager.Properties.Resources.handlersetright;
            this.btnSetHandlerRight.Location = new System.Drawing.Point(147, 5);
            this.btnSetHandlerRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetHandlerRight.Name = "btnSetHandlerRight";
            this.btnSetHandlerRight.Size = new System.Drawing.Size(30, 31);
            this.btnSetHandlerRight.TabIndex = 22;
            this.btnSetHandlerRight.UseVisualStyleBackColor = true;
            this.btnSetHandlerRight.Visible = false;
            this.btnSetHandlerRight.Click += new System.EventHandler(this.btnSetHandlerRight_Click);
            // 
            // btnExportVideoWithPauses
            // 
            this.btnExportVideoWithPauses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportVideoWithPauses.BackColor = System.Drawing.Color.Transparent;
            this.btnExportVideoWithPauses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportVideoWithPauses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportVideoWithPauses.FlatAppearance.BorderSize = 0;
            this.btnExportVideoWithPauses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportVideoWithPauses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportVideoWithPauses.Image = global::Kinovea.ScreenManager.Properties.Resources.export_video_with_pauses;
            this.btnExportVideoWithPauses.Location = new System.Drawing.Point(16, 22);
            this.btnExportVideoWithPauses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportVideoWithPauses.MinimumSize = new System.Drawing.Size(38, 38);
            this.btnExportVideoWithPauses.Name = "btnExportVideoWithPauses";
            this.btnExportVideoWithPauses.Size = new System.Drawing.Size(45, 38);
            this.btnExportVideoWithPauses.TabIndex = 25;
            this.btnExportVideoWithPauses.Tag = "";
            this.btnExportVideoWithPauses.UseVisualStyleBackColor = false;
            this.btnExportVideoWithPauses.Visible = false;
            // 
            // btnSetHandlerLeft
            // 
            this.btnSetHandlerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetHandlerLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetHandlerLeft.FlatAppearance.BorderSize = 0;
            this.btnSetHandlerLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetHandlerLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHandlerLeft.Image = global::Kinovea.ScreenManager.Properties.Resources.handlersetleft;
            this.btnSetHandlerLeft.Location = new System.Drawing.Point(117, 5);
            this.btnSetHandlerLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetHandlerLeft.Name = "btnSetHandlerLeft";
            this.btnSetHandlerLeft.Size = new System.Drawing.Size(30, 31);
            this.btnSetHandlerLeft.TabIndex = 21;
            this.btnSetHandlerLeft.UseVisualStyleBackColor = true;
            this.btnSetHandlerLeft.Visible = false;
            this.btnSetHandlerLeft.Click += new System.EventHandler(this.btnSetHandlerLeft_Click);
            // 
            // btnExportVideo
            // 
            this.btnExportVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnExportVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportVideo.FlatAppearance.BorderSize = 0;
            this.btnExportVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportVideo.Image = global::Kinovea.ScreenManager.Properties.Resources.export_video_video;
            this.btnExportVideo.Location = new System.Drawing.Point(-74, 22);
            this.btnExportVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportVideo.MinimumSize = new System.Drawing.Size(38, 38);
            this.btnExportVideo.Name = "btnExportVideo";
            this.btnExportVideo.Size = new System.Drawing.Size(45, 38);
            this.btnExportVideo.TabIndex = 25;
            this.btnExportVideo.Tag = "";
            this.btnExportVideo.UseVisualStyleBackColor = false;
            this.btnExportVideo.Visible = false;
            // 
            // btnExportVideoSlideshow
            // 
            this.btnExportVideoSlideshow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportVideoSlideshow.BackColor = System.Drawing.Color.Transparent;
            this.btnExportVideoSlideshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportVideoSlideshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportVideoSlideshow.FlatAppearance.BorderSize = 0;
            this.btnExportVideoSlideshow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportVideoSlideshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportVideoSlideshow.Image = global::Kinovea.ScreenManager.Properties.Resources.export_video_slideshow;
            this.btnExportVideoSlideshow.Location = new System.Drawing.Point(-29, 22);
            this.btnExportVideoSlideshow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportVideoSlideshow.MinimumSize = new System.Drawing.Size(38, 38);
            this.btnExportVideoSlideshow.Name = "btnExportVideoSlideshow";
            this.btnExportVideoSlideshow.Size = new System.Drawing.Size(45, 38);
            this.btnExportVideoSlideshow.TabIndex = 25;
            this.btnExportVideoSlideshow.Tag = "";
            this.btnExportVideoSlideshow.UseVisualStyleBackColor = false;
            this.btnExportVideoSlideshow.Visible = false;
            // 
            // btnExportImageSequence
            // 
            this.btnExportImageSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportImageSequence.BackColor = System.Drawing.Color.Transparent;
            this.btnExportImageSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportImageSequence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportImageSequence.FlatAppearance.BorderSize = 0;
            this.btnExportImageSequence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportImageSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportImageSequence.Image = global::Kinovea.ScreenManager.Properties.Resources.images;
            this.btnExportImageSequence.Location = new System.Drawing.Point(-119, 22);
            this.btnExportImageSequence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportImageSequence.MinimumSize = new System.Drawing.Size(38, 38);
            this.btnExportImageSequence.Name = "btnExportImageSequence";
            this.btnExportImageSequence.Size = new System.Drawing.Size(45, 38);
            this.btnExportImageSequence.TabIndex = 23;
            this.btnExportImageSequence.Tag = "";
            this.btnExportImageSequence.UseVisualStyleBackColor = false;
            this.btnExportImageSequence.Visible = false;
            // 
            // btn_HandlersLock
            // 
            this.btn_HandlersLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_HandlersLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HandlersLock.FlatAppearance.BorderSize = 0;
            this.btn_HandlersLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_HandlersLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HandlersLock.Image = global::Kinovea.ScreenManager.Properties.Resources.primselec_unlocked3;
            this.btn_HandlersLock.Location = new System.Drawing.Point(87, 5);
            this.btn_HandlersLock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HandlersLock.Name = "btn_HandlersLock";
            this.btn_HandlersLock.Size = new System.Drawing.Size(30, 31);
            this.btn_HandlersLock.TabIndex = 8;
            this.btn_HandlersLock.UseVisualStyleBackColor = true;
            this.btn_HandlersLock.Visible = false;
            this.btn_HandlersLock.Click += new System.EventHandler(this.btn_HandlersLock_Click);
            // 
            // buttonGotoFirst
            // 
            this.buttonGotoFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGotoFirst.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGotoFirst.FlatAppearance.BorderSize = 0;
            this.buttonGotoFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGotoFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGotoFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGotoFirst.Image = global::Kinovea.ScreenManager.Properties.Resources.flatstart3;
            this.buttonGotoFirst.Location = new System.Drawing.Point(51, 5);
            this.buttonGotoFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGotoFirst.MinimumSize = new System.Drawing.Size(27, 28);
            this.buttonGotoFirst.Name = "buttonGotoFirst";
            this.buttonGotoFirst.Size = new System.Drawing.Size(36, 28);
            this.buttonGotoFirst.TabIndex = 4;
            this.buttonGotoFirst.UseVisualStyleBackColor = true;
            this.buttonGotoFirst.Visible = false;
            this.buttonGotoFirst.Click += new System.EventHandler(this.buttonGotoFirst_Click);
            // 
            // buttonGotoPrevious
            // 
            this.buttonGotoPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGotoPrevious.FlatAppearance.BorderSize = 0;
            this.buttonGotoPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGotoPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGotoPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGotoPrevious.Image = global::Kinovea.ScreenManager.Properties.Resources.flatprev3;
            this.buttonGotoPrevious.Location = new System.Drawing.Point(177, 5);
            this.buttonGotoPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGotoPrevious.MinimumSize = new System.Drawing.Size(27, 28);
            this.buttonGotoPrevious.Name = "buttonGotoPrevious";
            this.buttonGotoPrevious.Size = new System.Drawing.Size(36, 28);
            this.buttonGotoPrevious.TabIndex = 3;
            this.buttonGotoPrevious.UseVisualStyleBackColor = true;
            this.buttonGotoPrevious.Visible = false;
            this.buttonGotoPrevious.Click += new System.EventHandler(this.buttonGotoPrevious_Click);
            // 
            // buttonGotoNext
            // 
            this.buttonGotoNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonGotoNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGotoNext.FlatAppearance.BorderSize = 0;
            this.buttonGotoNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGotoNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGotoNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGotoNext.Image = global::Kinovea.ScreenManager.Properties.Resources.flatnext3;
            this.buttonGotoNext.Location = new System.Drawing.Point(95, 8);
            this.buttonGotoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGotoNext.MinimumSize = new System.Drawing.Size(27, 28);
            this.buttonGotoNext.Name = "buttonGotoNext";
            this.buttonGotoNext.Size = new System.Drawing.Size(36, 28);
            this.buttonGotoNext.TabIndex = 2;
            this.buttonGotoNext.UseVisualStyleBackColor = false;
            this.buttonGotoNext.Visible = false;
            this.buttonGotoNext.Click += new System.EventHandler(this.buttonGotoNext_Click);
            // 
            // btnTimeOrigin
            // 
            this.btnTimeOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimeOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeOrigin.FlatAppearance.BorderSize = 0;
            this.btnTimeOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeOrigin.Image = global::Kinovea.ScreenManager.Properties.Resources.marker_small;
            this.btnTimeOrigin.Location = new System.Drawing.Point(57, 5);
            this.btnTimeOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimeOrigin.Name = "btnTimeOrigin";
            this.btnTimeOrigin.Size = new System.Drawing.Size(30, 31);
            this.btnTimeOrigin.TabIndex = 29;
            this.btnTimeOrigin.UseVisualStyleBackColor = true;
            this.btnTimeOrigin.Visible = false;
            this.btnTimeOrigin.Click += new System.EventHandler(this.BtnTimeOrigin_Click);
            // 
            // lblTimeCode
            // 
            this.lblTimeCode.AutoSize = true;
            this.lblTimeCode.BackColor = System.Drawing.Color.White;
            this.lblTimeCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimeCode.Location = new System.Drawing.Point(114, 18);
            this.lblTimeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeCode.Name = "lblTimeCode";
            this.lblTimeCode.Size = new System.Drawing.Size(99, 20);
            this.lblTimeCode.TabIndex = 2;
            this.lblTimeCode.Text = "0:00:00:00";
            this.lblTimeCode.Visible = false;
            // 
            // lblSelStartSelection
            // 
            this.lblSelStartSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelStartSelection.AutoSize = true;
            this.lblSelStartSelection.BackColor = System.Drawing.Color.White;
            this.lblSelStartSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelStartSelection.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelStartSelection.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelStartSelection.Location = new System.Drawing.Point(-89, 16);
            this.lblSelStartSelection.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelStartSelection.Name = "lblSelStartSelection";
            this.lblSelStartSelection.Size = new System.Drawing.Size(108, 20);
            this.lblSelStartSelection.TabIndex = 3;
            this.lblSelStartSelection.Text = "0:00:00.000";
            this.lblSelStartSelection.Visible = false;
            // 
            // lblSelDuration
            // 
            this.lblSelDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelDuration.AutoSize = true;
            this.lblSelDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSelDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelDuration.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelDuration.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelDuration.Location = new System.Drawing.Point(-89, 8);
            this.lblSelDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelDuration.Name = "lblSelDuration";
            this.lblSelDuration.Size = new System.Drawing.Size(126, 20);
            this.lblSelDuration.TabIndex = 4;
            this.lblSelDuration.Text = "[0:00:00.000]";
            this.lblSelDuration.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::Kinovea.ScreenManager.Properties.Resources.flatplay;
            this.buttonPlay.Location = new System.Drawing.Point(50, 23);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlay.MinimumSize = new System.Drawing.Size(45, 38);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(60, 46);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonGotoLast
            // 
            this.buttonGotoLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGotoLast.FlatAppearance.BorderSize = 0;
            this.buttonGotoLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGotoLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGotoLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGotoLast.Image = global::Kinovea.ScreenManager.Properties.Resources.flatend3;
            this.buttonGotoLast.Location = new System.Drawing.Point(789, 122);
            this.buttonGotoLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGotoLast.MinimumSize = new System.Drawing.Size(27, 28);
            this.buttonGotoLast.Name = "buttonGotoLast";
            this.buttonGotoLast.Size = new System.Drawing.Size(27, 28);
            this.buttonGotoLast.TabIndex = 1;
            this.buttonGotoLast.UseVisualStyleBackColor = true;
            this.buttonGotoLast.Visible = false;
            this.buttonGotoLast.Click += new System.EventHandler(this.buttonGotoLast_Click);
            // 
            // groupBoxSpeedTuner
            // 
            this.groupBoxSpeedTuner.BackColor = System.Drawing.Color.White;
            this.groupBoxSpeedTuner.Controls.Add(this.markerSpeedTuner);
            this.groupBoxSpeedTuner.Controls.Add(this.PrimarySelection);
            this.groupBoxSpeedTuner.Location = new System.Drawing.Point(25, 375);
            this.groupBoxSpeedTuner.MaximumSize = new System.Drawing.Size(300, 0);
            this.groupBoxSpeedTuner.Name = "groupBoxSpeedTuner";
            this.groupBoxSpeedTuner.Size = new System.Drawing.Size(172, 0);
            this.groupBoxSpeedTuner.TabIndex = 0;
            this.groupBoxSpeedTuner.TabStop = false;
            this.groupBoxSpeedTuner.Text = "Playback Speed : 100%";
            // 
            // markerSpeedTuner
            // 
            this.markerSpeedTuner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markerSpeedTuner.FlatAppearance.BorderSize = 0;
            this.markerSpeedTuner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markerSpeedTuner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.markerSpeedTuner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markerSpeedTuner.Location = new System.Drawing.Point(110, 51);
            this.markerSpeedTuner.Name = "markerSpeedTuner";
            this.markerSpeedTuner.Size = new System.Drawing.Size(2, 3);
            this.markerSpeedTuner.TabIndex = 1;
            this.markerSpeedTuner.UseVisualStyleBackColor = false;
            // 
            // PrimarySelection
            // 
            this.PrimarySelection.BackColor = System.Drawing.Color.Maroon;
            this.PrimarySelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PrimarySelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PrimarySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrimarySelection.Location = new System.Drawing.Point(1, -7);
            this.PrimarySelection.Name = "PrimarySelection";
            this.PrimarySelection.Size = new System.Drawing.Size(150, 14);
            this.PrimarySelection.TabIndex = 0;
            this.PrimarySelection.UseVisualStyleBackColor = false;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.Black;
            this.panelCenter.Controls.Add(this.ImageResizerNE);
            this.panelCenter.Controls.Add(this.ImageResizerNW);
            this.panelCenter.Controls.Add(this.ImageResizerSW);
            this.panelCenter.Controls.Add(this.ImageResizerSE);
            this.panelCenter.Controls.Add(this.pbSurfaceScreen);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCenter.MinimumSize = new System.Drawing.Size(525, 38);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1245, 527);
            this.panelCenter.TabIndex = 2;
            this.panelCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelCenter_MouseClick);
            this.panelCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCenter_MouseDown);
            this.panelCenter.MouseEnter += new System.EventHandler(this.PanelCenter_MouseEnter);
            this.panelCenter.Resize += new System.EventHandler(this.PanelCenter_Resize);
            // 
            // ImageResizerNE
            // 
            this.ImageResizerNE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageResizerNE.BackColor = System.Drawing.Color.DimGray;
            this.ImageResizerNE.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ImageResizerNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageResizerNE.Image = global::Kinovea.ScreenManager.Properties.Resources.resizer4;
            this.ImageResizerNE.Location = new System.Drawing.Point(444, 117);
            this.ImageResizerNE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageResizerNE.Name = "ImageResizerNE";
            this.ImageResizerNE.Size = new System.Drawing.Size(9, 9);
            this.ImageResizerNE.TabIndex = 9;
            this.ImageResizerNE.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseDoubleClick);
            this.ImageResizerNE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageResizerNE_MouseMove);
            this.ImageResizerNE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseUp);
            // 
            // ImageResizerNW
            // 
            this.ImageResizerNW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageResizerNW.BackColor = System.Drawing.Color.DimGray;
            this.ImageResizerNW.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ImageResizerNW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageResizerNW.Image = global::Kinovea.ScreenManager.Properties.Resources.resizer4;
            this.ImageResizerNW.Location = new System.Drawing.Point(392, 117);
            this.ImageResizerNW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageResizerNW.Name = "ImageResizerNW";
            this.ImageResizerNW.Size = new System.Drawing.Size(9, 9);
            this.ImageResizerNW.TabIndex = 8;
            this.ImageResizerNW.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseDoubleClick);
            this.ImageResizerNW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageResizerNW_MouseMove);
            this.ImageResizerNW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseUp);
            // 
            // ImageResizerSW
            // 
            this.ImageResizerSW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageResizerSW.BackColor = System.Drawing.Color.DimGray;
            this.ImageResizerSW.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ImageResizerSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageResizerSW.Image = global::Kinovea.ScreenManager.Properties.Resources.resizer4;
            this.ImageResizerSW.Location = new System.Drawing.Point(392, 155);
            this.ImageResizerSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageResizerSW.Name = "ImageResizerSW";
            this.ImageResizerSW.Size = new System.Drawing.Size(9, 9);
            this.ImageResizerSW.TabIndex = 7;
            this.ImageResizerSW.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseDoubleClick);
            this.ImageResizerSW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageResizerSW_MouseMove);
            this.ImageResizerSW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseUp);
            // 
            // ImageResizerSE
            // 
            this.ImageResizerSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageResizerSE.BackColor = System.Drawing.Color.DimGray;
            this.ImageResizerSE.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ImageResizerSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageResizerSE.ForeColor = System.Drawing.Color.Transparent;
            this.ImageResizerSE.Image = global::Kinovea.ScreenManager.Properties.Resources.resizer4;
            this.ImageResizerSE.Location = new System.Drawing.Point(444, 155);
            this.ImageResizerSE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageResizerSE.Name = "ImageResizerSE";
            this.ImageResizerSE.Size = new System.Drawing.Size(9, 9);
            this.ImageResizerSE.TabIndex = 6;
            this.ImageResizerSE.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseDoubleClick);
            this.ImageResizerSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageResizerSE_MouseMove);
            this.ImageResizerSE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resizers_MouseUp);
            // 
            // pbSurfaceScreen
            // 
            this.pbSurfaceScreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbSurfaceScreen.Location = new System.Drawing.Point(175, 81);
            this.pbSurfaceScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSurfaceScreen.Name = "pbSurfaceScreen";
            this.pbSurfaceScreen.Size = new System.Drawing.Size(152, 112);
            this.pbSurfaceScreen.TabIndex = 2;
            this.pbSurfaceScreen.TabStop = false;
            this.pbSurfaceScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.SurfaceScreen_Paint);
            this.pbSurfaceScreen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SurfaceScreen_MouseDoubleClick);
            this.pbSurfaceScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SurfaceScreen_MouseDown);
            this.pbSurfaceScreen.MouseEnter += new System.EventHandler(this.SurfaceScreen_MouseEnter);
            this.pbSurfaceScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SurfaceScreen_MouseMove);
            this.pbSurfaceScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SurfaceScreen_MouseUp);
            this.pbSurfaceScreen.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Common_MouseWheel);
            // 
            // dbgAvailableRam
            // 
            this.dbgAvailableRam.AutoSize = true;
            this.dbgAvailableRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgAvailableRam.ForeColor = System.Drawing.Color.White;
            this.dbgAvailableRam.Location = new System.Drawing.Point(3, 148);
            this.dbgAvailableRam.Name = "dbgAvailableRam";
            this.dbgAvailableRam.Size = new System.Drawing.Size(64, 17);
            this.dbgAvailableRam.TabIndex = 24;
            this.dbgAvailableRam.Text = "iAvailableRam";
            // 
            // dbgDurationFrames
            // 
            this.dbgDurationFrames.AutoSize = true;
            this.dbgDurationFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgDurationFrames.ForeColor = System.Drawing.Color.White;
            this.dbgDurationFrames.Location = new System.Drawing.Point(3, 134);
            this.dbgDurationFrames.Name = "dbgDurationFrames";
            this.dbgDurationFrames.Size = new System.Drawing.Size(72, 17);
            this.dbgDurationFrames.TabIndex = 23;
            this.dbgDurationFrames.Text = "iDurationFrames";
            // 
            // dbgCurrentFrame
            // 
            this.dbgCurrentFrame.AutoSize = true;
            this.dbgCurrentFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgCurrentFrame.ForeColor = System.Drawing.Color.White;
            this.dbgCurrentFrame.Location = new System.Drawing.Point(3, 120);
            this.dbgCurrentFrame.Name = "dbgCurrentFrame";
            this.dbgCurrentFrame.Size = new System.Drawing.Size(64, 17);
            this.dbgCurrentFrame.TabIndex = 22;
            this.dbgCurrentFrame.Text = "iCurrentFrame";
            // 
            // dbgCurrentPositionRel
            // 
            this.dbgCurrentPositionRel.AutoSize = true;
            this.dbgCurrentPositionRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgCurrentPositionRel.ForeColor = System.Drawing.Color.White;
            this.dbgCurrentPositionRel.Location = new System.Drawing.Point(3, 106);
            this.dbgCurrentPositionRel.Name = "dbgCurrentPositionRel";
            this.dbgCurrentPositionRel.Size = new System.Drawing.Size(78, 17);
            this.dbgCurrentPositionRel.TabIndex = 18;
            this.dbgCurrentPositionRel.Text = "iCurrentPos(rel)";
            // 
            // dbgStartOffset
            // 
            this.dbgStartOffset.AutoSize = true;
            this.dbgStartOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgStartOffset.ForeColor = System.Drawing.Color.White;
            this.dbgStartOffset.Location = new System.Drawing.Point(3, 41);
            this.dbgStartOffset.Name = "dbgStartOffset";
            this.dbgStartOffset.Size = new System.Drawing.Size(50, 17);
            this.dbgStartOffset.TabIndex = 17;
            this.dbgStartOffset.Text = "iStartOffset";
            // 
            // dbgCurrentPositionAbs
            // 
            this.dbgCurrentPositionAbs.AutoSize = true;
            this.dbgCurrentPositionAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgCurrentPositionAbs.ForeColor = System.Drawing.Color.White;
            this.dbgCurrentPositionAbs.Location = new System.Drawing.Point(3, 93);
            this.dbgCurrentPositionAbs.Name = "dbgCurrentPositionAbs";
            this.dbgCurrentPositionAbs.Size = new System.Drawing.Size(82, 17);
            this.dbgCurrentPositionAbs.TabIndex = 16;
            this.dbgCurrentPositionAbs.Text = "iCurrentPos(abs)";
            // 
            // dbgDrops
            // 
            this.dbgDrops.AutoSize = true;
            this.dbgDrops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgDrops.ForeColor = System.Drawing.Color.White;
            this.dbgDrops.Location = new System.Drawing.Point(3, 13);
            this.dbgDrops.Name = "dbgDrops";
            this.dbgDrops.Size = new System.Drawing.Size(37, 17);
            this.dbgDrops.TabIndex = 7;
            this.dbgDrops.Text = "Drops ";
            // 
            // dbgSelectionDuration
            // 
            this.dbgSelectionDuration.AutoSize = true;
            this.dbgSelectionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgSelectionDuration.ForeColor = System.Drawing.Color.White;
            this.dbgSelectionDuration.Location = new System.Drawing.Point(3, 79);
            this.dbgSelectionDuration.Name = "dbgSelectionDuration";
            this.dbgSelectionDuration.Size = new System.Drawing.Size(56, 17);
            this.dbgSelectionDuration.TabIndex = 15;
            this.dbgSelectionDuration.Text = "iSelDuration";
            // 
            // dbgSelectionEnd
            // 
            this.dbgSelectionEnd.AutoSize = true;
            this.dbgSelectionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgSelectionEnd.ForeColor = System.Drawing.Color.White;
            this.dbgSelectionEnd.Location = new System.Drawing.Point(3, 66);
            this.dbgSelectionEnd.Name = "dbgSelectionEnd";
            this.dbgSelectionEnd.Size = new System.Drawing.Size(39, 17);
            this.dbgSelectionEnd.TabIndex = 14;
            this.dbgSelectionEnd.Text = "iSelEnd";
            // 
            // dbgSelectionStart
            // 
            this.dbgSelectionStart.AutoSize = true;
            this.dbgSelectionStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgSelectionStart.ForeColor = System.Drawing.Color.White;
            this.dbgSelectionStart.Location = new System.Drawing.Point(3, 54);
            this.dbgSelectionStart.Name = "dbgSelectionStart";
            this.dbgSelectionStart.Size = new System.Drawing.Size(41, 17);
            this.dbgSelectionStart.TabIndex = 13;
            this.dbgSelectionStart.Text = "iSelStart";
            // 
            // dbgFFps
            // 
            this.dbgFFps.AutoSize = true;
            this.dbgFFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgFFps.ForeColor = System.Drawing.Color.White;
            this.dbgFFps.Location = new System.Drawing.Point(3, -1);
            this.dbgFFps.Name = "dbgFFps";
            this.dbgFFps.Size = new System.Drawing.Size(24, 17);
            this.dbgFFps.TabIndex = 12;
            this.dbgFFps.Text = "fFps";
            // 
            // dbgDurationTimeStamps
            // 
            this.dbgDurationTimeStamps.AutoSize = true;
            this.dbgDurationTimeStamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgDurationTimeStamps.ForeColor = System.Drawing.Color.White;
            this.dbgDurationTimeStamps.Location = new System.Drawing.Point(3, 28);
            this.dbgDurationTimeStamps.Name = "dbgDurationTimeStamps";
            this.dbgDurationTimeStamps.Size = new System.Drawing.Size(91, 17);
            this.dbgDurationTimeStamps.TabIndex = 11;
            this.dbgDurationTimeStamps.Text = "iDurationTimeStamps";
            // 
            // splitKeyframes
            // 
            this.splitKeyframes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitKeyframes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitKeyframes.IsSplitterFixed = true;
            this.splitKeyframes.Location = new System.Drawing.Point(0, 0);
            this.splitKeyframes.Margin = new System.Windows.Forms.Padding(0);
            this.splitKeyframes.Name = "splitKeyframes";
            this.splitKeyframes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitKeyframes.Panel1
            // 
            this.splitKeyframes.Panel1.Controls.Add(this.splitViewport_Properties);
            // 
            // splitKeyframes.Panel2
            // 
            this.splitKeyframes.Panel2.BackColor = System.Drawing.Color.White;
            this.splitKeyframes.Panel2.Controls.Add(this.stripDrawingTools);
            this.splitKeyframes.Panel2.Controls.Add(this.btnDockBottom);
            this.splitKeyframes.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitKeyframes_Panel2_Paint);
            this.splitKeyframes.Panel2.DoubleClick += new System.EventHandler(this.splitKeyframes_Panel2_DoubleClick);
            this.splitKeyframes.Panel2MinSize = 30;
            this.splitKeyframes.Size = new System.Drawing.Size(1298, 828);
            this.splitKeyframes.SplitterDistance = 527;
            this.splitKeyframes.SplitterWidth = 3;
            this.splitKeyframes.TabIndex = 10;
            this.splitKeyframes.Resize += new System.EventHandler(this.splitKeyframes_Resize);
            // 
            // splitViewport_Properties
            // 
            this.splitViewport_Properties.BackColor = System.Drawing.Color.White;
            this.splitViewport_Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitViewport_Properties.Location = new System.Drawing.Point(0, 0);
            this.splitViewport_Properties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitViewport_Properties.Name = "splitViewport_Properties";
            // 
            // splitViewport_Properties.Panel1
            // 
            this.splitViewport_Properties.Panel1.Controls.Add(this.panelCenter);
            // 
            // splitViewport_Properties.Panel2
            // 
            this.splitViewport_Properties.Panel2.BackColor = System.Drawing.Color.White;
            this.splitViewport_Properties.Panel2.Controls.Add(this.tabProperties);
            this.splitViewport_Properties.Size = new System.Drawing.Size(1298, 527);
            this.splitViewport_Properties.SplitterDistance = 1245;
            this.splitViewport_Properties.SplitterWidth = 6;
            this.splitViewport_Properties.TabIndex = 3;
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.tabPage1);
            this.tabProperties.Controls.Add(this.tabPage2);
            this.tabProperties.Controls.Add(this.tabPage3);
            this.tabProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProperties.ImageList = this.imgListPropertyTabs;
            this.tabProperties.ItemSize = new System.Drawing.Size(36, 24);
            this.tabProperties.Location = new System.Drawing.Point(0, 0);
            this.tabProperties.Margin = new System.Windows.Forms.Padding(0);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.SelectedIndex = 0;
            this.tabProperties.Size = new System.Drawing.Size(47, 527);
            this.tabProperties.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabProperties.TabIndex = 0;
            this.tabProperties.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "comments2.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(39, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "colorswatch2.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(323, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "point3-16.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(323, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imgListPropertyTabs
            // 
            this.imgListPropertyTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListPropertyTabs.ImageStream")));
            this.imgListPropertyTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListPropertyTabs.Images.SetKeyName(0, "comments2.png");
            this.imgListPropertyTabs.Images.SetKeyName(1, "colorswatch2.png");
            this.imgListPropertyTabs.Images.SetKeyName(2, "tracking.png");
            this.imgListPropertyTabs.Images.SetKeyName(3, "point3-16.png");
            // 
            // stripDrawingTools
            // 
            this.stripDrawingTools.BackColor = System.Drawing.Color.Transparent;
            this.stripDrawingTools.Dock = System.Windows.Forms.DockStyle.None;
            this.stripDrawingTools.Font = new System.Drawing.Font("Arial", 7.5F);
            this.stripDrawingTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripDrawingTools.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stripDrawingTools.Location = new System.Drawing.Point(50, -2);
            this.stripDrawingTools.Name = "stripDrawingTools";
            this.stripDrawingTools.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.stripDrawingTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stripDrawingTools.Size = new System.Drawing.Size(102, 25);
            this.stripDrawingTools.Stretch = true;
            this.stripDrawingTools.TabIndex = 27;
            // 
            // btnDockBottom
            // 
            this.btnDockBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDockBottom.BackColor = System.Drawing.Color.Transparent;
            this.btnDockBottom.BackgroundImage = global::Kinovea.ScreenManager.Properties.Resources.dock16x16;
            this.btnDockBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDockBottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDockBottom.FlatAppearance.BorderSize = 0;
            this.btnDockBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDockBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDockBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDockBottom.Location = new System.Drawing.Point(1265, 6);
            this.btnDockBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDockBottom.Name = "btnDockBottom";
            this.btnDockBottom.Size = new System.Drawing.Size(30, 31);
            this.btnDockBottom.TabIndex = 16;
            this.btnDockBottom.UseVisualStyleBackColor = false;
            this.btnDockBottom.Visible = false;
            this.btnDockBottom.Click += new System.EventHandler(this.btnDockBottom_Click);
            // 
            // PlayerScreenUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panelVideoControls);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.splitKeyframes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(750, 477);
            this.Name = "PlayerScreenUserInterface";
            this.Size = new System.Drawing.Size(1298, 828);
            this.panelTop.ResumeLayout(false);
            this.panelVideoControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSpeedTuner.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceScreen)).EndInit();
            this.splitKeyframes.Panel1.ResumeLayout(false);
            this.splitKeyframes.Panel2.ResumeLayout(false);
            this.splitKeyframes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitKeyframes)).EndInit();
            this.splitKeyframes.ResumeLayout(false);
            this.splitViewport_Properties.Panel1.ResumeLayout(false);
            this.splitViewport_Properties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitViewport_Properties)).EndInit();
            this.splitViewport_Properties.ResumeLayout(false);
            this.tabProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnExportVideoWithPauses;
        private System.Windows.Forms.Button btnExportVideo;
        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelVideoControls;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonGotoLast;
        private System.Windows.Forms.Button buttonGotoFirst;
        private System.Windows.Forms.Button buttonGotoPrevious;
        private System.Windows.Forms.Button buttonGotoNext;
        public System.Windows.Forms.Label dbgDrops;
        private System.Windows.Forms.Button PrimarySelection;
        private System.Windows.Forms.Label lblSelDuration;
        private System.Windows.Forms.GroupBox groupBoxSpeedTuner;
        private System.Windows.Forms.Button markerSpeedTuner;
        private System.Windows.Forms.Label lblSelStartSelection;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label lblTimeCode;
        private System.Windows.Forms.Label dbgDurationTimeStamps;
        private System.Windows.Forms.Label dbgFFps;
        private System.Windows.Forms.Label dbgCurrentPositionAbs;
        private System.Windows.Forms.Label dbgSelectionDuration;
        private System.Windows.Forms.Label dbgSelectionEnd;
        private System.Windows.Forms.Label dbgSelectionStart;
        private System.Windows.Forms.Label dbgStartOffset;
        private System.Windows.Forms.Label dbgCurrentPositionRel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_HandlersLock;
        private System.Windows.Forms.Label lblSpeedTuner;
        private FrameTracker trkFrame;
        private SelectionTracker trkSelection;
        private System.Windows.Forms.Button btnExportImage;
        private System.Windows.Forms.Label ImageResizerSE;
        private System.Windows.Forms.Label ImageResizerSW;
        private System.Windows.Forms.Label ImageResizerNE;
        private System.Windows.Forms.Label ImageResizerNW;
        private System.Windows.Forms.Label dbgDurationFrames;
        private System.Windows.Forms.Label dbgCurrentFrame;
        public System.Windows.Forms.PictureBox pbSurfaceScreen;
        private System.Windows.Forms.Button btnSetHandlerRight;
        private System.Windows.Forms.Button btnSetHandlerLeft;
        private System.Windows.Forms.Label dbgAvailableRam;
        private System.Windows.Forms.SplitContainer splitKeyframes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlThumbnails;
        private System.Windows.Forms.Button btnDockBottom;
        private System.Windows.Forms.Button btnExportImageSequence;
        private System.Windows.Forms.Button btnHandlersReset;
        private System.Windows.Forms.Button btnExportVideoSlideshow;
        private System.Windows.Forms.ToolStrip stripDrawingTools;
        private SliderLinear sldrSpeed;
        private System.Windows.Forms.Button btnTimeOrigin;
        private System.Windows.Forms.Label lblTimeTip;
        private System.Windows.Forms.SplitContainer splitViewport_Properties;
        private System.Windows.Forms.TabControl tabProperties;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imgListPropertyTabs;
        private System.Windows.Forms.Button btnExitFilter;
        private System.Windows.Forms.Button btnSidePanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecord;
    }
}
