using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
