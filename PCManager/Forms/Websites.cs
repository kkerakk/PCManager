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
        public Websites()
        {
            InitializeComponent();
            LoadDefaultData();
        }

        private void btnWeb01_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL01.Text;
            Process.Start(website);
        }

        private void btnWeb02_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL02.Text;
            Process.Start(website);
        }

        private void btnWeb03_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL03.Text;
            Process.Start(website);
        }

        private void btnWeb04_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL04.Text;
            Process.Start(website);
        }

        private void btnWeb05_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL05.Text;
            Process.Start(website);
        }

        private void btnWeb06_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL06.Text;
            Process.Start(website);
        }

        private void btnWeb07_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL07.Text;
            Process.Start(website);
        }

        private void btnWeb08_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL08.Text;
            Process.Start(website);
        }

        private void btnWeb09_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL09.Text;
            Process.Start(website);
        }

        private void btnWeb10_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL10.Text;
            Process.Start(website);
        }

        private void btnWeb11_Click(object sender, EventArgs e)
        {
            string website = wbs.txtBoxURL11.Text;
            Process.Start(website);
        }

        private void btnWeb12_Click(object sender, EventArgs e)
        {

        }

        private void LoadDefaultData()
        {
            btnWeb01.Text = wbs.txtBoxBtn01.Text;
            btnWeb02.Text = wbs.txtBoxBtn02.Text;
            btnWeb03.Text = wbs.txtBoxBtn03.Text;
            btnWeb04.Text = wbs.txtBoxBtn04.Text;
            btnWeb05.Text = wbs.txtBoxBtn05.Text;
            btnWeb06.Text = wbs.txtBoxBtn06.Text;
            btnWeb07.Text = wbs.txtBoxBtn07.Text;
            btnWeb08.Text = wbs.txtBoxBtn08.Text;
            btnWeb09.Text = wbs.txtBoxBtn09.Text;
            btnWeb10.Text = wbs.txtBoxBtn10.Text;
            btnWeb11.Text = wbs.txtBoxBtn11.Text;
        }



        //private void btnWebsitesSettings_Click(object sender, EventArgs e)
        //{
        //    if (FLPWebsitesMain.Visible == true)
        //    {
        //        FLPWebsitesMain.Visible = false;
        //    }
        //    else
        //    {
        //        FLPWebsitesMain.Visible = true;
        //    }
        //}
    }
}
