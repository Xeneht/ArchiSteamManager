using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ArchiSteamManager
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private string appDataPath;
        private string configFile;

        public Form1()
        {
            InitializeComponent();
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArchiSteamManager");
            configFile = Path.Combine(appDataPath, "config.json");
        }

        private bool ConfigFolderExists()
        {
            if (File.Exists(configFile))
            {
                string configFileContent = File.ReadAllText(configFile);
                JObject configJson = JObject.Parse(configFileContent);

                string savedFolder = configJson["Path"].ToString();
                string configFolderPath = Path.Combine(savedFolder, "config");

                return Directory.Exists(configFolderPath);
            }
            return false;
        }

        private string configFolderPath()
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);

            string savedFolder = configJson["Path"].ToString();
            string configFolderPath = Path.Combine(savedFolder, "config");
            return configFolderPath;
        }

        private string LoadFileNamePrefix()
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);

            string FileName = configJson["FileName"].ToString();

            return FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConfigFolderExists() == false)
            {
                Form2 form2 = new Form2();
                form2.Show();
                BeginInvoke(new MethodInvoker(delegate
                {
                    Hide();
                }));
            }
            else
            {
            }
        }

        private void LogAction(string action, string filePath)
        {
            string logFilePath = Path.Combine(appDataPath, "logs.txt");
            string logEntry = $"{DateTime.Now} - {action} {filePath}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }

        private void LogError(string errorMessage)
        {
            string logFilePath = Path.Combine(appDataPath, "logs.txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    string logMessage = $"[Error - {DateTime.Now}] {errorMessage}";
                    writer.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering the error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int FindNextBotNumber()
        {
            string prefix = LoadFileNamePrefix();
            var accFiles = Directory.GetFiles(configFolderPath(), $"{prefix}*.json");
            if (accFiles.Length == 0)
                return 1;

            var numbers = accFiles
                .Select(file =>
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    var numberPart = fileName.Substring(prefix.Length);
                    int.TryParse(numberPart, out int number);
                    return number;
                })
                .Where(number => number > 0)
                .ToList();

            return numbers.Count > 0 ? numbers.Max() + 1 : 1;
        }

        private void CreateBotJson(string username, string password)
        {
            string prefix = LoadFileNamePrefix();
            int botNumber = FindNextBotNumber();
            string filename = Path.Combine(configFolderPath(), $"{prefix}{botNumber}.json");

            List<int> games = new List<int>();

            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);

            JArray gamesArray = configJson["Games"] as JArray;
            if (gamesArray != null)
            {
                foreach (var numToken in gamesArray)
                {
                    if (numToken.Type == JTokenType.Integer)
                    {
                        int num = (int)numToken;
                        games.Add(num);
                    }
                }
            }

            var data = new
            {
                Enabled = true,
                GamesPlayedWhileIdle = games,
                SteamLogin = username,
                SteamPassword = password
            };

            File.WriteAllText(filename, JsonConvert.SerializeObject(data, Formatting.Indented));
            LogAction("Created file", filename);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select account list";
                dialog.Filter = "Text files (*.txt)|*.txt";
                DialogResult result = dialog.ShowDialog();
                string filePath = dialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                try
                {
                    var lines = File.ReadAllLines(filePath);
                    int importedCount = 0;

                    foreach (var line in lines)
                    {
                        var parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            string username = parts[0];
                            string password = parts[1];
                            CreateBotJson(username, password);
                            importedCount++;
                        }
                    }
                    LogAction($"Imported {importedCount} accounts from", $"{filePath}");
                    MessageBox.Show($"Imported {importedCount} accounts");
                }
                catch (Exception ex)
                {
                    LogError($"Error importing accounts: {ex.Message}");
                    MessageBox.Show($"An error occurred while importing accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Save accounts file";
                dialog.Filter = "Text files (*.txt)|*.txt";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        string exportFilePath = dialog.FileName;
                        string configFolder = configFolderPath();

                        var botFiles = Directory.GetFiles(configFolder, "*.json");
                        HashSet<string> uniqueAccounts = new HashSet<string>();

                        using (StreamWriter writer = new StreamWriter(exportFilePath))
                        {
                            foreach (var botFile in botFiles)
                            {
                                try
                                {
                                    string jsonData = File.ReadAllText(botFile);
                                    JObject botJson = JObject.Parse(jsonData);
                                    throw new Exception("Simulated error during export");

                                    string steamLogin = botJson["SteamLogin"]?.ToString();
                                    string steamPassword = botJson["SteamPassword"]?.ToString();

                                    if (!string.IsNullOrEmpty(steamLogin) && !string.IsNullOrEmpty(steamPassword))
                                    {
                                        string accountLine = $"{steamLogin}:{steamPassword}";
                                        if (!uniqueAccounts.Contains(accountLine))
                                        {
                                            writer.WriteLine(accountLine);
                                            uniqueAccounts.Add(accountLine);
                                            LogAction($"Exported account from", $"{botFile}");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogError($"Error processing account in {botFile} during export: {ex.Message}");
                                }
                            }
                        }

                        MessageBox.Show("Accounts have been exported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogAction($"Exported {uniqueAccounts.Count} accounts to", $"{exportFilePath}");
                    }
                    catch (Exception ex)
                    {
                        LogError($"Error exporting accounts: {ex.Message}");
                        MessageBox.Show($"An error occurred while exporting accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void settingsButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterParent;
            form3.ShowDialog(this);
        }

        private void removeDupesButton_Click(object sender, EventArgs e)
        {
            LoadFileNamePrefix();
            string prefix = LoadFileNamePrefix();
            var botFiles = Directory.GetFiles(configFolderPath(), $"{prefix}*.json");
            var botData = new List<string>();

            foreach (var filename in botFiles)
            {
                string jsonData = File.ReadAllText(filename);
                botData.Add(jsonData);
            }

            var uniqueData = new HashSet<string>();
            var duplicateIndices = new List<int>();

            for (int i = 0; i < botData.Count; i++)
            {
                if (!uniqueData.Contains(botData[i]))
                {
                    uniqueData.Add(botData[i]);
                }
                else
                {
                    duplicateIndices.Add(i);
                }
            }

            foreach (var index in duplicateIndices.OrderByDescending(i => i))
            {
                string removedFilePath = botFiles[index];
                File.Delete(removedFilePath);
                LogAction("Removed duplicate", $"{removedFilePath}");
            }

            int uniqueCount = uniqueData.Count;
            int removedCount = duplicateIndices.Count;

            var remainingBotFiles = Directory.GetFiles(configFolderPath(), $"{prefix}*.json");
            var remainingBotNumbers = remainingBotFiles
                .Select(file => int.Parse(Regex.Match(file, @"\d+").Value))
                .OrderBy(number => number)
                .ToList();

            List<string> renamedFiles = new List<string>();
            for (int i = 0; i < remainingBotNumbers.Count; i++)
            {
                int newBotNumber = i + 1;
                if (remainingBotNumbers[i] != newBotNumber)
                {
                    string oldFilename = $"{prefix}{remainingBotNumbers[i]}.json";
                    string newFilename = $"{prefix}{newBotNumber}.json";
                    File.Move(Path.Combine(configFolderPath(), oldFilename), Path.Combine(configFolderPath(), newFilename));
                    renamedFiles.Add($"{oldFilename} to {newFilename}");
                    LogAction("Renamed File", $"{oldFilename} -> {newFilename}");
                }
            }

            string message = $"Unique Accounts: {uniqueCount}\nRemoved Duplicates: {removedCount}";
            MessageBox.Show(message, "Operation Completed");
            LogAction("Operation Completed", $"Unique Accounts: {uniqueCount} | Removed Duplicates: {removedCount}");
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Xeneht");
        }


    }
}