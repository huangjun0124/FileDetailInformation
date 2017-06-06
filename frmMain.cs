using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DetailFileInfo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdOpenFile;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.OpenFileDialog fdFile;
		private System.Windows.Forms.GroupBox grpFileInfo;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtFiletype;
		private System.Windows.Forms.Label lblFileType;
		private System.Windows.Forms.TextBox txtFileSize;
		private System.Windows.Forms.Label lblFileSize;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.TextBox txtComment;
		private System.Windows.Forms.Label lblComment;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdOpenFile = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.fdFile = new System.Windows.Forms.OpenFileDialog();
			this.grpFileInfo = new System.Windows.Forms.GroupBox();
			this.lblFileName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtFiletype = new System.Windows.Forms.TextBox();
			this.lblFileType = new System.Windows.Forms.Label();
			this.txtFileSize = new System.Windows.Forms.TextBox();
			this.lblFileSize = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.lblSubject = new System.Windows.Forms.Label();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.lblComment = new System.Windows.Forms.Label();
			this.grpFileInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdOpenFile
			// 
			this.cmdOpenFile.Location = new System.Drawing.Point(360, 16);
			this.cmdOpenFile.Name = "cmdOpenFile";
			this.cmdOpenFile.TabIndex = 0;
			this.cmdOpenFile.Text = "open";
			this.cmdOpenFile.Click += new System.EventHandler(this.cmdOpenFile_Click);
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(8, 16);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(336, 20);
			this.txtFile.TabIndex = 1;
			this.txtFile.Text = "";
			// 
			// fdFile
			// 
			this.fdFile.AddExtension = false;
			// 
			// grpFileInfo
			// 
			this.grpFileInfo.Controls.Add(this.txtComment);
			this.grpFileInfo.Controls.Add(this.lblComment);
			this.grpFileInfo.Controls.Add(this.txtCategory);
			this.grpFileInfo.Controls.Add(this.lblCategory);
			this.grpFileInfo.Controls.Add(this.txtAuthor);
			this.grpFileInfo.Controls.Add(this.lblAuthor);
			this.grpFileInfo.Controls.Add(this.txtSubject);
			this.grpFileInfo.Controls.Add(this.lblSubject);
			this.grpFileInfo.Controls.Add(this.txtTitle);
			this.grpFileInfo.Controls.Add(this.lblTitle);
			this.grpFileInfo.Controls.Add(this.txtFileSize);
			this.grpFileInfo.Controls.Add(this.lblFileSize);
			this.grpFileInfo.Controls.Add(this.txtFiletype);
			this.grpFileInfo.Controls.Add(this.lblFileType);
			this.grpFileInfo.Controls.Add(this.txtName);
			this.grpFileInfo.Controls.Add(this.lblFileName);
			this.grpFileInfo.Location = new System.Drawing.Point(8, 48);
			this.grpFileInfo.Name = "grpFileInfo";
			this.grpFileInfo.Size = new System.Drawing.Size(432, 360);
			this.grpFileInfo.TabIndex = 2;
			this.grpFileInfo.TabStop = false;
			this.grpFileInfo.Text = "File Detailed Info";
			// 
			// lblFileName
			// 
			this.lblFileName.Location = new System.Drawing.Point(16, 24);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(100, 24);
			this.lblFileName.TabIndex = 0;
			this.lblFileName.Text = "Name:";
			this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(136, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(280, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			// 
			// txtFiletype
			// 
			this.txtFiletype.Location = new System.Drawing.Point(136, 56);
			this.txtFiletype.Name = "txtFiletype";
			this.txtFiletype.Size = new System.Drawing.Size(280, 20);
			this.txtFiletype.TabIndex = 3;
			this.txtFiletype.Text = "";
			// 
			// lblFileType
			// 
			this.lblFileType.Location = new System.Drawing.Point(16, 56);
			this.lblFileType.Name = "lblFileType";
			this.lblFileType.Size = new System.Drawing.Size(100, 24);
			this.lblFileType.TabIndex = 2;
			this.lblFileType.Text = "Filetype:";
			this.lblFileType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFileSize
			// 
			this.txtFileSize.Location = new System.Drawing.Point(136, 88);
			this.txtFileSize.Name = "txtFileSize";
			this.txtFileSize.Size = new System.Drawing.Size(280, 20);
			this.txtFileSize.TabIndex = 5;
			this.txtFileSize.Text = "";
			// 
			// lblFileSize
			// 
			this.lblFileSize.Location = new System.Drawing.Point(16, 88);
			this.lblFileSize.Name = "lblFileSize";
			this.lblFileSize.Size = new System.Drawing.Size(100, 24);
			this.lblFileSize.TabIndex = 4;
			this.lblFileSize.Text = "Filesize:";
			this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(136, 128);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(280, 20);
			this.txtTitle.TabIndex = 7;
			this.txtTitle.Text = "";
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(16, 128);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(100, 24);
			this.lblTitle.TabIndex = 6;
			this.lblTitle.Text = "Title:";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(136, 160);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(280, 20);
			this.txtSubject.TabIndex = 9;
			this.txtSubject.Text = "";
			// 
			// lblSubject
			// 
			this.lblSubject.Location = new System.Drawing.Point(16, 160);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(100, 24);
			this.lblSubject.TabIndex = 8;
			this.lblSubject.Text = "Subject:";
			this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(136, 192);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(280, 20);
			this.txtAuthor.TabIndex = 11;
			this.txtAuthor.Text = "";
			// 
			// lblAuthor
			// 
			this.lblAuthor.Location = new System.Drawing.Point(16, 192);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(100, 24);
			this.lblAuthor.TabIndex = 10;
			this.lblAuthor.Text = "Author:";
			this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(136, 224);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(280, 20);
			this.txtCategory.TabIndex = 13;
			this.txtCategory.Text = "";
			// 
			// lblCategory
			// 
			this.lblCategory.Location = new System.Drawing.Point(16, 224);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(100, 24);
			this.lblCategory.TabIndex = 12;
			this.lblCategory.Text = "Category:";
			this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(136, 256);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(280, 96);
			this.txtComment.TabIndex = 15;
			this.txtComment.Text = "";
			// 
			// lblComment
			// 
			this.lblComment.Location = new System.Drawing.Point(16, 256);
			this.lblComment.Name = "lblComment";
			this.lblComment.Size = new System.Drawing.Size(100, 24);
			this.lblComment.TabIndex = 14;
			this.lblComment.Text = "Comment:";
			this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 410);
			this.Controls.Add(this.grpFileInfo);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.cmdOpenFile);
			this.Name = "frmMain";
			this.Text = "Detailed File Information";
			this.grpFileInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void cmdOpenFile_Click(object sender, System.EventArgs e) {
			
			// Open the File

			if(DialogResult.OK == fdFile.ShowDialog()){
				txtFile.Text = fdFile.FileName;
				string sFileName = txtFile.Text;

				try{

					// Read File Details from CFileInfo Object
					CFileInfo oDetailedFileInfo = new CFileInfo(sFileName);
					txtName.Text = oDetailedFileInfo.FileName;
					txtFiletype.Text = oDetailedFileInfo.FileType;
					txtFileSize.Text = oDetailedFileInfo.FileSize.ToString();
					txtAuthor.Text = oDetailedFileInfo.FileAuthor;
					txtCategory.Text = oDetailedFileInfo.FileCategory;
					txtComment.Text = oDetailedFileInfo.FileComment;
					txtSubject.Text = oDetailedFileInfo.FileSubject;
					txtTitle.Text = oDetailedFileInfo.FileTitle;
				}catch(Exception ex){
					MessageBox.Show("Could not read File information\r\n" + ex.Message, "Error while getting Info", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				

			}

		}
	}
}
