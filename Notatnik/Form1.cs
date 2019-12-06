using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbNotepadInputField.Enabled = false;
        }

        private void RefreshFileList()
        {
            rtbNotepadInputField.Enabled = false;
            rtbNotepadInputField.Clear();
            lvFilesBrowser.Items.Clear();
            if (!(folderBrowseDialog.SelectedPath == ""))
            {
                foreach (var file in Directory.GetFiles(folderBrowseDialog.SelectedPath))
                {
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = Path.GetFileNameWithoutExtension(file);
                    viewItem.ToolTipText = file;
                    lvFilesBrowser.Items.Add(viewItem);
                }
            }

        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            folderBrowseDialog.ShowDialog();

            RefreshFileList();
        }


        private void bCreateFile_Click(object sender, EventArgs e)
        {
            rtbNotepadInputField.Enabled = true;
            rtbNotepadInputField.Clear();
            lFileNameLabel.Text = "...";

        }


        private void bSaveButton_Click(object sender, EventArgs e)
        {
            if (rtbNotepadInputField.Enabled == true)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.UTF8))
                    {
                        writer.Write(rtbNotepadInputField.Text);
                    }
                }
                RefreshFileList();
            }
        }


        private void bLoadFile_Click(object sender, EventArgs e)
        {
            if (lvFilesBrowser.SelectedItems.Count > 0)
            {
                lFileNameLabel.Text = lvFilesBrowser.SelectedItems[0].Text;
                rtbNotepadInputField.Enabled = true;
                using (StreamReader reader = new StreamReader(lvFilesBrowser.SelectedItems[0].ToolTipText, detectEncodingFromByteOrderMarks: true))
                {
                    rtbNotepadInputField.Text = reader.ReadToEnd();
                }
            }
        }


        private void bRenameFile_Click(object sender, EventArgs e)
        {
            //TODO przygotowac logike do zmiany nazwy pliku
        }


        private void bDeleteFile_Click(object sender, EventArgs e)
        {

            if(Prompt.ShowDialog("Delete file?", "Delete"))
            {
                if(File.Exists(lvFilesBrowser.SelectedItems[0].ToolTipText))
                    File.Delete(lvFilesBrowser.SelectedItems[0].ToolTipText);
                RefreshFileList();
            }

        }

        
    }
}