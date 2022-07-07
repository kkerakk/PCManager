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
        public WebsitesSettings()
        {
            InitializeComponent();
            LoadDataButtons();
            LoadDataWebsites();
        }
        private void LoadDataButtons()
        {
            txtBoxBtn01.Text = File.ReadLines(fileNameButtons).Take(1).First();
            txtBoxBtn02.Text = File.ReadLines(fileNameButtons).Skip(1).Take(1).First();
            txtBoxBtn03.Text = File.ReadLines(fileNameButtons).Skip(2).Take(1).First();
            txtBoxBtn04.Text = File.ReadLines(fileNameButtons).Skip(3).Take(1).First();
            txtBoxBtn05.Text = File.ReadLines(fileNameButtons).Skip(4).Take(1).First();
            txtBoxBtn06.Text = File.ReadLines(fileNameButtons).Skip(5).Take(1).First();
            txtBoxBtn07.Text = File.ReadLines(fileNameButtons).Skip(6).Take(1).First();
            txtBoxBtn08.Text = File.ReadLines(fileNameButtons).Skip(7).Take(1).First();
            txtBoxBtn09.Text = File.ReadLines(fileNameButtons).Skip(8).Take(1).First();
            txtBoxBtn10.Text = File.ReadLines(fileNameButtons).Skip(9).Take(1).First();
            txtBoxBtn11.Text = File.ReadLines(fileNameButtons).Skip(10).Take(1).First();
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
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pbBtn01.BackColor = colorPicker.Color;
            }
        }

        public void ChangeColor(ColorDialog colorPicker)
        {
            
        }
    }
}
