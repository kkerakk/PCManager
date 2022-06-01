﻿using System;
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
        public ShutdownComputer()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                int time = int.Parse(txtShutdownTime.Text);
                if (time == 0 || time.Equals(""))
                {
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz wyłączyć komputer?", "Wyłącz komputer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ShutdownPC(time);
                    }
                }
                if (time > 0)
                {
                    ShutdownPC(time);
                }
            }
        }
        void ShutdownPC(int time)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowershellInstance.AddScript($"shutdown -a; shutdown -r -t {time};");
                Collection<PSObject> PSOutput = PowershellInstance.Invoke();
            }
        }

        private void btnCancelShutdown_Click(object sender, EventArgs e)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowershellInstance.AddScript("shutdown -a");
                Collection<PSObject> PSOutput = PowershellInstance.Invoke();
            }
        }
    }
}
