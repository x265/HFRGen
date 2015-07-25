using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hfrgen
{
	public partial class frmMain : Form
	{
		public string _file;
		public string _fileavs;
		UTF8Encoding UTF8 = new UTF8Encoding(false); // drop BOM
		StringComparison IC = StringComparison.OrdinalIgnoreCase;

		public frmMain(string file, string lang)
		{
			InitializeComponent();
			this.Icon = Properties.Resources.lightning_go;

			_file = file;
			_fileavs = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file)) + ".avs";
		}

		private void HighFrameRate_Load(object sender, EventArgs e)
		{
			if (String.Equals(Path.GetExtension(_file), ".avs", IC))
			{
				MessageBox.Show("Please select non AviSynth script.");
				this.Close();
				return;
			}

			cboPreset.SelectedIndex = 0;
			cboTuning.SelectedIndex = 0;
			cboInputType.SelectedIndex = 0;
		}

		private void cboPreset_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = cboPreset.SelectedIndex;
			switch (i)
			{
				case 0:
					lblPresetInfo.Text = "Very good quality (Recommended).";
					break;
				case 1:
					lblPresetInfo.Text = "Faster than Medium but slightly lower quality.";
					break;
				case 2:
					lblPresetInfo.Text = "Faster than Fast but lower quality.";
					break;
				default:
					break;
			}
		}

		private void cboTuning_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = cboTuning.SelectedIndex;
			switch (i)
			{
				case 0:
					lblTuningInfo.Text = "This offers a good balance between the accuracy of individual moving things and the cohesiveness of the frame. Useful for content that was filmed or rendered (Recommended).";
					break;
				case 1:
					lblTuningInfo.Text = "This should be used for cartoons/anime.";
					break;
				case 2:
					lblTuningInfo.Text = "This increases the accuracy of individual moving things while decreasing the cohesiveness of the frame. Some people prefer it since it gives the motion an overall \"smooth\" feeling.";
					break;
				case 3:
					lblTuningInfo.Text = "This decreases the accuracy of individual moving things while increasing the cohesiveness of the frame.\nNote: This will weaken the interpolation a lot, meaning the motion isn't as smooth.";
					break;
				default:
					break;
			}
			lblTuningInfo.Text += "\n\nSome people will prefer to use the Film tuning even for animated content, so don't automatically assume this is the right tuning for you; use with caution.";
		}

		private void cboInputType_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = cboInputType.SelectedIndex;
			switch (i)
			{
				case 0:
					lblInputTypeInfo.Text = "This is for regular videos.";
					break;
				case 1:
					lblInputTypeInfo.Text = "This is for 3D Side-By-Side content, usually the resolution will be 3840x1080 (1920x1080 for each eye).";
					break;
				case 2:
					lblInputTypeInfo.Text = "This is for 3D Over-Under content (AKA Top-to-Bottom), usually the resolution will be 1920x2160 (1920x1080 for each eye).";
					break;
				case 3:
					lblInputTypeInfo.Text = "This is for 3D Side-By-Side content at half the resolution, usually the resolution will be 1920x1080 (960x1080 for each eye).";
					break;
				case 4:
					lblInputTypeInfo.Text = "This is for 3D Over-Under content (AKA Top-to-Bottom), usually the resolution will be 1920x1080 (1920x540 for each eye).";
					break;
				default:
					break;
			}
			lblInputTypeInfo.Text += "\n\nNote: This setting does not create 3D from 2D, it just properly interpolates content that is already 3D. The 3D options approximately halve the speed - because they calculate each half separately - so if you are OK with less 3D accuracy you can use the 2D (default) mode for faster performance.";
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			Form frm = new frmSetting();
			frm.ShowDialog();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(Properties.Settings.Default.DirPluginHfr))
			{
				MessageBox.Show("Missing InterFrame AviSynth Autoload Script and Plugins, please settings first before save.");
				return;
			}

			string[] Data = { String.Format("{0}", Environment.ProcessorCount),
							Properties.Settings.Default.DirPluginHfr,
							_file,
							cboPreset.Text,
							cboTuning.Text,
							chkDoubleFps.Checked ? "true" : "false",
							chkUseGPU.Checked ? "true" : "false",
							cboInputType.Text,
							chkFullFrame.Checked ? ", NewNum=60, NewDen=1" : ""};

			File.WriteAllText(_fileavs, String.Format(Properties.Resources.ScriptHFR, Data), UTF8);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
