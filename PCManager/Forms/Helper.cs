using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;//collection<psobject>
using System.Diagnostics;//process
using System.IO;
using System.Management.Automation;//powershell
using System.Management;
using System.Windows.Forms;
using Newtonsoft.Json;
using PCManager.Models;
using System.Linq;
using System.Text;
using System.Globalization;

namespace PCManager.Forms
{
    public static class Helper
    {
        public static List<DataStorage> dataStorages { get; set; } = new List<DataStorage>();

        static string databaseName = "DataStorage.json";
        static string directory = @".\..\..\Data\";
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
        public static void SaveToJSON(DataStorage ds)        
        {
            var filePath = Path.Combine(directory, databaseName);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Database json doesn't exist. You need to create new \"{databaseName}\" in location \"{directory }\"", "Database error");
                var jsonLocal = JsonConvert.SerializeObject(dataStorages, Formatting.Indented);
                File.WriteAllText(filePath, jsonLocal);
                MessageBox.Show($"Database \"{databaseName}\" was created in location \"{directory }\"", "Database created");
                return;
            }
            
            var jsonRead = File.ReadAllText(filePath);
            dataStorages = JsonConvert.DeserializeObject<List<DataStorage>>(jsonRead);

            dataStorages.Add(ds);

            var json = JsonConvert.SerializeObject(dataStorages, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public static void ReadFromJSON(ref List<DataStorage> dataStorages)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var filePath = Path.Combine(directory, databaseName);
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Database json doesn't exist");
                return;
            }
            var json = File.ReadAllText(filePath);
            dataStorages = JsonConvert.DeserializeObject<List<DataStorage>>(json);
        }
        public static bool CheckIfPathExist(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("The path is empty", "Path error");
                return false;
            }
            if (!Directory.Exists(path))
            {
                MessageBox.Show("The path doesn't exist", "Path error");
                return false;
            }
            return true;
        }
        public static bool YesNoPrompt(string text = "Are you sure you want to continue", string caption = "confirmation")
        {
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }
        public static string FirstLetterToUpper(this string input) => string.Concat(input[0].ToString().ToUpper(), input.Substring(1));
        public static string ReplaceSpaces(this string input, char replacement) => input.Replace(' ', replacement);
        public static string DeleteBeforeFirstSpace(this string input)
        {
            int index = input.IndexOf(' ');
            if (index == -1) // jeśli nie ma spacji w łańcuchu, zwracamy go w całości
                return input;
            else
                return input.Substring(index + 1);
        }
        public static string ReplacePolishCharacters(this string input)
        {
            input = input.Normalize(NormalizationForm.FormD); // zamiana liter na formę dekomponowaną
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark) // ignorujemy znaki diakrytyczne
                {
                    switch (c)
                    {
                        case 'ą': sb.Append('a'); break;
                        case 'ć': sb.Append('c'); break;
                        case 'ę': sb.Append('e'); break;
                        case 'ł': sb.Append('l'); break;
                        case 'ń': sb.Append('n'); break;
                        case 'ó': sb.Append('o'); break;
                        case 'ś': sb.Append('s'); break;
                        case 'ź': sb.Append('s'); break;
                        case 'ż': sb.Append('z'); break;
                        default: sb.Append(c); break;
                    }
                }
            }
            return sb.ToString();
        }        
    }
}