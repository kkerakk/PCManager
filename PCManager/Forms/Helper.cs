using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;//collection<psobject>
using System.Diagnostics;//process
using System.IO;
using System.Linq;
using System.Management.Automation;//powershell
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    internal class Helper
    {
        public void RunViaCMD(string fileName)
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
        public void RunViaCMD(string fileName, string argument, bool openConsole = false)
        {
            try
            {
                if (true)
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
        public void RunViaPowerShell(string argument)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowershellInstance.AddScript($"{argument};");
                Collection<PSObject> PSOutput = PowershellInstance.Invoke();
            }
        }
        public void RunViaPowerShell(string argument, int time)
        {
            using (PowerShell PowershellInstance = PowerShell.Create())
            {
                PowershellInstance.AddScript($"{argument} {time};");
                Collection<PSObject> PSOutput = PowershellInstance.Invoke();
            }
        }
        public string RunViaPowerShell(string argument, bool getvalue)
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

        public string LoadDataFromFile(string path)
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
    }
}