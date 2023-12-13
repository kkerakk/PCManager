using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class FileRename : Form
    {
        public FileRename()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    txtDirectoryPath.Text = selectedFolderPath;
                }
            }
        }

        private void btnLoadNames_Click(object sender, EventArgs e)
        {
            string folderPath = txtDirectoryPath.Text;

            if (Directory.Exists(folderPath))
            {
                lvFileRename.Items.Clear();

                string[] files = Directory.GetFiles(folderPath);

                foreach (string file in files)
                {
                    ListViewItem listItem = new ListViewItem(Path.GetFileName(file));
                    listItem.SubItems.Add(file);

                    lvFileRename.Items.Add(listItem);
                }
            }
            else
            {
                MessageBox.Show("Podana ścieżka folderu nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
