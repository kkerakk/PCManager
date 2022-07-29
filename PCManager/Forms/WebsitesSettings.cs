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
using Microsoft.VisualBasic;

namespace PCManager.Forms
{
    public partial class WebsitesSettings : Form
    {
        private string fileNameButtons = "./../../Media/WebsitesButtons.txt";
        private string fileNameWebsites = "./../../Media/Websites.txt";
        private string fileNameColors = "./../../Media/Colors.txt";

        List<PictureBox> listPictureBoxes = new List<PictureBox>();
        List<TextBox> listTextBoxes = new List<TextBox>();
        List<TextBox> listButtonsURL = new List<TextBox>();

        public TextBox[] textBoxes;
        public PictureBox[] pictureBoxes;
        public TextBox[] buttonsURL;

        List<string> strPictureBoxes = new List<string>();
        List<string> strTextBoxes = new List<string>();
        List<string> strButtonsURL = new List<string>();

        public WebsitesSettings()
        {
            InitializeComponent();
            LoadDataButtons();
            LoadDataWebsites();
            LoadDataColors();
            LoadDataToArrays();
        }
        public void LoadDataToArrays()
        {
            foreach (PictureBox pictureBox in FLPpbBtn.Controls)
            {
                listPictureBoxes.Add(pictureBox);
            }

            foreach (TextBox textBox in FLPtxtBoxBtn.Controls)
            {
                listTextBoxes.Add(textBox);
            }

            foreach (TextBox textBoxURL in FLPtxtBoxURL.Controls)
            {
                listButtonsURL.Add(textBoxURL);
            }

            pictureBoxes = listPictureBoxes.ToArray();
            textBoxes = listTextBoxes.ToArray();
            buttonsURL = listButtonsURL.ToArray();
        }
        public void LoadTextNameToStringArrays()
        {
            foreach (TextBox textBox in FLPtxtBoxBtn.Controls)
            {
                strTextBoxes.Add((string)textBox.Text);
            }
            foreach (TextBox textBox in FLPtxtBoxURL.Controls)
            {
                strButtonsURL.Add((string)textBox.Text);
            }
            foreach (PictureBox pictureBox in FLPpbBtn.Controls)
            {
                strPictureBoxes.Add((string)pictureBox.BackColor.ToArgb().ToString());
            }
        }

        private void LoadDataButtons()
        {
            try
            {
                List<TextBox> listLoadData = new List<TextBox>();

                foreach (TextBox textBox in FLPtxtBoxBtn.Controls)
                {
                    listLoadData.Add(textBox);
                    int index = listLoadData.IndexOf(textBox);
                    textBox.Text = File.ReadLines(fileNameButtons).Skip(index).Take(1).First();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        private void LoadDataWebsites()
        {
            try
            {
                List<TextBox> listLoadData = new List<TextBox>();

                foreach (TextBox textBox in FLPtxtBoxURL.Controls)
                {
                    listLoadData.Add(textBox);
                    int index = listLoadData.IndexOf(textBox);
                    textBox.Text = File.ReadLines(fileNameWebsites).Skip(index).Take(1).First();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        private void LoadDataColors()
        {
            try
            {
                List<PictureBox> listLoadData = new List<PictureBox>();

                foreach (PictureBox pictureBox in FLPpbBtn.Controls)
                {
                    listLoadData.Add(pictureBox);
                    int index = listLoadData.IndexOf(pictureBox);
                    pictureBox.BackColor = Color.FromArgb(Int32.Parse(File.ReadLines(fileNameColors).Skip(index).Take(1).First()));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        private int GetButtonID(object sender)
        {
            string id = ((PictureBox)sender).Name.ToString();
            int intID = int.Parse(id.Substring(id.Length - 2, 2));
            return intID;
        }
        private void pbBtn01_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id-1], id);
            //MessageBox.Show(GetButtonID(sender).GetType().ToString() + "\n" + GetButtonID(sender).ToString());
        }
        private void pbBtn02_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn03_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn04_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn05_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn06_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn07_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn08_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn09_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn10_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn11_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn12_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }
        private void pbBtn13_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn14_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn15_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn16_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn17_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn18_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn19_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn20_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn21_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn22_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn23_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn24_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn25_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn26_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn27_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn28_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn29_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }

        private void pbBtn30_Click(object sender, EventArgs e)
        {
            int id = GetButtonID(sender);
            ChangePictureBoxColor(pictureBoxes[id - 1], id);
        }
        private void ChangePictureBoxColor(PictureBox pictureBox, int id)
        {
            try
            {
                ColorDialog colorPicker = new ColorDialog();
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.BackColor = colorPicker.Color;
                    //SaveToTXT(pictureBox, id);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        void SaveToTXT(PictureBox pictureBox, int id)
        {
            try
            {
                string[] arrLine = File.ReadAllLines(fileNameColors);
                arrLine[id - 1] = pictureBox.BackColor.ToArgb().ToString();
                File.WriteAllLines(fileNameColors, arrLine);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }            
        }
        private void ResetPictureBoxColor()
        {
            List<PictureBox> listResetPicBoxColor = new List<PictureBox>();

            foreach (PictureBox pictureBox in FLPpbBtn.Controls)
            {
                pictureBox.BackColor = Color.AntiqueWhite;
            }
        }

        private void btnResetPicBoxColor_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy chcesz wyczyścić kolory z przycisków?", "Czy wyczyścić kolory?", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                ResetPictureBoxColor();
            }
        }

        private void btnHideShowButtons_Click(object sender, EventArgs e)
        {
            try
            {
                int pbControlsCount = FLPpbBtn.Controls.Count;
                string userAnswer = Interaction.InputBox($"Ile przycisków ma być widocznych?\nMin ilość przycisków: 1\nMax ilość przycisków: {pbControlsCount}", "Ukryj/Odkryj przycisk");
                int.TryParse(userAnswer, out int amountInt);

                for (int i = 0; i < pbControlsCount; i++)
                {
                    if (i + 1 <= amountInt)
                    {
                        pictureBoxes[i].Visible = true;
                        textBoxes[i].Visible = true;
                        buttonsURL[i].Visible = true;
                        //websites.buttons[i].Visible = true;

                    }
                    else
                    {
                        pictureBoxes[i].Visible = false;
                        textBoxes[i].Visible = false;
                        buttonsURL[i].Visible = false;
                        //websites.buttons[1].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy chcesz zapisać zmiany?", "Zapisać zmiany?", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                LoadTextNameToStringArrays();
                File.WriteAllLines(fileNameButtons, strTextBoxes);
                File.WriteAllLines(fileNameWebsites, strButtonsURL);
                File.WriteAllLines(fileNameColors, strPictureBoxes);
            }
        }
    }
}