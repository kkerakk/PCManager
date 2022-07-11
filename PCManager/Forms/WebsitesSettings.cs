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
    public partial class WebsitesSettings : Form
    {
        private string fileNameButtons = "E:\\C#\\PCManager\\PCManager\\Media\\WebsitesButtons.txt";
        private string fileNameWebsites = "E:\\C#\\PCManager\\PCManager\\Media\\Websites.txt";
        private string fileNameColors = "E:\\C#\\PCManager\\PCManager\\Media\\Colors.txt";
        public WebsitesSettings()
        {
            InitializeComponent();
            LoadDataButtons();
            LoadDataWebsites();
        }
        private void LoadDataButtons()
        {
            //txtBoxBtn01.Text = File.ReadLines(fileNameButtons).Take(1).First();
            //txtBoxBtn02.Text = File.ReadLines(fileNameButtons).Skip(1).Take(1).First();
            //txtBoxBtn03.Text = File.ReadLines(fileNameButtons).Skip(2).Take(1).First();
            //txtBoxBtn04.Text = File.ReadLines(fileNameButtons).Skip(3).Take(1).First();
            //txtBoxBtn05.Text = File.ReadLines(fileNameButtons).Skip(4).Take(1).First();
            //txtBoxBtn06.Text = File.ReadLines(fileNameButtons).Skip(5).Take(1).First();
            //txtBoxBtn07.Text = File.ReadLines(fileNameButtons).Skip(6).Take(1).First();
            //txtBoxBtn08.Text = File.ReadLines(fileNameButtons).Skip(7).Take(1).First();
            //txtBoxBtn09.Text = File.ReadLines(fileNameButtons).Skip(8).Take(1).First();
            //txtBoxBtn10.Text = File.ReadLines(fileNameButtons).Skip(9).Take(1).First();
            //txtBoxBtn11.Text = File.ReadLines(fileNameButtons).Skip(10).Take(1).First();

            List<TextBox> listLoadData = new List<TextBox>();

            foreach (TextBox txtBox in FLPtxtBoxBtn.Controls)
            {
                listLoadData.Add(txtBox);
                int index = listLoadData.IndexOf(txtBox);
                txtBox.Text = File.ReadLines(fileNameButtons).Skip(index).Take(1).First();
            }            
        }
        private void LoadDataWebsites()
        {
            txtBoxURL01.Text = File.ReadLines(fileNameWebsites).Take(1).First();
            txtBoxURL02.Text = File.ReadLines(fileNameWebsites).Skip(1).Take(1).First();
            txtBoxURL03.Text = File.ReadLines(fileNameWebsites).Skip(2).Take(1).First();
            txtBoxURL04.Text = File.ReadLines(fileNameWebsites).Skip(3).Take(1).First();
            txtBoxURL05.Text = File.ReadLines(fileNameWebsites).Skip(4).Take(1).First();
            txtBoxURL06.Text = File.ReadLines(fileNameWebsites).Skip(5).Take(1).First();
            txtBoxURL07.Text = File.ReadLines(fileNameWebsites).Skip(6).Take(1).First();
            txtBoxURL08.Text = File.ReadLines(fileNameWebsites).Skip(7).Take(1).First();
            txtBoxURL09.Text = File.ReadLines(fileNameWebsites).Skip(8).Take(1).First();
            txtBoxURL10.Text = File.ReadLines(fileNameWebsites).Skip(9).Take(1).First();
            txtBoxURL11.Text = File.ReadLines(fileNameWebsites).Skip(10).Take(1).First();
        }

        private void pbBtn01_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn01,1);
        }
        private void pbBtn02_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn02, 2);
        }

        private void pbBtn03_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn03, 3);
        }

        private void pbBtn04_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn04, 4);
        }

        private void pbBtn05_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn05, 5);
        }

        private void pbBtn06_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn06, 6);
        }

        private void pbBtn07_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn07, 7);
        }

        private void pbBtn08_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn08, 8);
        }

        private void pbBtn09_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn09, 9);
        }

        private void pbBtn10_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn10, 10);
        }

        private void pbBtn11_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn11, 11);
        }

        private void pbBtn12_Click(object sender, EventArgs e)
        {
            ChangeColor(pbBtn12, 12);
        }
        public void ChangeColor(PictureBox pictureBox, int id)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox.BackColor = colorPicker.Color;
                LoadFromTxt(pictureBox, id);
            }
        }
        void LoadFromTxt(PictureBox pictureBox, int id)
        {
            string[] arrLine = File.ReadAllLines(fileNameColors);
            arrLine[id - 1] = pictureBox.BackColor.ToString();
            File.WriteAllLines(fileNameColors, arrLine);
        }
    }
}
