using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hfrgen
{
	public partial class frmMain : Form
	{
		UTF8Encoding UTF8 = new UTF8Encoding(false); // drop BOM
		StringComparison IC = StringComparison.OrdinalIgnoreCase; // ignore case!

		string _file; // not API
		public string _fileavs; // API (allow host read this value)

		public frmMain(string file, string lang) // API, a value received from host
		{
			InitializeComponent();
			Icon = Properties.Resources.lightning_go;

			_file = file;
			_fileavs = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file)) + ".avs";
		}

		private void HighFrameRate_Load(object sender, EventArgs e)
		{
			if (string.Equals(Path.GetExtension(_file), ".avs", IC))
			{
				MessageBox.Show("Please select non AviSynth script.");
				Close();
				return;
			}

			SettingCheck();

			cboPreset.SelectedIndex = 0;
			cboTuning.SelectedIndex = 0;
			cboInputType.SelectedIndex = 0;
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Properties.Settings.Default.UseFolderPlugin)
			{
				SettingCheck();
			}
		}

		void SettingCheck()
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.FilePluginAvsi))
				Setting("InterFrame2.avsi");
			else if (!File.Exists(Properties.Settings.Default.FilePluginAvsi))
				Setting("InterFrame2.avsi");

			if (string.IsNullOrEmpty(Properties.Settings.Default.FilePluginDll1))
				Setting("svpflow1.dll");
			else if (!File.Exists(Properties.Settings.Default.FilePluginDll1))
				Setting("svpflow1.dll");

			if (string.IsNullOrEmpty(Properties.Settings.Default.FilePluginDll2))
				Setting("svpflow2.dll");
			else if (!File.Exists(Properties.Settings.Default.FilePluginDll2))
				Setting("svpflow2.dll");
		}

		void Setting(string file)
		{
			if (Properties.Settings.Default.UseFolderPlugin)
				return;

			MessageBox.Show($"\"{file}\" not found or not configured.\nPlease configure before use.");
			Form frm = new frmSetting();
			frm.ShowDialog();
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
			string[] Plugin =
			{
				Properties.Settings.Default.FilePluginDll1,
				Properties.Settings.Default.FilePluginDll2,
				Properties.Settings.Default.FilePluginAvsi
			};

			string[] Data = 
			{
				Properties.Settings.Default.UseFolderPlugin ? "# using installed plugin" : string.Format(Properties.Resources.ScriptPlugin, Plugin),
				string.Format("{0}", Environment.ProcessorCount),
				_file,
				cboPreset.Text,
				cboTuning.Text,
				chkDoubleFps.Checked ? "true" : "false",
				chkUseGPU.Checked ? "true" : "false",
				cboInputType.Text,
				chkFullFrame.Checked ? ", NewNum=60, NewDen=1" : null
			};

			File.WriteAllText(_fileavs, string.Format(Properties.Resources.ScriptHFR, Data), UTF8);
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
