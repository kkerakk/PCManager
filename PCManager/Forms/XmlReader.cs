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
            var pathDirectory = lbSubfoldersPath.SelectedItem.ToString();
            //if (string.IsNullOrEmpty(txtDirectoryPath.Text))
            //    return;
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
                //string dokTozsamNumer = student.Element("osoba").Element("dokTozsamNumer").Value;
                string semestrNr = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("daneSemestru").Element("semestrNr").Value;
                string rokAkademicki = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("daneSemestru").Element("rokAkademicki").Value;
                string semestrStudenta = student.Element("daneDotyczaceStudiow").Element("semestry").Element("semestr").Element("daneSemestru").Element("semestrStudenta").Value;

                DGVXmlReader.Rows.Add(nazwisko, imie, pesel, ectsUzyskane, semestrNr, semestrStudenta, rokAkademicki);
            }
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
                    //new DataGridViewTextBoxColumn() { HeaderText = "dokTozsamNumer", Name = "dokTozsamNumer" },
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
        }

        private void btnClearPath_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Clear();
        }

        private void CheckValuesInColumn()
        {
            if (DGVXmlReader == null)
                return;

            // Tworzymy listę z wartościami z kolumny columnName
            List<string> valuesList = new List<string>();
            foreach (DataGridViewRow row in DGVXmlReader.Rows)
            {
                string value = row.Cells["pesel"].Value.ToString();
                valuesList.Add(value);
            }

            // Wyciągamy unikatowe wartości z listy z użyciem metody Distinct() i LINQ
            List<string> uniqueValues = valuesList.Distinct().ToList();
            LVUniqueValues.Items.Clear();

            foreach (var value in uniqueValues)
            {
                LVUniqueValues.Items.Add(value);
            }

        }

        private void btnCheckUniqueValues_Click(object sender, EventArgs e)
        {
            CheckValuesInColumn();
        }

        private void GetListFilesFromDirectory()
        {
            // Zakładając, że folder główny ma nazwę semestr_letni
            if (String.IsNullOrEmpty(txtMainPath.Text))
                return;

            string mainFolder = txtMainPath.Text;

            List<string> xmlFilePaths = new List<string>();

            // Pobieramy nazwy wszystkich podfolderów w folderze głównym
            string[] subfolders = Directory.GetDirectories(mainFolder);

            foreach (string subfolder in subfolders)
            {
                // Pobieramy ścieżki do plików .xml w podfolderze i dodajemy je do listy
                string[] xmlFiles = Directory.GetFiles(subfolder, "*.xml", SearchOption.TopDirectoryOnly);
                xmlFilePaths.AddRange(xmlFiles);
            }

            // W xmlFilePaths znajdują się pełne ścieżki do wszystkich plików .xml we wszystkich podfolderach
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
    }
}