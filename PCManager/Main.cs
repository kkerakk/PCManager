using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Form activeForm;
        private static string formName;
        public Main()
        {
            InitializeComponent();
            //CheckActiveForm();
            testTextBox();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                }
            }
        }

        protected void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            string form = childForm.Name;
            formName = childForm.Name;

            //private void CheckActiveForm()
            if (formName == "Websites")
            {
                btnSettings.Enabled = true;
                btnSettings.Visible = true;
            }
            else
            {
                btnSettings.Enabled = false;
                btnSettings.Visible = false;
            }
        }

        //private void DefaultForm()
        //{
        //    Forms.Status status = new Forms.Status();
        //    status.Show();
        //}

        private void testTextBox()
        {
            //textBox1.Text = Forms.WebsitesSettings.
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Status(), sender);
        }

        private void btnManagePC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Managepc(), sender);
        }

        private void btnShutdownComputer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ShutdownComputer(), sender);
        }

        private void btnWebsites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Websites(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WebsitesSettings(), sender);
        }
    }
}
