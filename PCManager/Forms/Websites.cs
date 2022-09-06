using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Websites : Form
    {
        WebsitesSettings wbs = new WebsitesSettings();
        List<Button> listWbButtons = new List<Button>();

        public Button[] buttons;

        public Websites()
        {
            InitializeComponent();
            LoadDataToArrays();
            LoadDefaultData();
            ChangeButtonColor();
        }
        private void LoadDataToArrays()
        {
            try
            {
                foreach (Button button in FLPWebsitesMain.Controls)
                {
                    listWbButtons.Add(button);
                }

                buttons = listWbButtons.ToArray();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        private void LoadDefaultData()
        {
            try
            {
                foreach (var tuple in buttons.Zip(wbs.textBoxes, (x, y) => (x, y)))
                {
                    tuple.x.Text = tuple.y.Text;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        private void ChangeButtonColor()
        {
            try
            {
                foreach (var tuple in buttons.Zip(wbs.pictureBoxes, (x, y) => (x, y)))
                {
                    tuple.x.BackColor = tuple.y.BackColor;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        private int GetButtonID(object sender)
        {
            string id = ((Button)sender).Name.ToString();
            int intID = int.Parse(id.Substring(id.Length - 2, 2));
            return intID;
        }
        private void openWebsite(object sender)
        {
            try
            {
                string website = wbs.buttonsURL[GetButtonID(sender) - 1].Text;
                Process.Start(website);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Błąd");
            }
            
        }
        private void btnWeb01_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb02_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb03_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb04_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb05_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb06_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb07_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb08_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb09_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb10_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb11_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb12_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb13_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb14_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb15_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb16_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb17_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb18_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb19_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb20_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb21_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb22_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb23_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb24_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb25_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb26_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb27_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb28_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb29_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }

        private void btnWeb30_Click(object sender, EventArgs e)
        {
            openWebsite(sender);
        }
    }
}