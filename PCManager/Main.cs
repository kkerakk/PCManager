using PCManager.Forms;
using System;
using System.Windows.Forms;

namespace PCManager
{
    public partial class Main : Form
    {
        //Forms.Helper helper = new Forms.Helper();

        private Button currentButton;
        private Form activeForm;
        private static string formName;
        private static string path = "./../../Media/Temp.txt";
        public Main()
        {
            InitializeComponent();
            GetPasswordExpiration();
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
                btnSettingss.Enabled = true;
                btnSettingss.Visible = true;
            }
            else
            {
                btnSettingss.Enabled = false;
                btnSettingss.Visible = false;
            }

            lblMessageInfo.ForeColor = lblMessageInfo.BackColor;
        }
        private void GetPasswordExpiration()
        {
            string str = Helper.RunViaPowerShell($"(net user /domain $env:UserName | Select -Index 11).Substring(35,10) | Set-Content -Path {path}", true);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Status(), sender);
        }

        private void btnManagePC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Managepc(), sender);
        }

        private void btnShutdownComputer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShutdownComputer(), sender);
        }

        private void btnWebsites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Websites(), sender);
        }

        private void btnSettingss_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WebsitesSettings(), sender);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Timer(), sender);
        }
        private void btnSyllabus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Syllabus(), sender);
        }
        private void btnXmlReader_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XmlReader(), sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings(), sender);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            switch (keyData)
            {
                case Keys.F7:
                    ChangeSizePanel();
                    bHandled = true;
                    break;
                case Keys.F8:
                    DefaultSizePanel();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }
        private void ChangeSizePanel()
        {
            panelLeftMenu.Width = 35;
            ////nie działa :(
            //foreach (Button button in panelLeftMenu.Controls)
            //{
            //    //button.Text = "";
            //}
            btnStatus.Text = "";
            btnManagePC.Text = "";
            btnShutdownComputer.Text = "";
            btnWebsites.Text = "";
            btnTimer.Text = "";
            btnSyllabus.Text = "";
            btnXmlReader.Text = "";
            btnSettings.Text = "";
        }
        private void DefaultSizePanel()
        {
            panelLeftMenu.Width = 150;

            btnStatus.Text = "  Status";
            btnManagePC.Text = "  Manage PC";
            btnShutdownComputer.Text = "  Shutdown PC";
            btnWebsites.Text = "  Websites";
            btnTimer.Text = "  Timer";
            btnSyllabus.Text = "  Syllabus";
            btnXmlReader.Text = "  XML Reader";
            btnSettings.Text = "  Settings";
        }
    }
}
