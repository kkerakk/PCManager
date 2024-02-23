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
    public partial class RDP : Form
    {
        private readonly ConfigurationManager _configurationManager;
        public RDP(ConfigurationManager configurationManager)
        {
            _configurationManager = configurationManager;

            InitializeComponent();
            ChangeColor();
            
        }

        private void ChangeColor()
        {
            foreach (Button button in flpServers.Controls)
            {
                button.BackColor = ColorTranslator.FromHtml(_configurationManager.Configuration["appsettings:bcYellow"]);
            }
            foreach (Button button in flpUsers.Controls)
            {
                button.BackColor = ColorTranslator.FromHtml(_configurationManager.Configuration["appsettings:bcGreen"]);
            }
        }

        private void StartRemoteDesktopConnection(string ipAddress)
        {
            try
            {
                using (Process rdpProcess = new Process())
                {
                    rdpProcess.StartInfo.FileName = "mstsc.exe";
                    rdpProcess.StartInfo.Arguments = $"/v:{ipAddress}";

                    rdpProcess.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void btnS01_Click(object sender, EventArgs e)
        {
            StartRemoteDesktopConnection("192.168.65.100");
        }

        private void btnS02_Click(object sender, EventArgs e)
        {

        }

        private void btnU01_Click(object sender, EventArgs e)
        {

        }

        private void btnU02_Click(object sender, EventArgs e)
        {

        }

        private void btnU03_Click(object sender, EventArgs e)
        {

        }
    }
}
