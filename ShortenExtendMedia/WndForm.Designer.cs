﻿namespace ShortenExtendMedia
{
	partial class WndForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndForm));
            this.gbxShorten = new System.Windows.Forms.GroupBox();
            this.cbShortenTimecode = new System.Windows.Forms.ComboBox();
            this.lblShortenLength = new System.Windows.Forms.Label();
            this.nudShorten = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbxExtend = new System.Windows.Forms.GroupBox();
            this.cbExtendTimecode = new System.Windows.Forms.ComboBox();
            this.lblExtendLength = new System.Windows.Forms.Label();
            this.nudExtend = new System.Windows.Forms.NumericUpDown();
            this.lblShortenExtendMediaAbout = new System.Windows.Forms.LinkLabel();
            this.gbxShorten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShorten)).BeginInit();
            this.gbxExtend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtend)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxShorten
            // 
            this.gbxShorten.Controls.Add(this.cbShortenTimecode);
            this.gbxShorten.Controls.Add(this.lblShortenLength);
            this.gbxShorten.Controls.Add(this.nudShorten);
            this.gbxShorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShorten.Location = new System.Drawing.Point(10, 29);
            this.gbxShorten.Name = "gbxShorten";
            this.gbxShorten.Size = new System.Drawing.Size(276, 50);
            this.gbxShorten.TabIndex = 10;
            this.gbxShorten.TabStop = false;
            this.gbxShorten.Text = "Shorten";
            // 
            // cbShortenTimecode
            // 
            this.cbShortenTimecode.FormattingEnabled = true;
            this.cbShortenTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbShortenTimecode.Location = new System.Drawing.Point(161, 17);
            this.cbShortenTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbShortenTimecode.Name = "cbShortenTimecode";
            this.cbShortenTimecode.Size = new System.Drawing.Size(104, 21);
            this.cbShortenTimecode.TabIndex = 1;
            this.cbShortenTimecode.Text = "Frames";
            // 
            // lblShortenLength
            // 
            this.lblShortenLength.AutoSize = true;
            this.lblShortenLength.Location = new System.Drawing.Point(6, 20);
            this.lblShortenLength.Name = "lblShortenLength";
            this.lblShortenLength.Size = new System.Drawing.Size(43, 13);
            this.lblShortenLength.TabIndex = 0;
            this.lblShortenLength.Text = "Length:";
            // 
            // nudShorten
            // 
            this.nudShorten.Location = new System.Drawing.Point(68, 18);
            this.nudShorten.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.nudShorten.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudShorten.Name = "nudShorten";
            this.nudShorten.Size = new System.Drawing.Size(81, 20);
            this.nudShorten.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(10, 141);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(198, 30);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(214, 141);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(72, 30);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // gbxExtend
            // 
            this.gbxExtend.Controls.Add(this.cbExtendTimecode);
            this.gbxExtend.Controls.Add(this.lblExtendLength);
            this.gbxExtend.Controls.Add(this.nudExtend);
            this.gbxExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExtend.Location = new System.Drawing.Point(10, 85);
            this.gbxExtend.Name = "gbxExtend";
            this.gbxExtend.Size = new System.Drawing.Size(276, 50);
            this.gbxExtend.TabIndex = 12;
            this.gbxExtend.TabStop = false;
            this.gbxExtend.Text = "Extend";
            // 
            // cbExtendTimecode
            // 
            this.cbExtendTimecode.FormattingEnabled = true;
            this.cbExtendTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbExtendTimecode.Location = new System.Drawing.Point(161, 17);
            this.cbExtendTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbExtendTimecode.Name = "cbExtendTimecode";
            this.cbExtendTimecode.Size = new System.Drawing.Size(104, 21);
            this.cbExtendTimecode.TabIndex = 3;
            this.cbExtendTimecode.Text = "Frames";
            // 
            // lblExtendLength
            // 
            this.lblExtendLength.AutoSize = true;
            this.lblExtendLength.Location = new System.Drawing.Point(6, 20);
            this.lblExtendLength.Name = "lblExtendLength";
            this.lblExtendLength.Size = new System.Drawing.Size(43, 13);
            this.lblExtendLength.TabIndex = 0;
            this.lblExtendLength.Text = "Length:";
            // 
            // nudExtend
            // 
            this.nudExtend.Location = new System.Drawing.Point(68, 18);
            this.nudExtend.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.nudExtend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExtend.Name = "nudExtend";
            this.nudExtend.Size = new System.Drawing.Size(81, 20);
            this.nudExtend.TabIndex = 2;
            // 
            // lblShortenExtendMediaAbout
            // 
            this.lblShortenExtendMediaAbout.AutoSize = true;
            this.lblShortenExtendMediaAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblShortenExtendMediaAbout.Location = new System.Drawing.Point(10, 10);
            this.lblShortenExtendMediaAbout.Name = "lblShortenExtendMediaAbout";
            this.lblShortenExtendMediaAbout.Size = new System.Drawing.Size(156, 13);
            this.lblShortenExtendMediaAbout.TabIndex = 13;
            this.lblShortenExtendMediaAbout.TabStop = true;
            this.lblShortenExtendMediaAbout.Text = "Created by RatinA0 (github link)";
            this.lblShortenExtendMediaAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShortenExtendMediaAbout_LinkClicked);
            // 
            // WndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 181);
            this.Controls.Add(this.gbxShorten);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbxExtend);
            this.Controls.Add(this.lblShortenExtendMediaAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WndForm";
            this.Text = "Shorten/Extend media";
            this.gbxShorten.ResumeLayout(false);
            this.gbxShorten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShorten)).EndInit();
            this.gbxExtend.ResumeLayout(false);
            this.gbxExtend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.GroupBox gbxShorten;
        private System.Windows.Forms.ComboBox cbShortenTimecode;
        private System.Windows.Forms.Label lblShortenLength;
        private System.Windows.Forms.NumericUpDown nudShorten;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbxExtend;
        private System.Windows.Forms.ComboBox cbExtendTimecode;
        private System.Windows.Forms.Label lblExtendLength;
        private System.Windows.Forms.NumericUpDown nudExtend;
        private System.Windows.Forms.LinkLabel lblShortenExtendMediaAbout;
    }
}

