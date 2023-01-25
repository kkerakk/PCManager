using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;//collection<psobject>
using System.Diagnostics;//process
using System.IO;
using System.Linq;
using System.Management.Automation;//powershell
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PCManager.Forms
{
    public static class Helper
    {
        public static void RunViaCMD(string fileName)
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName = $@"C:\windows\system32\{fileName}";
                Process.Start(proc);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        public static void RunViaCMD(string fileName, string argument, bool openConsole = false)
        {
            try
            {
                if (openConsole == true)
                {
                    ProcessStartInfo proc = new ProcessStartInfo();
                    proc.FileName = $@"C:\windows\system32\{fileName}.exe";
                    proc.Arguments = $@"/k {argument}";
                    Process.Start(proc);
                }
                else
                {
                    ProcessStartInfo proc = new ProcessStartInfo();
                    proc.FileName = $@"C:\windows\system32\{fileName}.exe";
                    proc.Arguments = $@"/c {argument}";
                    Process.Start(proc);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd");
            }
        }
        public static void RunViaPowerShell(string argument)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowershellInstance.AddScript($"{argument};");
                Collection<PSObject> PSOutput = PowershellInstance.Invoke();
            }
        }
        public static void RunViaPowerShell(string argument, int time)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowershellInstance.AddScript($"{argument} {time};");
                Collection<PSObject> PSOutput = PowershellInstance.Invoke();
            }
        }
        public static string RunViaPowerShell(string argument, bool getvalue)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowerShell ps = PowerShell.Create();
                ps.AddScript($"{argument};");
                string line = "";
                var results = ps.Invoke();

                foreach (var item in results)
                {
                    line = item.ToString();
                }
                return line;
            }
        }
        public static string LoadDataFromFile(string path)
        {
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //MessageBox.Show(line);
                    return line;
                }
            }
            return line;
        }
        public static void GetComputerComponentInfo(string varName, string varClass, Label label)
        {
            using (ManagementObjectSearcher win32Class = new ManagementObjectSearcher($"select {varName} from {varClass}"))
            {
                foreach (ManagementObject managementObject in win32Class.Get())
                {
                    if (managementObject[$"{varName}"] != null)
                    {
                        label.Text = managementObject[$"{varName}"].ToString();
                    }
                }
            }
        }
        public static void TestMsgPopUp(string variable)
        {
            MessageBox.Show($"{variable}", "Testing string");
        }
        public static void TestMsgPopUp(decimal variable)
        {
            MessageBox.Show($"{variable}","Testing decimal").ToString();
        }
        public static void SaveToJSON(object obj)        
        {
            var databaseName = "DataStorage.json";
            var directory = @".\..\..\Data\";
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            var filePath = Path.Combine(directory,databaseName);

            File.WriteAllText(filePath, json);
        }
        public static void ReadFromJSON()
        {

        }
    }
}