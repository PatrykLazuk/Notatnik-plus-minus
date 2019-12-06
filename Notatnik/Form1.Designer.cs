namespace Notatnik
{
    partial class Form1
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
            this.rtbNotepadInputField = new System.Windows.Forms.RichTextBox();
            this.bLoadFile = new System.Windows.Forms.Button();
            this.bRenameFile = new System.Windows.Forms.Button();
            this.bDeleteFile = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.lvFilesBrowser = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bSaveButton = new System.Windows.Forms.Button();
            this.bCreateFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lFileNameLabel = new System.Windows.Forms.Label();
            this.folderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbNotepadInputField
            // 
            this.rtbNotepadInputField.Enabled = false;
            this.rtbNotepadInputField.Location = new System.Drawing.Point(552, 55);
            this.rtbNotepadInputField.Name = "rtbNotepadInputField";
            this.rtbNotepadInputField.Size = new System.Drawing.Size(620, 380);
            this.rtbNotepadInputField.TabIndex = 0;
            this.rtbNotepadInputField.Text = "";
            // 
            // bLoadFile
            // 
            this.bLoadFile.Location = new System.Drawing.Point(389, 222);
            this.bLoadFile.Name = "bLoadFile";
            this.bLoadFile.Size = new System.Drawing.Size(154, 55);
            this.bLoadFile.TabIndex = 2;
            this.bLoadFile.Text = "Load File";
            this.bLoadFile.UseVisualStyleBackColor = true;
            this.bLoadFile.Click += new System.EventHandler(this.bLoadFile_Click);
            // 
            // bRenameFile
            // 
            this.bRenameFile.Location = new System.Drawing.Point(390, 284);
            this.bRenameFile.Name = "bRenameFile";
            this.bRenameFile.Size = new System.Drawing.Size(153, 57);
            this.bRenameFile.TabIndex = 3;
            this.bRenameFile.Text = "Rename File";
            this.bRenameFile.UseVisualStyleBackColor = true;
            // 
            // bDeleteFile
            // 
            this.bDeleteFile.Location = new System.Drawing.Point(390, 347);
            this.bDeleteFile.Name = "bDeleteFile";
            this.bDeleteFile.Size = new System.Drawing.Size(153, 57);
            this.bDeleteFile.TabIndex = 4;
            this.bDeleteFile.Text = "Delete File";
            this.bDeleteFile.UseVisualStyleBackColor = true;
            this.bDeleteFile.Click += new System.EventHandler(this.bDeleteFile_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(389, 13);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(154, 55);
            this.bBrowse.TabIndex = 5;
            this.bBrowse.Text = "Browse Folder";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // lvFilesBrowser
            // 
            this.lvFilesBrowser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName});
            this.lvFilesBrowser.GridLines = true;
            this.lvFilesBrowser.HideSelection = false;
            this.lvFilesBrowser.Location = new System.Drawing.Point(13, 13);
            this.lvFilesBrowser.Name = "lvFilesBrowser";
            this.lvFilesBrowser.Size = new System.Drawing.Size(370, 422);
            this.lvFilesBrowser.TabIndex = 6;
            this.lvFilesBrowser.UseCompatibleStateImageBehavior = false;
            this.lvFilesBrowser.View = System.Windows.Forms.View.Details;
            // 
            // chFileName
            // 
            this.chFileName.Text = "File name";
            this.chFileName.Width = 360;
            // 
            // bSaveButton
            // 
            this.bSaveButton.Location = new System.Drawing.Point(389, 161);
            this.bSaveButton.Name = "bSaveButton";
            this.bSaveButton.Size = new System.Drawing.Size(154, 55);
            this.bSaveButton.TabIndex = 7;
            this.bSaveButton.Text = "Save file";
            this.bSaveButton.UseVisualStyleBackColor = true;
            this.bSaveButton.Click += new System.EventHandler(this.bSaveButton_Click);
            // 
            // bCreateFile
            // 
            this.bCreateFile.Location = new System.Drawing.Point(390, 100);
            this.bCreateFile.Name = "bCreateFile";
            this.bCreateFile.Size = new System.Drawing.Size(154, 55);
            this.bCreateFile.TabIndex = 8;
            this.bCreateFile.Text = "Create File";
            this.bCreateFile.UseVisualStyleBackColor = true;
            this.bCreateFile.Click += new System.EventHandler(this.bCreateFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lFileNameLabel);
            this.panel1.Location = new System.Drawing.Point(552, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 36);
            this.panel1.TabIndex = 9;
            // 
            // lFileNameLabel
            // 
            this.lFileNameLabel.AutoSize = true;
            this.lFileNameLabel.Location = new System.Drawing.Point(273, 10);
            this.lFileNameLabel.MaximumSize = new System.Drawing.Size(620, 36);
            this.lFileNameLabel.Name = "lFileNameLabel";
            this.lFileNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lFileNameLabel.Size = new System.Drawing.Size(69, 17);
            this.lFileNameLabel.TabIndex = 0;
            this.lFileNameLabel.Text = "File name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCreateFile);
            this.Controls.Add(this.bSaveButton);
            this.Controls.Add(this.lvFilesBrowser);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bDeleteFile);
            this.Controls.Add(this.bRenameFile);
            this.Controls.Add(this.bLoadFile);
            this.Controls.Add(this.rtbNotepadInputField);
            this.Name = "Form1";
            this.Text = "Notepad+-";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNotepadInputField;
        private System.Windows.Forms.Button bLoadFile;
        private System.Windows.Forms.Button bRenameFile;
        private System.Windows.Forms.Button bDeleteFile;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.ListView lvFilesBrowser;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.Button bSaveButton;
        private System.Windows.Forms.Button bCreateFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lFileNameLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

