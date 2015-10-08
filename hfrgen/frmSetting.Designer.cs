namespace hfrgen
{
	partial class frmSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lblInfo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPath2 = new System.Windows.Forms.TextBox();
			this.btnBrowse2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPath3 = new System.Windows.Forms.TextBox();
			this.btnBrowse3 = new System.Windows.Forms.Button();
			this.chkUsePluginFolder = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Image = global::hfrgen.Properties.Resources.drive_magnify;
			this.btnBrowse.Location = new System.Drawing.Point(492, 25);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(24, 24);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(441, 205);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtPath.Location = new System.Drawing.Point(12, 25);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(474, 24);
			this.txtPath.TabIndex = 2;
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInfo.Location = new System.Drawing.Point(12, 136);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(504, 66);
			this.lblInfo.TabIndex = 3;
			this.lblInfo.Text = resources.GetString("lblInfo.Text");
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Path for InterFrame2.avsi:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Path for svpflow1.dll:";
			// 
			// txtPath2
			// 
			this.txtPath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPath2.Location = new System.Drawing.Point(12, 68);
			this.txtPath2.Name = "txtPath2";
			this.txtPath2.ReadOnly = true;
			this.txtPath2.Size = new System.Drawing.Size(474, 23);
			this.txtPath2.TabIndex = 6;
			// 
			// btnBrowse2
			// 
			this.btnBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse2.Image = global::hfrgen.Properties.Resources.drive_magnify;
			this.btnBrowse2.Location = new System.Drawing.Point(492, 68);
			this.btnBrowse2.Name = "btnBrowse2";
			this.btnBrowse2.Size = new System.Drawing.Size(24, 23);
			this.btnBrowse2.TabIndex = 7;
			this.btnBrowse2.UseVisualStyleBackColor = true;
			this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Path for svpflow2.dll:";
			// 
			// txtPath3
			// 
			this.txtPath3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPath3.Location = new System.Drawing.Point(12, 110);
			this.txtPath3.Name = "txtPath3";
			this.txtPath3.ReadOnly = true;
			this.txtPath3.Size = new System.Drawing.Size(474, 23);
			this.txtPath3.TabIndex = 9;
			// 
			// btnBrowse3
			// 
			this.btnBrowse3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse3.Image = global::hfrgen.Properties.Resources.drive_magnify;
			this.btnBrowse3.Location = new System.Drawing.Point(492, 110);
			this.btnBrowse3.Name = "btnBrowse3";
			this.btnBrowse3.Size = new System.Drawing.Size(23, 23);
			this.btnBrowse3.TabIndex = 10;
			this.btnBrowse3.UseVisualStyleBackColor = true;
			this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
			// 
			// chkUsePluginFolder
			// 
			this.chkUsePluginFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkUsePluginFolder.AutoSize = true;
			this.chkUsePluginFolder.Location = new System.Drawing.Point(12, 209);
			this.chkUsePluginFolder.Name = "chkUsePluginFolder";
			this.chkUsePluginFolder.Size = new System.Drawing.Size(414, 17);
			this.chkUsePluginFolder.TabIndex = 11;
			this.chkUsePluginFolder.Text = "&These files has been installed on AviSynth plugin folder, thus no need to browse" +
    ".";
			this.chkUsePluginFolder.UseVisualStyleBackColor = true;
			this.chkUsePluginFolder.CheckedChanged += new System.EventHandler(this.chkUsePluginFolder_CheckedChanged);
			// 
			// frmSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(528, 240);
			this.Controls.Add(this.chkUsePluginFolder);
			this.Controls.Add(this.btnBrowse3);
			this.Controls.Add(this.txtPath3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnBrowse2);
			this.Controls.Add(this.txtPath2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnBrowse);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.Name = "frmSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "InterFrame plugin";
			this.Load += new System.EventHandler(this.frmSetting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPath2;
		private System.Windows.Forms.Button btnBrowse2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPath3;
		private System.Windows.Forms.Button btnBrowse3;
		private System.Windows.Forms.CheckBox chkUsePluginFolder;
	}
}