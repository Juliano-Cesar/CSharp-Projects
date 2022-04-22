/*
 * Created by SharpDevelop.
 * User: Pichau
 * Date: 22/04/2022
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MSI_Extractor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbFilePath;
		private System.Windows.Forms.TextBox tbFolderPath;
		private System.Windows.Forms.Button btnFolderSelect;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.Button btnSelectFile;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbFilePath = new System.Windows.Forms.TextBox();
			this.tbFolderPath = new System.Windows.Forms.TextBox();
			this.btnFolderSelect = new System.Windows.Forms.Button();
			this.btnExtract = new System.Windows.Forms.Button();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbFilePath
			// 
			this.tbFilePath.Location = new System.Drawing.Point(12, 23);
			this.tbFilePath.Name = "tbFilePath";
			this.tbFilePath.Size = new System.Drawing.Size(166, 20);
			this.tbFilePath.TabIndex = 0;
			// 
			// tbFolderPath
			// 
			this.tbFolderPath.Location = new System.Drawing.Point(12, 65);
			this.tbFolderPath.Name = "tbFolderPath";
			this.tbFolderPath.Size = new System.Drawing.Size(166, 20);
			this.tbFolderPath.TabIndex = 2;
			// 
			// btnFolderSelect
			// 
			this.btnFolderSelect.Location = new System.Drawing.Point(184, 60);
			this.btnFolderSelect.Name = "btnFolderSelect";
			this.btnFolderSelect.Size = new System.Drawing.Size(88, 28);
			this.btnFolderSelect.TabIndex = 3;
			this.btnFolderSelect.Text = "Select Folder";
			this.btnFolderSelect.UseVisualStyleBackColor = true;
			this.btnFolderSelect.Click += new System.EventHandler(this.BtnFolderSelectClick);
			// 
			// btnExtract
			// 
			this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExtract.Location = new System.Drawing.Point(12, 117);
			this.btnExtract.Name = "btnExtract";
			this.btnExtract.Size = new System.Drawing.Size(260, 23);
			this.btnExtract.TabIndex = 4;
			this.btnExtract.Text = "Extract";
			this.btnExtract.UseVisualStyleBackColor = true;
			this.btnExtract.Click += new System.EventHandler(this.BtnExtractClick);
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(184, 18);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(88, 28);
			this.btnSelectFile.TabIndex = 5;
			this.btnSelectFile.Text = "Select File";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFileClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.btnExtract);
			this.Controls.Add(this.btnFolderSelect);
			this.Controls.Add(this.tbFolderPath);
			this.Controls.Add(this.tbFilePath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Tiurabe\'s MSI Extractor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
