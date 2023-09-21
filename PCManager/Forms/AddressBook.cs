using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();            
        }
        private void LoadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = openFileDialog.FileName;
                LoadCSVDataToDataGridView(csvFilePath);
            }
        }

        //private void LoadCSVDataToDataGridView(string filePath)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();

        //        using (StreamReader sr = new StreamReader(filePath))
        //        {
        //            string[] headers = sr.ReadLine().Split(';');
        //            foreach (string header in headers)
        //            {
        //                dt.Columns.Add(header);
        //            }

        //            while (!sr.EndOfStream)
        //            {
        //                string[] rows = sr.ReadLine().Split(';');
        //                dt.Rows.Add(rows);
        //            }
        //        }

        //        dgvAddressBook.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Błąd podczas wczytywania pliku CSV: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void LoadCSVDataToDataGridView(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] rowData = sr.ReadLine().Split(';');
                        dgvAddressBook.Rows.Add(rowData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wczytywania pliku CSV: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveDataToCSV(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in dgvAddressBook.Rows)
                    {
                        if (!row.IsNewRow) // Pomijaj nowy pusty rekord
                        {
                            List<string> rowData = new List<string>();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                rowData.Add(cell.Value.ToString());
                            }
                            sw.WriteLine(string.Join(";", rowData));
                        }
                    }
                }

                MessageBox.Show("Dane zostały zapisane do pliku CSV.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania danych do pliku CSV: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = saveFileDialog.FileName;
                SaveDataToCSV(csvFilePath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
