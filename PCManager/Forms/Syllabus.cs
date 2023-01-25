﻿using iTextSharp.text.pdf;
using PCManager.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Syllabus : Form
    {
        //List<DataStorage> dataStorage = new List<DataStorage>();
        public Syllabus()
        {
            InitializeComponent();
            //ReadDataFromJSON();
        }
        FileInfo[] arrayFI;
        #region Methods
        private List<string> GetPdfTitles(string directoryPath)
        {
            List<string> titles = new List<string>();
            string[] pdfFiles = Directory.GetFiles(directoryPath, "*.pdf");
            foreach (string pdfFile in pdfFiles)
            {
                using (PdfReader reader = new PdfReader(pdfFile))
                {
                    string title = reader.Info["Title"];
                    if (!string.IsNullOrEmpty(title))
                    {
                        titles.Add(title);
                    }
                }
            }
            return titles;
        }
        private FileInfo[] GetFilesName()
        {
            var path = txtDirectoryPath.Text;

            if (string.IsNullOrEmpty(path))
            {

                MessageBox.Show("The path is empty", "Path error");
                return null;
            }
            if (!Directory.Exists(path))
            {
                MessageBox.Show("The path doesn't exist", "Path error");
                return null;
            }

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
            txtDirectoryPath.Clear();
        }
        private void CreateViewSyllabus()
        {
            if (string.IsNullOrEmpty(rtxtSyllabus.Text))
                return;
            if (true)
            {

            }
            var combinedString = $@"{LBYear.SelectedItem}\{LBFieldOfStudy.SelectedItem}\{LBLevelOfStudy.SelectedItem}\{LBSemester.SelectedItem}\";
            var pathBegin = $"<p><a href=\"http://wu.wspol.edu.pl/uploaded/SYLABUSY/";
            var pathMiddle = $"\" target = \"_blank\"> <img alt=\"Pobierz\" src=\"https://wu.wspol.edu.pl/uploaded/pdf-ikona.png\" style=\"border: 0px currentColor; border-image: none; width: 42px; height: 42px;\" /> <span style = \"font-size: 16px;\">";
            var pathEnd = $"</span></a></p>";

            rtxtSyllabus.Clear();
            foreach (var item in arrayFI)
            {
                rtxtSyllabus.Text += $@"{pathBegin}{combinedString}{item}{pathMiddle}{item}{pathEnd} " + Environment.NewLine;
            }
        }
        private void ReadDataFromJSON()
        {
            List<DataStorage> dataStorages = new List<DataStorage>();

            Helper.ReadFromJSON(ref dataStorages);
            if (dataStorages.Count == 0)
            {
                return;
            }
            txtDirectoryPath.Text = dataStorages[0].Name;
        }
        private void AddPathToJSON(TextBox tb)
        {

            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show("The path is empty", "Error");
                return;
            }
            var nameExist = Helper.dataStorages.Any(x => x.Name == tb.Text);
            if (nameExist)
            {
                MessageBox.Show("The path already exist", "Error");
                return;
            }
            var valueStr = new DataStorage { FormsName = "Syllabus", Name = tb.Text };
            Helper.SaveToJSON(valueStr);
        }
        #endregion

        private void lblDirectoryPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void btnSyllabusLoad_Click(object sender, EventArgs e)
        {
            LoadSyllabus();
        }
        private void btnSyllabusAddPath_Click(object sender, EventArgs e)
        {
            AddPathToJSON(txtDirectoryPath);
        }
        private void btnSyllabusClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void btnSyllabusGenerate_Click(object sender, EventArgs e)
        {
            CreateViewSyllabus();
        }

        private void btnSyllabusSave_Click(object sender, EventArgs e)
        {

        }
    }
}
