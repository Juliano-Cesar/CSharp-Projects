using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MSI_Extractor
{
	public partial class MainForm : Form
	{
		private string MSIFilePath;
		private string TargetFolder;
		
		public MainForm()
		{
			InitializeComponent();
			tbFolderPath.ReadOnly = true;
			tbFilePath.ReadOnly = true;
			
		}
		
		void BtnSelectFileClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Microsoft Installer|*.msi";

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
  				MSIFilePath = openFileDialog.FileName;
  				tbFilePath.Text = MSIFilePath;
			}
		}
		
		void BtnFolderSelectClick(object sender, EventArgs e)
		{
			FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();

			if (openFolderDialog.ShowDialog() == DialogResult.OK) {
				TargetFolder = openFolderDialog.SelectedPath;
  				tbFolderPath.Text = TargetFolder;
			}
		}
		
		void BtnExtractClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(MSIFilePath) || string.IsNullOrEmpty(TargetFolder)) {
				MessageBox.Show("Ambos os campos não podem estar vazios.", "Erro");
  				return;
			}
			
			Process process = new Process();
			process.StartInfo.FileName = "msiexec.exe";
			process.StartInfo.Arguments = "/a"+ '"' + MSIFilePath + '"' +"TARGETDIR="+ '"' +TargetFolder + '"';
			process.Start();
			
		}
		
	}
}
