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
	public partial class frmSetting : Form
	{
		public frmSetting()
		{
			InitializeComponent();
			this.Icon = Properties.Resources.lightning_go;
		}

		private void frmSetting_Load(object sender, EventArgs e)
		{
			txtPath.Text = Properties.Settings.Default.DirPluginHfr;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog GetFiles = new OpenFileDialog();
			GetFiles.Filter = "InterFrame2.avsi|InterFrame2.avsi|" +
				"svpflow1.dll|svpflow1.dll|" +
				"svpflow2.dll|svpflow2.dll";
			GetFiles.FilterIndex = 1;
			GetFiles.Multiselect = false;

			if (GetFiles.ShowDialog() == DialogResult.OK)
			{
				foreach (var item in GetFiles.FileNames)
				{
					txtPath.Text = Path.GetDirectoryName(item);
					Properties.Settings.Default.DirPluginHfr = Path.GetDirectoryName(item);
					Properties.Settings.Default.Save();
					break;
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
