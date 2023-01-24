using System;
using System.Management; //ManagementObjectSearcher  //This namespace is used to work with WMI classes. For using this namespace add reference of System.Management.dll
using System.Net; //dns, IPAddress
using System.ServiceProcess; //serviceController
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Status : Form
    {

        static string pathTemp = @"./../../Media/temp.txt";
        public Status()
        {
            InitializeComponent();
            checkServiceStatus("dot3svc");
            GetHostName();
            GetComputerInfo();
            GetPasswordExpiration();
            GetRegisterKeyValue();
            GetDomainName();
        }
        private string checkServiceStatus(string service)
        {
            ServiceController sc = new ServiceController(service);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return txtCheckServiceStatus.Text = "Włączona";
                case ServiceControllerStatus.Stopped:
                    return txtCheckServiceStatus.Text = "Wyłączona";
                case ServiceControllerStatus.Paused:
                    return txtCheckServiceStatus.Text = "Zatrzymane";
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
            Helper.GetComputerComponentInfo("Caption","Win32_OperatingSystem",lblWindowsVersion);
            Helper.GetComputerComponentInfo("OSArchitecture", "Win32_OperatingSystem", lblProcessorArchitecture);

            string variable = "TotalPhysicalMemory";
            using (ManagementObjectSearcher win32Memory = new ManagementObjectSearcher($"select {variable} from Win32_ComputerSystem"))
            {
                foreach (ManagementObject managementObject in win32Memory.Get())
                {
                    if (managementObject[$"{variable}"] != null)
                    {
                        double Ram_bytes = Convert.ToDouble(managementObject["TotalPhysicalMemory"]);
                        double x = Math.Round(Ram_bytes, 1);
                        lblMemory.Text = (x / (1073741824)).ToString("00") + " GB";
                    }
                }
            }

            Helper.GetComputerComponentInfo("Name","Win32_Processor",lblProcessor);
        }

        private void GetPasswordExpiration()
        {
            string str = Helper.LoadDataFromFile(pathTemp);
            if (str != null)
                txtPasswordExpiration.Text = str;
        }        
        private void GetRegisterKeyValue()
        {
            //Pomoc zdalna - zezwalaj na połączenia Pomocy zdalnej z tym komputerem
            string digitRemoteAssist = Helper.RunViaPowerShell(@"Get-ItemPropertyValue -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Remote Assistance' -Name fAllowToGetHelp", true);
            if (digitRemoteAssist == "1")
                txtRemoteAssistance.Text = "Włączona";
            else
                txtRemoteAssistance.Text = "Wyłączona";

            //Pulpit zdalny - zezwalaj/nie zezwalaj na polaczenie zdalne z tym komputerem
            string digitRemoteDesktop = Helper.RunViaPowerShell(@"Get-ItemPropertyValue -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server' -Name fDenyTSConnections", true);
            if (digitRemoteDesktop == "0")
                txtRemoteDesktop.Text = "Włączona";
            else
                txtRemoteDesktop.Text = "Wyłączona";

            //Pulpit zdalny - zezwalaj na polaczenia tylko z komputerow, na ktorych pulpit zdalny jest uruchomiony z NLA
            string digitNLA = Helper.RunViaPowerShell(@"Get-ItemPropertyValue -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp' -Name UserAuthentication", true);
            if (digitNLA == "1")
                txtNetworkLevelAuth.Text = "Włączona";
            else
                txtNetworkLevelAuth.Text = "Wyłączona";

        }
        private void GetDomainName(string text = "=")
        {
            string tempText = Helper.RunViaPowerShell("Get-WmiObject -Namespace root\\cimv2 -Class Win32_ComputerSystem | Select Domain", true);
            string domainName = tempText.Substring(tempText.IndexOf(text) + 1);
            txtDomain.Text = domainName.Remove(domainName.Length-1);
        }
    }
}
