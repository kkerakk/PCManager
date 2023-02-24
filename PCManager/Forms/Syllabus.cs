using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Syllabus : Form
    {
        //List<DataStorage> dataStorage = new List<DataStorage>();
        public Syllabus()
        {
            InitializeComponent();
            GetCurrentAcademicYear();

            btnSyllabusSaveAsText.Enabled = false;
            btnSyllabusSaveAsHTML.Enabled = false;
        }
        FileInfo[] arrayFI;
        #region Methods

        private FileInfo[] GetFilesName()
        {
            var path = txtDirectoryPath.Text;

            string folderPath = txtDirectoryPath.Text;
            if (!Helper.CheckIfPathExist(folderPath))
                return null;

            var di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            return fi;
        }
        private void LoadSyllabus()
        {
            if (GetFilesName() == null)
                return;
            rtxtSyllabus.Clear();
            arrayFI = GetFilesName();
            foreach (var item in arrayFI)
            {
                rtxtSyllabus.Text += item + Environment.NewLine;
            }
        }
        private void ClearData()
        {
            rtxtSyllabus.Clear();
        }
        private void CreateViewSyllabus()
        {
            if (string.IsNullOrEmpty(rtxtSyllabus.Text))
                return;

            var combinedString = $@"{dtpYearOfStudy.Text}/{LBFieldOfStudy.SelectedItem}/{LBLevelOfStudy.SelectedItem}/{LBSemester.SelectedItem}/";
            var pathBegin = $"<p><a href=\"http://wu.wspol.edu.pl/uploaded/SYLABUSY/";
            var pathMiddle = $"\" target = \"_blank\"><img alt=\"Pobierz\" src=\"https://wu.wspol.edu.pl/uploaded/pdf-ikona.png\" style=\"border: 0px currentColor; border-image: none; width: 42px; height: 42px;\"/><span style = \"font-size: 16px;\">";
            var pathEnd = $"</span></a></p>";

            rtxtSyllabus.Clear();
            foreach (var item in arrayFI)
            {
                rtxtSyllabus.Text += $@"{pathBegin}{combinedString}{item
                    .ToString().DeleteBeforeFirstSpace().FirstLetterToUpper().ReplacePolishCharacters().ReplaceSpaces('_')}{pathMiddle}{item
                    .ToString().DeleteBeforeFirstSpace().FirstLetterToUpper()}{pathEnd} " + Environment.NewLine;
            }
        }
        private void ChangeNamesInDirectory()
        {
            string folderPath = txtDirectoryPath.Text;
            if (!Helper.CheckIfPathExist(folderPath))
                return;

            if (!Helper.YesNoPrompt())
                return;

            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                string newFilePath = Path.Combine(
                    Path.GetDirectoryName(filePath),
                    Path.GetFileNameWithoutExtension(filePath)
                    .DeleteBeforeFirstSpace()
                    .FirstLetterToUpper()
                    .ReplacePolishCharacters()
                    .ReplaceSpaces('_')
                    + Path.GetExtension(filePath)
                );
                File.Move(filePath, newFilePath);
            }
        }
        private void CopyAll(RichTextBox richTextBox)
        {
            richTextBox.SelectAll();
            richTextBox.Copy();
        }
        public void GetCurrentAcademicYear()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            if (month >= 1 && month < 9)
                year -= 1;

            dtpYearOfStudy.Value = new DateTime(year, 1, 1);
        }
        private void AutoFillData()
        {
            var path = txtDirectoryPath.Text;

            if (String.IsNullOrEmpty(path))
                return;

            LBFieldOfStudy.SelectedItem = LBFieldOfStudy.Items.Cast<string>().FirstOrDefault(item => path.Contains(item));

            var finalPath = path.Substring(path.Length - 2) == "II" ? "II_stopien" : "I_stopien";

            LBLevelOfStudy.SelectedItem = finalPath;

            LBSemester.SelectedItem = LBSemester.Items.Cast<string>().FirstOrDefault(semester => path.Contains(semester));
        }
        private void btnSyllabus_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ttSyllabus.ShowAlways = true;

            switch (btn.Name)
            {
                case "btnSyllabusSaveAsHTML":
                    ttSyllabus.Show("Save as HTML", btn);
                    break;
                case "btnSyllabusClearPath":
                    ttSyllabus.Show("Clear path", btn);
                    break;
                case "btnSyllabusClear":
                    ttSyllabus.Show("Clear listbox", btn);
                    break;
                case "btnSyllabusSaveAsText":
                    ttSyllabus.Show("Save as text", btn);
                    break;
                case "btnSyllabusCopy":
                    ttSyllabus.Show("Copy", btn);
                    break;
                case "btnSyllabusCheck":
                    ttSyllabus.Show("Check", btn);
                    break;
                case "btnSyllabusLoadNames":
                    ttSyllabus.Show("Load Names", btn);
                    break;
                case "btnSyllabusGenerate":
                    ttSyllabus.Show("Generate", btn);
                    break;
                case "btnSyllabusChangeNames":
                    ttSyllabus.Show("Change names in directory", btn);
                    break;
                case "btnSyllabusClearAll":
                    ttSyllabus.Show("Clear all data from listbox and path", btn);
                    break;
                default:
                    ttSyllabus.Show($"No info about {btn.Name}", btn);
                    break;
            }
        }

        #endregion

        private void btnSyllabusLoadNames_Click(object sender, EventArgs e)
        {
            LoadSyllabus();
        }
        private void btnSyllabusClearPath_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Clear();
        }
        private void btnSyllabusClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void btnSyllabusGenerate_Click(object sender, EventArgs e)
        {
            CreateViewSyllabus();
        }
        private void btnSyllabusChangeNames_Click(object sender, EventArgs e)
        {
            ChangeNamesInDirectory();
        }
        private void btnSyllabusCopy_Click(object sender, EventArgs e)
        {
            CopyAll(rtxtSyllabus);
        }
        private void btnSyllabusCheck_Click(object sender, EventArgs e)
        {
            AutoFillData();
        }
        private void btnSyllabusSaveAsText_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSyllabusSaveAsHTML_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSyllabusClearAll_Click(object sender, EventArgs e)
        {
            ClearData();
            txtDirectoryPath.Clear();
        }
    }
}   