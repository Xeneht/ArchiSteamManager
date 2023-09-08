using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArchiSteamManager
{
    public partial class Form1 : Form
    {
        // Constants for window dragging
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

            // Config paths definitions
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArchiSteamManager");
            configFile = Path.Combine(appDataPath, "config.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if the app config file exists
            if (ConfigFileExists() == false)
            {
                LogAction("No config file found. Starting setup...");
                Form2 form2 = new Form2();
                form2.Show();
                BeginInvoke(new MethodInvoker(delegate
                {
                    Hide();
                }));
            }
            else
            {
                // Read and parse the config file
                string configFileContent = File.ReadAllText(configFile);
                JObject configJson = JObject.Parse(configFileContent);
                string logFilePath = Path.Combine(appDataPath, "logs.txt");
                string timestamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                string logEntry = $"{Environment.NewLine}--------------------------------------------------{Environment.NewLine}";
                logEntry += $"ArchiSteamManager Started | {timestamp}{Environment.NewLine}";
                logEntry += $"--------------------------------------------------{Environment.NewLine}";
                logEntry += $"Config:{configJson}{Environment.NewLine}";
                logEntry += $"--------------------------------------------------{Environment.NewLine}";

                // Append log entry to the log file
                File.AppendAllText(logFilePath, logEntry);
            }
        }

        // Check if the app config file exists and if the saved folder in the config file exists
        private bool ConfigFileExists()
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

        // Get the Archi config file
        public string configFolderPath()
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);

            string savedFolder = configJson["Path"].ToString();
            string configFolderPath = Path.Combine(savedFolder, "config");
            return configFolderPath;
        }

        // Load the filename prefix from the config file
        private string LoadFileNamePrefix()
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);

            string FileName = configJson["FileName"].ToString();

            return FileName;
        }

        // Logging
        public void LogAction(string action, string filePath = "")
        {
            try
            {
                string logFilePath = Path.Combine(appDataPath, "logs.txt");
                string logEntry = $"{DateTime.Now} - {action} {filePath}";
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Error Logging
        public void LogError(string description, string errorMessage)
        {
            try
            {
                string logFilePath = Path.Combine(appDataPath, "logs.txt");
                string logEntry = $"{DateTime.Now} - {description}: {errorMessage}";
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering the error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Find the next available file number
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

        
        // Event handler for the Import button
        private void ImportButton_Click(object sender, EventArgs e)
        {
            // Disable buttons during import
            ImportButton.Enabled = false;
            exportButton.Enabled = false;
            removeDupesButton.Enabled = false;

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
                    // Read lines from the selected file
                    var lines = File.ReadAllLines(filePath);
                    int importedCount = 0;

                    string configFileContent = File.ReadAllText(configFile);
                    JObject configJson = JObject.Parse(configFileContent);
                    string prefix = LoadFileNamePrefix();

                    List<int> games = new List<int>();
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

                    var backgroundWorker = new BackgroundWorker();
                    backgroundWorker.WorkerReportsProgress = true;
                    backgroundWorker.DoWork += (bwSender, bwArgs) =>
                    {
                        progressBar.Maximum = lines.Length;
                        int localImportedCount = 0;
                        int nextBotNumber = FindNextBotNumber();

                        foreach (var line in lines)
                        {
                            var parts = line.Split(':');
                            if (parts.Length == 2)
                            {
                                string username = parts[0];
                                string password = parts[1];

                                int botNumber = nextBotNumber++;
                                int formatSelected = int.Parse(configJson["Format"].ToString()) + 1;
                                var data = new
                                {
                                    Enabled = true,
                                    GamesPlayedWhileIdle = games,
                                    SteamLogin = username,
                                    SteamPassword = password
                                };

                                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                                string filename = Path.Combine(configFolderPath(), $"{prefix}{botNumber.ToString().PadLeft(formatSelected, '0')}.json");
                                File.WriteAllText(filename, jsonData);

                                localImportedCount++;
                                progressBar.Value++;
                            }
                        }
                        importedCount = localImportedCount;
                    };

                    backgroundWorker.RunWorkerCompleted += async (bwSender, bwArgs) =>
                    {
                        await Task.Delay(50);

                        LogAction($"Imported {importedCount} accounts from", $"{filePath}");
                        MessageBox.Show($"Imported {importedCount} accounts");

                        progressBar.Maximum = 150;
                        for (int i = 150; i >= 0; i--)
                        {
                            progressBar.Value = i;
                            await Task.Delay(5);
                        }

                        // Enable buttons after import
                        ImportButton.Enabled = true;
                        exportButton.Enabled = true;
                        removeDupesButton.Enabled = true;
                    };

                    backgroundWorker.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    LogError("Error importing accounts", ex.Message);
                    MessageBox.Show($"An error occurred while importing accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the Export button
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
                                    LogError($"Error processing account in {botFile} during export", ex.Message);
                                }
                            }
                        }
                        LogAction($"Exported {uniqueAccounts.Count} accounts to", $"{exportFilePath}");
                        MessageBox.Show($"Exported {uniqueAccounts.Count} accounts", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        LogError($"Error exporting accounts", ex.Message);
                        MessageBox.Show($"An error occurred while exporting accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Settings button
        private void settingsButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterParent;
            form3.ShowDialog(this);
        }

        // Event handler for the Remove Duplicates
        private void removeDupesButton_Click(object sender, EventArgs e)
        {
            // Disable buttons during duplicate removal
            ImportButton.Enabled = false;
            exportButton.Enabled = false;
            removeDupesButton.Enabled = false;

            try
            {
                LoadFileNamePrefix();
                string prefix = LoadFileNamePrefix();
                var botFiles = Directory.GetFiles(configFolderPath(), $"{prefix}*.json");
                var uniqueAccounts = new HashSet<string>();

                string exportFilePath = Path.Combine(appDataPath, "exported_accounts.txt");

                var backgroundWorker = new BackgroundWorker();
                backgroundWorker.WorkerReportsProgress = true;

                backgroundWorker.DoWork += (bwSender, bwArgs) =>
                {
                    int totalFiles = botFiles.Length;
                    int processedFiles = 0;

                    foreach (var botFile in botFiles)
                    {
                        try
                        {
                            string jsonData = File.ReadAllText(botFile);
                            JObject botJson = JObject.Parse(jsonData);

                            string steamLogin = botJson["SteamLogin"]?.ToString();
                            string steamPassword = botJson["SteamPassword"]?.ToString();

                            if (!string.IsNullOrEmpty(steamLogin) && !string.IsNullOrEmpty(steamPassword))
                            {
                                string accountLine = $"{steamLogin}:{steamPassword}";
                                if (!uniqueAccounts.Contains(accountLine))
                                {
                                    using (var writer = new StreamWriter(exportFilePath, true))
                                    {
                                        writer.WriteLine(accountLine);
                                    }
                                    uniqueAccounts.Add(accountLine);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogError($"Error processing account in {botFile} during export", ex.Message);
                        }

                        processedFiles++;
                        int progressPercentage = (int)(((double)processedFiles / totalFiles) * 100);
                        backgroundWorker.ReportProgress(progressPercentage);
                    }
                };

                backgroundWorker.ProgressChanged += (bwSender, bwArgs) =>
                {
                    progressBar.Value = bwArgs.ProgressPercentage;
                };

                backgroundWorker.RunWorkerCompleted += async (bwSender, bwArgs) =>
                {
                // Delete original bot files
                foreach (var botFile in botFiles)
                {
                    File.Delete(botFile);
                }

                // Import unique accounts from the exported accounts
                ImportAccounts(exportFilePath, prefix);

                progressBar.Maximum = 150;
                progressBar.Value = 150;
                MessageBox.Show($"Unique Accounts: {uniqueAccounts.Count}\nRemoved Duplicates: {botFiles.Length - uniqueAccounts.Count}", "Operation Completed");
                LogAction("Remove Duplicates Completed |", $"Unique Accounts: {uniqueAccounts.Count} | Removed Duplicates: {botFiles.Length - uniqueAccounts.Count}");
                    File.Delete(exportFilePath);
                    for (int i = 150; i >= 0; i--)
                    {
                        progressBar.Value = i;
                        await Task.Delay(5);
                    }

                    // Enable buttons after removing duplicates
                    ImportButton.Enabled = true;
                    exportButton.Enabled = true;
                    removeDupesButton.Enabled = true;
                };

                backgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                LogError("Error removing duplicates", ex.Message);
                MessageBox.Show($"An error occurred while removing duplicates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Import accounts from a file and create JSON files for them
        private void ImportAccounts(string importFilePath, string prefix)
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);
            int formatSelected = int.Parse(configJson["Format"].ToString()) + 1;
            var lines = File.ReadAllLines(importFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                var accountParts = lines[i].Split(':');
                if (accountParts.Length == 2)
                {
                    string username = accountParts[0];
                    string password = accountParts[1];
                    int botNumber = i + 1;

                    List<int> games = new List<int>();
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

                    string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                    string filename = Path.Combine(configFolderPath(), $"{prefix}{botNumber.ToString().PadLeft(formatSelected, '0')}.json");
                    File.WriteAllText(filename, jsonData);
                }
            }
        }

        // Minimize button
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // GitHub button
        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Xeneht");
        }
    }
}
