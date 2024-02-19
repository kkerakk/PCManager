using PCManager.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PCManager
{
    public partial class Main : Form
    {

        private Button currentButton;
        private Form activeForm;
        private static string formName;
        private static string path = "./../../Media/Temp.txt";
        private bool isPanelSizeChanged = false;
        
        public Main()
        {
            InitializeComponent();
            GetPasswordExpiration();
            ChangeMenuColor();
            TurnOffModules();
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
            if (activeForm != null && AppSettings.AppStatusModified == true)
            {
                DialogResult result = MessageBox.Show("Czy chcesz zamknąć obecne okno?", "Czy zamknąć okno?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
                activeForm.Close();
                AppSettings.AppStatusModified = false;
            }                
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
        }
        public void OpenWebsitesSettingsForm(object sender)
        {
            OpenChildForm(new WebsitesSettings(), sender);
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
        private void btnDataEncryption_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataEncryption(), sender);
        }
        private void btnAddressBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddressBook(), sender);
        }
        private void btnFileRename_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FileRename(), sender);
        }        
        private void btnNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Notes(), sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings(), sender);
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;

            if (keyData == Keys.F8)
            {
                if (isPanelSizeChanged)
                {
                    DefaultSizePanel();
                }
                else
                {
                    ChangeSizePanel();
                }

                isPanelSizeChanged = !isPanelSizeChanged;
                bHandled = true;
            }

            return bHandled;
        }
        private void ChangeSizePanel()
        {
            panelLeftMenu.Width = 38;
            foreach (Button button in panelLeftMenu.Controls)
            {
                button.Text = "";
            }
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
            btnDataEncryption.Text = "  Data Encrypt";
            btnAddressBook.Text = "  Address Book";
            btnFileRename.Text = " File Rename";
            btnNotes.Text = " File Rename";
            btnSettings.Text = " Settings";
        }
        private void ChangeMenuColor()
        {
            //#0de634 //green
            //#328df8 // jasnoniebieski
            //#252a34 //ciemny niebieski
            //#0C081A // mocno ciemny
            panelLeftMenu.BackColor = ColorTranslator.FromHtml("#2b2f3b");
            //panelDesktop.BackColor = ColorTranslator.FromHtml("#252a34");
            panelBottomMenu.BackColor = ColorTranslator.FromHtml("#2b2f3b");

            foreach (Button button in panelLeftMenu.Controls)
            {
                button.ForeColor = Color.White;
                button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#328df8");
            }
        }
        private void TurnOffModules()
        {
            btnTimer.Visible = false;
            btnDataEncryption.Visible = false;
            btnAddressBook.Visible = false;
            btnNotes.Visible = false;
        }
        private void btnWebsites_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenChildForm(new Websites(), sender);
            }
            else if (e.Button == MouseButtons.Right)
            {
                OpenChildForm(new WebsitesSettings(), sender);
            }
        }
    }
}
