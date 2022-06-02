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

        private void btnCmd_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void btnPowershell_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin("powershell.exe");
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void btnPowerSupply_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg.cpl");
        }
        private void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
        private void btnSetWiredAutoconfig_Click(object sender, EventArgs e)
        {
            SetWiredAutoConfig();
        }
        void SetWiredAutoConfig()
        {
            ExecuteAsAdmin("D:/C#/ShutdownComputer/_additional/SetWiredAutoConfig.bat");
        }
    }
}
