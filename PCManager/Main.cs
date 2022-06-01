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
        public Main()
        {
            InitializeComponent();
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

        private void OpenChildForm(Form childForm, object btnSender)
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
    }
}
