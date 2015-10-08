namespace hfrgen
{
	partial class frmMain
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
			this.cboTuning = new System.Windows.Forms.ComboBox();
			this.lblTuning = new System.Windows.Forms.Label();
			this.cboPreset = new System.Windows.Forms.ComboBox();
			this.lblPreset = new System.Windows.Forms.Label();
			this.chkUseGPU = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.chkDoubleFps = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkFullFrame = new System.Windows.Forms.CheckBox();
			this.lblTuningInfo = new System.Windows.Forms.Label();
			this.lblPresetInfo = new System.Windows.Forms.Label();
			this.lblInputTypeInfo = new System.Windows.Forms.Label();
			this.lblInputType = new System.Windows.Forms.Label();
			this.cboInputType = new System.Windows.Forms.ComboBox();
			this.btnSetting = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboTuning
			// 
			this.cboTuning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTuning.FormattingEnabled = true;
			this.cboTuning.Items.AddRange(new object[] {
            "Film",
            "Animation",
            "Smooth",
            "Weak"});
			this.cboTuning.Location = new System.Drawing.Point(82, 119);
			this.cboTuning.Name = "cboTuning";
			this.cboTuning.Size = new System.Drawing.Size(121, 21);
			this.cboTuning.TabIndex = 28;
			this.cboTuning.SelectedIndexChanged += new System.EventHandler(this.cboTuning_SelectedIndexChanged);
			// 
			// lblTuning
			// 
			this.lblTuning.AutoSize = true;
			this.lblTuning.Location = new System.Drawing.Point(12, 122);
			this.lblTuning.Name = "lblTuning";
			this.lblTuning.Size = new System.Drawing.Size(43, 13);
			this.lblTuning.TabIndex = 29;
			this.lblTuning.Text = "Tuning:";
			// 
			// cboPreset
			// 
			this.cboPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPreset.FormattingEnabled = true;
			this.cboPreset.Items.AddRange(new object[] {
            "Medium",
            "Fast",
            "Faster"});
			this.cboPreset.Location = new System.Drawing.Point(82, 12);
			this.cboPreset.Name = "cboPreset";
			this.cboPreset.Size = new System.Drawing.Size(121, 21);
			this.cboPreset.TabIndex = 25;
			this.cboPreset.SelectedIndexChanged += new System.EventHandler(this.cboPreset_SelectedIndexChanged);
			// 
			// lblPreset
			// 
			this.lblPreset.AutoSize = true;
			this.lblPreset.Location = new System.Drawing.Point(12, 15);
			this.lblPreset.Name = "lblPreset";
			this.lblPreset.Size = new System.Drawing.Size(42, 13);
			this.lblPreset.TabIndex = 26;
			this.lblPreset.Text = "Preset:";
			// 
			// chkUseGPU
			// 
			this.chkUseGPU.AutoSize = true;
			this.chkUseGPU.Location = new System.Drawing.Point(27, 30);
			this.chkUseGPU.Name = "chkUseGPU";
			this.chkUseGPU.Size = new System.Drawing.Size(128, 17);
			this.chkUseGPU.TabIndex = 3;
			this.chkUseGPU.Text = "Use &GPU acceleration";
			this.chkUseGPU.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(553, 445);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 32;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(472, 445);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 31;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// chkDoubleFps
			// 
			this.chkDoubleFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkDoubleFps.AutoSize = true;
			this.chkDoubleFps.Location = new System.Drawing.Point(270, 30);
			this.chkDoubleFps.Name = "chkDoubleFps";
			this.chkDoubleFps.Size = new System.Drawing.Size(197, 17);
			this.chkDoubleFps.TabIndex = 4;
			this.chkDoubleFps.Text = "&Double fps instead (eg: 23.976 x 2)";
			this.chkDoubleFps.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.chkFullFrame);
			this.groupBox1.Controls.Add(this.chkUseGPU);
			this.groupBox1.Controls.Add(this.chkDoubleFps);
			this.groupBox1.Location = new System.Drawing.Point(12, 349);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(616, 90);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Feature";
			// 
			// chkFullFrame
			// 
			this.chkFullFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkFullFrame.AutoSize = true;
			this.chkFullFrame.Location = new System.Drawing.Point(270, 53);
			this.chkFullFrame.Name = "chkFullFrame";
			this.chkFullFrame.Size = new System.Drawing.Size(266, 17);
			this.chkFullFrame.TabIndex = 5;
			this.chkFullFrame.Text = "Do &60fps instead of 59.94fps (double fps ignored)";
			this.chkFullFrame.UseVisualStyleBackColor = true;
			// 
			// lblTuningInfo
			// 
			this.lblTuningInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTuningInfo.Location = new System.Drawing.Point(12, 143);
			this.lblTuningInfo.Name = "lblTuningInfo";
			this.lblTuningInfo.Size = new System.Drawing.Size(616, 80);
			this.lblTuningInfo.TabIndex = 30;
			this.lblTuningInfo.Text = "Info";
			// 
			// lblPresetInfo
			// 
			this.lblPresetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPresetInfo.Location = new System.Drawing.Point(12, 36);
			this.lblPresetInfo.Name = "lblPresetInfo";
			this.lblPresetInfo.Size = new System.Drawing.Size(616, 80);
			this.lblPresetInfo.TabIndex = 27;
			this.lblPresetInfo.Text = "Info";
			// 
			// lblInputTypeInfo
			// 
			this.lblInputTypeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInputTypeInfo.Location = new System.Drawing.Point(12, 250);
			this.lblInputTypeInfo.Name = "lblInputTypeInfo";
			this.lblInputTypeInfo.Size = new System.Drawing.Size(616, 80);
			this.lblInputTypeInfo.TabIndex = 22;
			this.lblInputTypeInfo.Text = "Info";
			// 
			// lblInputType
			// 
			this.lblInputType.AutoSize = true;
			this.lblInputType.Location = new System.Drawing.Point(12, 229);
			this.lblInputType.Name = "lblInputType";
			this.lblInputType.Size = new System.Drawing.Size(64, 13);
			this.lblInputType.TabIndex = 23;
			this.lblInputType.Text = "Input Type:";
			// 
			// cboInputType
			// 
			this.cboInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboInputType.FormattingEnabled = true;
			this.cboInputType.Items.AddRange(new object[] {
            "2D",
            "SBS",
            "OU",
            "HSBS",
            "HOU"});
			this.cboInputType.Location = new System.Drawing.Point(82, 226);
			this.cboInputType.Name = "cboInputType";
			this.cboInputType.Size = new System.Drawing.Size(121, 21);
			this.cboInputType.TabIndex = 24;
			this.cboInputType.SelectedIndexChanged += new System.EventHandler(this.cboInputType_SelectedIndexChanged);
			// 
			// btnSetting
			// 
			this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSetting.Location = new System.Drawing.Point(12, 445);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(75, 23);
			this.btnSetting.TabIndex = 34;
			this.btnSetting.Text = "&Setting";
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.btnSetting);
			this.Controls.Add(this.cboTuning);
			this.Controls.Add(this.lblTuning);
			this.Controls.Add(this.cboPreset);
			this.Controls.Add(this.lblPreset);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTuningInfo);
			this.Controls.Add(this.lblPresetInfo);
			this.Controls.Add(this.lblInputTypeInfo);
			this.Controls.Add(this.lblInputType);
			this.Controls.Add(this.cboInputType);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(656, 518);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(656, 518);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "High Frame Rate (InterFrame)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.HighFrameRate_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboTuning;
		private System.Windows.Forms.Label lblTuning;
		private System.Windows.Forms.ComboBox cboPreset;
		private System.Windows.Forms.Label lblPreset;
		private System.Windows.Forms.CheckBox chkUseGPU;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox chkDoubleFps;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblTuningInfo;
		private System.Windows.Forms.Label lblPresetInfo;
		private System.Windows.Forms.Label lblInputTypeInfo;
		private System.Windows.Forms.Label lblInputType;
		private System.Windows.Forms.ComboBox cboInputType;
		private System.Windows.Forms.CheckBox chkFullFrame;
		private System.Windows.Forms.Button btnSetting;
	}
}