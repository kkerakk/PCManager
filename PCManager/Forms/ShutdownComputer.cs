using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;// Collection
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation; //powershell
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class ShutdownComputer : Form
    {
        Helper helper = new Helper();
        private string action = "";
        public ShutdownComputer()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                if (String.IsNullOrEmpty(txtShutdownTime.Text))
                {
                    txtShutdownTime.Text = "0";
                }                
                int time = int.Parse(txtShutdownTime.Text);

                if (time == 0 || String.IsNullOrEmpty(time.ToString()))
                {
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz wyłączyć komputer?", "Wyłącz komputer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //ShutdownPC(time);
                        ManageShutdownPC(time);
                    }
                }
                if (time > 0)
                {
                    //ShutdownPC(time);
                    ManageShutdownPC(time);
                }
            }
        }

        private void ManageShutdownPC(int time)
        {
            switch (action)
            {
                case "Shutdown":
                    //MessageBox.Show("Shutdown");
                    helper.RunViaPowerShell("shutdown -a; shutdown -s -t", time);
                    break;
                case "Restart":
                    //MessageBox.Show("Restart");
                    helper.RunViaPowerShell("shutdown -a; shutdown -r -t", time);
                    break;
                case "Hibernate":
                    MessageBox.Show("Hibernate");
                    //helper.RunViaPowerShell($"shutdown -a; timeout {time} shutdown -h");
                    break;
                case "Log Off":
                    MessageBox.Show("Log Off");
                    break;
                default:
                    MessageBox.Show("Error occured");
                    break;
            }
        }

        private void ShutdownPC(int time)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", time);
        }

        private void RestartPC(int time)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -r -t", time);
        }

        private void btnCancelShutdown_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a");
        }
        private void txtShutdownTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #region InstantShutdownButtons
        private void btnShutdownInstant_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz wyłączyć komputer?", "Wyłącz komputer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //ShutdownPC(time);
                    helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 0);
                }
            }            
        }

        private void btnShutdown5min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 300);
        }

        private void btnShutdown10min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 600);
        }

        private void btnShutdown15min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 900);
        }

        private void btnShutdown30min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 1800);
        }

        private void btnShutdown60min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 3600);
        }

        private void btnShutdown120min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 7200);
        }

        private void btnShutdown180min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 10800);
        }

        private void btnShutdown240min_Click(object sender, EventArgs e)
        {
            helper.RunViaPowerShell("shutdown -a; shutdown -s -t", 14400);
        }
        #endregion
        #region radioButtons
        private void rbShutdown_CheckedChanged(object sender, EventArgs e)
        {
            action = rbShutdown.Text;
        }

        private void rbRestart_CheckedChanged(object sender, EventArgs e)
        {
            action = rbRestart.Text;
        }

        private void rbHibernate_CheckedChanged(object sender, EventArgs e)
        {
            action = rbHibernate.Text;
        }

        private void rbLogOff_CheckedChanged(object sender, EventArgs e)
        {
            action = rbLogOff.Text;
        }
        #endregion
    }
}
