namespace ShortenExtendMedia
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
            this.gbxShorten = new System.Windows.Forms.GroupBox();
            this.cbShortenTimecode = new System.Windows.Forms.ComboBox();
            this.lblShortenLength = new System.Windows.Forms.Label();
            this.nudShorten = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.gbxExtend = new System.Windows.Forms.GroupBox();
            this.cbExtendTimecode = new System.Windows.Forms.ComboBox();
            this.lblExtendLength = new System.Windows.Forms.Label();
            this.nudExtend = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiCreatedByRatinFX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxShorten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShorten)).BeginInit();
            this.gbxExtend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtend)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxShorten
            // 
            this.gbxShorten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbxShorten.Controls.Add(this.cbShortenTimecode);
            this.gbxShorten.Controls.Add(this.lblShortenLength);
            this.gbxShorten.Controls.Add(this.nudShorten);
            this.gbxShorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShorten.ForeColor = System.Drawing.Color.White;
            this.gbxShorten.Location = new System.Drawing.Point(12, 34);
            this.gbxShorten.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.gbxShorten.Name = "gbxShorten";
            this.gbxShorten.Size = new System.Drawing.Size(274, 50);
            this.gbxShorten.TabIndex = 10;
            this.gbxShorten.TabStop = false;
            this.gbxShorten.Text = "Shorten";
            // 
            // cbShortenTimecode
            // 
            this.cbShortenTimecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbShortenTimecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShortenTimecode.ForeColor = System.Drawing.Color.White;
            this.cbShortenTimecode.FormattingEnabled = true;
            this.cbShortenTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbShortenTimecode.Location = new System.Drawing.Point(161, 17);
            this.cbShortenTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbShortenTimecode.Name = "cbShortenTimecode";
            this.cbShortenTimecode.Size = new System.Drawing.Size(102, 21);
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
            this.nudShorten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nudShorten.ForeColor = System.Drawing.Color.White;
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
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(137)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(12, 150);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(274, 28);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gbxExtend
            // 
            this.gbxExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbxExtend.Controls.Add(this.cbExtendTimecode);
            this.gbxExtend.Controls.Add(this.lblExtendLength);
            this.gbxExtend.Controls.Add(this.nudExtend);
            this.gbxExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExtend.ForeColor = System.Drawing.Color.White;
            this.gbxExtend.Location = new System.Drawing.Point(12, 92);
            this.gbxExtend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.gbxExtend.Name = "gbxExtend";
            this.gbxExtend.Size = new System.Drawing.Size(274, 50);
            this.gbxExtend.TabIndex = 12;
            this.gbxExtend.TabStop = false;
            this.gbxExtend.Text = "Extend";
            // 
            // cbExtendTimecode
            // 
            this.cbExtendTimecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbExtendTimecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExtendTimecode.ForeColor = System.Drawing.Color.White;
            this.cbExtendTimecode.FormattingEnabled = true;
            this.cbExtendTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbExtendTimecode.Location = new System.Drawing.Point(161, 17);
            this.cbExtendTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbExtendTimecode.Name = "cbExtendTimecode";
            this.cbExtendTimecode.Size = new System.Drawing.Size(102, 21);
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
            this.nudExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nudExtend.ForeColor = System.Drawing.Color.White;
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
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreatedByRatinFX,
            this.tsmiAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(298, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmiCreatedByRatinFX
            // 
            this.tsmiCreatedByRatinFX.ForeColor = System.Drawing.Color.White;
            this.tsmiCreatedByRatinFX.Name = "tsmiCreatedByRatinFX";
            this.tsmiCreatedByRatinFX.Size = new System.Drawing.Size(119, 20);
            this.tsmiCreatedByRatinFX.Text = "Created by RatinFX";
            this.tsmiCreatedByRatinFX.Click += new System.EventHandler(this.tsmiCreatedByRatinFX_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.ForeColor = System.Drawing.Color.White;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // WndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(298, 190);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gbxShorten);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbxExtend);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WndForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shorten/Extend media";
            this.gbxShorten.ResumeLayout(false);
            this.gbxShorten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShorten)).EndInit();
            this.gbxExtend.ResumeLayout(false);
            this.gbxExtend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtend)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.GroupBox gbxShorten;
        private System.Windows.Forms.ComboBox cbShortenTimecode;
        private System.Windows.Forms.Label lblShortenLength;
        private System.Windows.Forms.NumericUpDown nudShorten;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox gbxExtend;
        private System.Windows.Forms.ComboBox cbExtendTimecode;
        private System.Windows.Forms.Label lblExtendLength;
        private System.Windows.Forms.NumericUpDown nudExtend;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatedByRatinFX;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

