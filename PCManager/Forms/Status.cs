using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management; //ManagementObjectSearcher  //This namespace is used to work with WMI classes. For using this namespace add reference of System.Management.dll
using System.Net; //dns, IPAddress
using System.ServiceProcess; //serviceController
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            checkServiceStatus("dot3svc");
            GetHostName();
            GetComputerInfo();
        }
        private string checkServiceStatus(string service)
        {
            ServiceController sc = new ServiceController(service);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return txtCheckServiceStatus.Text = "Running";
                case ServiceControllerStatus.Stopped:
                    return txtCheckServiceStatus.Text = "Stopped";
                case ServiceControllerStatus.Paused:
                    return txtCheckServiceStatus.Text = "Paused";
                default:
                    return txtCheckServiceStatus.Text = "Status changing";
            }
        }
        private void GetHostName()
        {
            string hostname = Dns.GetHostName();
            txtHostname.Text = hostname;

            IPAddress[] iPAddresses = Dns.GetHostAddresses(hostname);
            foreach (var ipaddr in iPAddresses)
            {
                txtAddressIP.Text = ipaddr.ToString();
            }
        }

        private void GetComputerInfo()
        {
            using (ManagementObjectSearcher mos = new ManagementObjectSearcher("select Caption, OSArchitecture from Win32_OperatingSystem"))
            {
                foreach (ManagementObject managementObject in mos.Get())
                {
                    if (managementObject["Caption"] != null)
                    {
                        lblWindowsVersion.Text = managementObject["Caption"].ToString();
                    }
                    if (managementObject["OSArchitecture"] != null)
                    {
                        lblProcessorArchitecture.Text = managementObject["OSArchitecture"].ToString();
                    }
                }
            }
            using (ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select name from Win32_Processor"))
            {
                foreach (ManagementObject managementObject in win32Proc.Get())
                {
                    if (managementObject["Name"] != null)
                    {
                        lblProcessor.Text = managementObject["Name"].ToString();
                    }
                }
            }
        }
    }
}
