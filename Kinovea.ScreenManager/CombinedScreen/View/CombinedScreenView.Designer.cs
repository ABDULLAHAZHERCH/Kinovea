namespace Kinovea.ScreenManager
{
    partial class CombinedScreenView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControls = new System.Windows.Forms.Panel();
            this.autoPlay = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlControls.Controls.Add(this.autoPlay);
            this.pnlControls.Controls.Add(this.buttonPlay);
            this.pnlControls.Controls.Add(this.btnRecord);
            this.pnlControls.Location = new System.Drawing.Point(0, 600);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlControls.MinimumSize = new System.Drawing.Size(262, 50);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1298, 50);
            this.pnlControls.TabIndex = 4;
            // 
            // autoPlay
            // 
            this.autoPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoPlay.FlatAppearance.BorderSize = 0;
            this.autoPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.autoPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.autoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoPlay.Image = global::Kinovea.ScreenManager.Properties.Resources.check_mark1;
            this.autoPlay.Location = new System.Drawing.Point(639, -9);
            this.autoPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoPlay.MinimumSize = new System.Drawing.Size(45, 38);
            this.autoPlay.Name = "autoPlay";
            this.autoPlay.Size = new System.Drawing.Size(55, 65);
            this.autoPlay.TabIndex = 50;
            this.autoPlay.UseVisualStyleBackColor = true;
            this.autoPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::Kinovea.ScreenManager.Properties.Resources.flatplay;
            this.buttonPlay.Location = new System.Drawing.Point(590, -3);
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
            this.btnRecord.Location = new System.Drawing.Point(538, -3);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecord.MinimumSize = new System.Drawing.Size(30, 38);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(55, 50);
            this.btnRecord.TabIndex = 24;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.Black;
            this.panelCenter.Controls.Add(this.pnlControls);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCenter.MinimumSize = new System.Drawing.Size(525, 38);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1300, 650);
            this.panelCenter.TabIndex = 5;
            // 
            // CombinedScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Name = "CombinedScreenView";
            this.Size = new System.Drawing.Size(1300, 650);
            this.pnlControls.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button autoPlay;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button btnRecord;
        public System.Windows.Forms.Panel panelCenter;
    }
}
