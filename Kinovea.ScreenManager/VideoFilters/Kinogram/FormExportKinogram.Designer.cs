﻿
namespace Kinovea.ScreenManager
{
    partial class FormExportKinogram
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.nudHeight = new System.Windows.Forms.NumericUpDown();
      this.nudWidth = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblImageSize = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // nudHeight
      // 
      this.nudHeight.Location = new System.Drawing.Point(198, 26);
      this.nudHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.nudHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.nudHeight.Name = "nudHeight";
      this.nudHeight.Size = new System.Drawing.Size(45, 20);
      this.nudHeight.TabIndex = 64;
      this.nudHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
      // 
      // nudWidth
      // 
      this.nudWidth.Location = new System.Drawing.Point(133, 25);
      this.nudWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.nudWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.nudWidth.Name = "nudWidth";
      this.nudWidth.Size = new System.Drawing.Size(45, 20);
      this.nudWidth.TabIndex = 63;
      this.nudWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(249, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 62;
      this.label1.Text = "px";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(184, 28);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(13, 13);
      this.label4.TabIndex = 61;
      this.label4.Text = "×";
      // 
      // lblImageSize
      // 
      this.lblImageSize.AutoSize = true;
      this.lblImageSize.Location = new System.Drawing.Point(21, 28);
      this.lblImageSize.Name = "lblImageSize";
      this.lblImageSize.Size = new System.Drawing.Size(63, 13);
      this.lblImageSize.TabIndex = 60;
      this.lblImageSize.Text = "Image size :";
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(120, 133);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(99, 24);
      this.btnOK.TabIndex = 65;
      this.btnOK.Text = "Save";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(225, 133);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(99, 24);
      this.btnCancel.TabIndex = 66;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.lblImageSize);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.nudHeight);
      this.groupBox1.Controls.Add(this.nudWidth);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(312, 71);
      this.groupBox1.TabIndex = 67;
      this.groupBox1.TabStop = false;
      // 
      // FormExportKinogram
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(336, 169);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnCancel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormExportKinogram";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FormExportKinogram";
      ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}