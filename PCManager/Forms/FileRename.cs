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
        private string[] originalFileNames;

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
                originalFileNames = null; // Reset listy oryginalnych nazw plików przed każdym ładowaniem

                string[] files = Directory.GetFiles(folderPath);

                foreach (string file in files)
                {
                    ListViewItem listItem = new ListViewItem(Path.GetFileName(file));
                    listItem.SubItems.Add(file);

                    lvFileRename.Items.Add(listItem);
                }
                originalFileNames = lvFileRename.Items.Cast<ListViewItem>().Select(item => item.SubItems[0].Text).ToArray();
            }
            else
            {
                MessageBox.Show("Podana ścieżka folderu nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            if (originalFileNames != null)
            {
                for (int i = 0; i < lvFileRename.Items.Count; i++)
                {
                    string originalFileName = originalFileNames[i];
                    string newFileName = originalFileName;

                    if (cbRemoveSpace.Checked)
                    {
                        newFileName = newFileName.Replace(" ", "");
                    }

                    if (cbChangePolishLetters.Checked)
                    {
                        newFileName = ReplacePolishLetters(newFileName);
                    }

                    string originalFilePath = lvFileRename.Items[i].SubItems[1].Text;
                    string newFilePath = Path.Combine(Path.GetDirectoryName(originalFilePath), newFileName);

                    try
                    {
                        File.Move(originalFilePath, newFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas zmiany nazwy pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Zaktualizuj widok plików po zmianie nazw
                btnLoadNames_Click(sender, e);
            }
        }

        private void btnRestoreNames_Click(object sender, EventArgs e)
        {
            if (originalFileNames != null)
            {
                for (int i = 0; i < originalFileNames.Length; i++)
                {
                    string originalFilePath = lvFileRename.Items[i].SubItems[1].Text;
                    string originalFileName = originalFileNames[i];
                    string newFilePath = Path.Combine(Path.GetDirectoryName(originalFilePath), originalFileName);

                    try
                    {
                        File.Move(originalFilePath, newFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas przywracania oryginalnej nazwy pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Zaktualizuj widok plików po przywróceniu oryginalnych nazw
                btnLoadNames_Click(sender, e);
            }
        }

        private string ReplacePolishLetters(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'ą': result.Append('a'); break;
                    case 'ć': result.Append('c'); break;
                    case 'ę': result.Append('e'); break;
                    case 'ł': result.Append('l'); break;
                    case 'ń': result.Append('n'); break;
                    case 'ó': result.Append('o'); break;
                    case 'ś': result.Append('s'); break;
                    case 'ź': result.Append('z'); break;
                    case 'ż': result.Append('z'); break;
                    default: result.Append(c); break;
                }
            }

            return result.ToString();
        }
    }
}
