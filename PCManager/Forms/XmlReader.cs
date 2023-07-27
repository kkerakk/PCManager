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
using System.Xml;
using System.Xml.Linq;

namespace PCManager.Forms
{
    public partial class XmlReader : Form
    {
        public XmlReader()
        {
            InitializeComponent();
            AddColumnToDataGridView();
        }
        private void DeserializeXml()
        {
            if (lbSubfoldersPath.SelectedIndex == -1)
                return;
            var pathDirectory = lbSubfoldersPath.SelectedItem.ToString();

            if (string.IsNullOrEmpty(pathDirectory))
                return;
            DGVXmlReader.Rows.Clear();
            var path = pathDirectory;

            if (!File.Exists(path))
            {
                DGVXmlReader.Text = "Error - no file";
                return;
            }
            XDocument doc = XDocument.Load(path);
            List<XElement> students = doc.Descendants("student").ToList();

            foreach (XElement student in students)
            {
                string imie = student.Element("osoba").Element("imie1").Value;
                string nazwisko = student.Element("osoba").Element("nazwisko").Value;                
                string pesel = student.Element("osoba").Element("pesel").Value;
                string ectsUzyskane = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("ects").Element("ectsUzyskane").Value;
                string semestrNr = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("daneSemestru").Element("semestrNr").Value;
                string rokAkademicki = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("daneSemestru").Element("rokAkademicki").Value;
                string semestrStudenta = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("daneSemestru").Element("semestrStudenta").Value;

                DGVXmlReader.Rows.Add(nazwisko, imie, pesel, ectsUzyskane, semestrNr, semestrStudenta, rokAkademicki);
            }
            LoadHeaders();
            CheckValuesInColumn();

            lblCounterValue.Text = students.Count.ToString();
        }
        private void LoadHeaders()
        {
            lbHeader.Items.Clear();
            lbHeader.Items.Add("ectsUzyskane");
            lbHeader.Items.Add("semestrNr");
            lbHeader.Items.Add("semestrStudenta");
            lbHeader.Items.Add("rokAkademicki");
        }
        private void AddColumnToDataGridView()
        {
            DGVXmlReader.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    new DataGridViewTextBoxColumn() { HeaderText = "imie", Name = "imie1" },
                    new DataGridViewTextBoxColumn() { HeaderText = "nazwisko", Name = "nazwisko" },
                    new DataGridViewTextBoxColumn() { HeaderText = "pesel", Name = "pesel" },
                    new DataGridViewTextBoxColumn() { HeaderText = "ectsUzyskane", Name = "ectsUzyskane" },
                    new DataGridViewTextBoxColumn() { HeaderText = "semestrNr", Name = "semestrNr" },
                    new DataGridViewTextBoxColumn() { HeaderText = "semestrStudenta", Name = "semestrStudenta" },
                    new DataGridViewTextBoxColumn() { HeaderText = "rokAkademicki", Name = "rokAkademicki" },
                }
            );

            foreach (DataGridViewColumn column in DGVXmlReader.Columns)
            {
                column.ReadOnly = true;
            }
        }
        private void btnLoadNames_Click(object sender, EventArgs e)
        {
            DeserializeXml();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DGVXmlReader.Rows.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Clear();
            DGVXmlReader.Rows.Clear();
            lbSubfoldersPath.Items.Clear();
            lbHeader.Items.Clear();
            lblCounterValue.Text = "0";
        }

        private void btnClearPath_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Clear();
        }

        private void CheckValuesInColumn()
        {
            List<string> valuesList = new List<string>();
            if (lbHeader.Items.Count == 0)
                return;


            if (lbHeader.SelectedIndex == -1)
                lbHeader.SelectedItem = "ectsUzyskane";
            
            var header = lbHeader.SelectedItem.ToString();

            foreach (DataGridViewRow row in DGVXmlReader.Rows)
            {
                string value = row.Cells[$"{header}"].Value.ToString();
                valuesList.Add(value);
            }

            List<string> uniqueValues = valuesList.Distinct().ToList();
            rtUniqueValues.Clear();

            foreach (var value in uniqueValues)
            {
                rtUniqueValues.Text += $"{value}\n";
            }
            rtUniqueValues.BackColor = SystemColors.Control;
            if (uniqueValues.Count > 1)
                rtUniqueValues.BackColor = Color.OrangeRed;
        }
        private void btnCheckUniqueValues_Click(object sender, EventArgs e)
        {
            CheckValuesInColumn();
        }
        private void GetListFilesFromDirectory()
        {
            if (String.IsNullOrEmpty(txtDirectoryPath.Text))
                return;

            string mainFolder = txtDirectoryPath.Text;

            List<string> xmlFilePaths = new List<string>();

            string[] subfolders = Directory.GetDirectories(mainFolder);

            foreach (string subfolder in subfolders)
            {
                string[] xmlFiles = Directory.GetFiles(subfolder, "*.xml", SearchOption.TopDirectoryOnly);
                xmlFilePaths.AddRange(xmlFiles);
            }

            lbSubfoldersPath.Items.Clear();
            foreach (var file in xmlFilePaths)
            {
                lbSubfoldersPath.Items.Add(file);
            }
        }
        private void btnGetPath_Click(object sender, EventArgs e)
        {
            GetListFilesFromDirectory();
        }
        private void lbHeader_Click(object sender, EventArgs e)
        {
            CheckValuesInColumn();
        }

        private void lbSubfoldersPath_Click(object sender, EventArgs e)
        {
            DeserializeXml();
        }
    }
}