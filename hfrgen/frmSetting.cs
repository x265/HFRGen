using System;
using System.IO;
using System.Windows.Forms;

using static hfrgen.Properties.Settings;

namespace hfrgen
{
	public partial class frmSetting : Form
	{
		public frmSetting()
		{
			InitializeComponent();
			Icon = Properties.Resources.lightning_go;
		}

		private void frmSetting_Load(object sender, EventArgs e)
		{
			txtPath.Text = Default.FilePluginAvsi;
			txtPath2.Text = Default.FilePluginDll1;
			txtPath3.Text = Default.FilePluginDll2;
			chkUsePluginFolder.Checked = Default.UseFolderPlugin;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog GetFiles = new OpenFileDialog();
			GetFiles.Filter = "InterFrame2.avsi|InterFrame2.avsi";
			GetFiles.FilterIndex = 1;
			GetFiles.Multiselect = false;

			if (GetFiles.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = GetFiles.FileName;
				Default.FilePluginAvsi = GetFiles.FileName;
			}
		}

		private void btnBrowse2_Click(object sender, EventArgs e)
		{
			OpenFileDialog GetFiles = new OpenFileDialog();
			GetFiles.Filter = "svpflow1.dll|svpflow1.dll";
			GetFiles.FilterIndex = 1;
			GetFiles.Multiselect = false;

			if (GetFiles.ShowDialog() == DialogResult.OK)
			{
				txtPath2.Text = GetFiles.FileName;
				Default.FilePluginDll1 = GetFiles.FileName;
			}
		}

		private void btnBrowse3_Click(object sender, EventArgs e)
		{
			OpenFileDialog GetFiles = new OpenFileDialog();
			GetFiles.Filter = "svpflow2.dll|svpflow2.dll";
			GetFiles.FilterIndex = 1;
			GetFiles.Multiselect = false;

			if (GetFiles.ShowDialog() == DialogResult.OK)
			{
				txtPath3.Text = GetFiles.FileName;
				Default.FilePluginDll2 = GetFiles.FileName;
			}
		}

		private void chkUsePluginFolder_CheckedChanged(object sender, EventArgs e)
		{
			var x = chkUsePluginFolder.Checked;
			Default.UseFolderPlugin = x;
			txtPath.Enabled = !x;
			txtPath2.Enabled = !x;
			txtPath3.Enabled = !x;
			btnBrowse.Enabled = !x;
			btnBrowse2.Enabled = !x;
			btnBrowse3.Enabled = !x;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Default.Save();
			Close();
		}
	}
}
