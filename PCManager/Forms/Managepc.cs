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
            RunViaCMD("cmd");
        }
        private void btnPowershell_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin("powershell");
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            RunViaCMD("services.msc");
        }
        private void btnPowerSupply_Click(object sender, EventArgs e)
        {
            RunViaCMD("powercfg.cpl");
        }
        private void btnDeviceManager_Click(object sender, EventArgs e)
        {
            RunViaCMD("devmgmt.msc");
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
            RunViaCMD("cmd", "mstsc");
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
        private void RunViaCMD(string fileName)
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName = $@"C:\windows\system32\{fileName}";
                Process.Start(proc);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Błąd");
            }
        }
        private void RunViaCMD(string fileName, string argument)
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName = $@"C:\windows\system32\{fileName}.exe";
                proc.Arguments = $@"/c {argument}";
                Process.Start(proc);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
    }
}
