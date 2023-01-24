using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; //process
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Managepc : Form
    {
        public Managepc()
        {
            InitializeComponent();
        }
        private void ExecuteAsAdmin(string fileName)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("cmd", @"c: && cd C:\Users\%username%", true);
        }
        private void btnPowershell_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin("powershell");
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("services.msc");
        }
        private void btnPowerSupply_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("powercfg.cpl");
        }
        private void btnDeviceManager_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("devmgmt.msc");
        }
        private void btnSetWiredAutoconfig_Click(object sender, EventArgs e)
        {
            SetWiredAutoConfig();
        }
        private void SetWiredAutoConfig()
        {
            ExecuteAsAdmin("D:/C#/ShutdownComputer/_additional/SetWiredAutoConfig.bat");
        }
        private void btnRemoteDesktop_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("mstsc");
        }
        private void btnPing_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("cmd","ping www.wp.pl",true);
        }
        private void btnConnectionsFolder_Click(object sender, EventArgs e)
        {
            Helper.RunViaCMD("cmd", "start shell:ConnectionsFolder");
        }
    }
}
