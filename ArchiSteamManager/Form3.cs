using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ArchiSteamManager
{
    public partial class Form3 : Form
    {
        private string configFile;

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

        public Form3()
        {
            InitializeComponent();
            configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArchiSteamManager", "config.json");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void pathTextBox_Load(object sender, EventArgs e)
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);
            string savedPath = configJson["Path"].ToString();
            pathTextBox.Text = savedPath;
        }

        private void changePathButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SelectFolder();
            pathTextBox_Load(sender, e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gamesTextBox_Load(object sender, EventArgs e)
        {
            try
            {
                string configFileContent = File.ReadAllText(configFile);
                JObject configJson = JObject.Parse(configFileContent);

                JArray gamesArray = configJson["Games"] as JArray;
                if (gamesArray != null)
                {
                    List<string> gameStrings = new List<string>();
                    foreach (var numToken in gamesArray)
                    {
                        if (numToken.Type == JTokenType.Integer)
                        {
                            int num = (int)numToken;
                            gameStrings.Add(num.ToString());
                        }
                    }
                    gamesTextBox.Text = string.Join(", ", gameStrings);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading games: " + ex.Message);
            }
        }

        private void changeGamesButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> gamesList = new List<int>();
                string[] gameValues = gamesTextBox.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string value in gameValues)
                {
                    if (int.TryParse(value, out int game))
                    {
                        gamesList.Add(game);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid game value: {value}");
                        return;
                    }
                }

                string configFileContent = File.ReadAllText(configFile);
                JObject configJson = JObject.Parse(configFileContent);

                configJson["Games"] = JArray.FromObject(gamesList);

                File.WriteAllText(configFile, configJson.ToString());

                gamesTextBox_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating games: " + ex.Message);
            }
        }

        private void nameTextBox_Load(object sender, EventArgs e)
        {
            string configFileContent = File.ReadAllText(configFile);
            JObject configJson = JObject.Parse(configFileContent);
            nameTextBox.Text = configJson["FileName"].ToString();
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string configFileContent = File.ReadAllText(configFile);
                JObject configJson = JObject.Parse(configFileContent);

                configJson["FileName"] = nameTextBox.Text;

                File.WriteAllText(configFile, configJson.ToString());

                nameTextBox_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating FileName: " + ex.Message);
            }
        }

        private void gamesHelp_MouseHover(object sender, EventArgs e)
        {
            Point mousePosition = PointToClient(MousePosition);
            toolTip1.Show("Add game ids separated by comma. You can find ids on https://steam.db", this, mousePosition.X - 10, mousePosition.Y - 30);
        }

        private void gamesHelp_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(label1);
        }

        private void filesHelp_MouseHover(object sender, EventArgs e)
        {
            Point mousePosition = PointToClient(MousePosition);
            toolTip2.Show("The name for the imported accounts files", this, mousePosition.X - 10, mousePosition.Y - 30);
        }

        private void filesHelp_MouseLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(label1);
        }

        private void resetConfigButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the config?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                // Delete the config file
                string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArchiSteamManager");
                string configFile = Path.Combine(appDataPath, "config.json");
                File.Delete(configFile);
                Application.Restart();
            }
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the log file?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                string logsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArchiSteamManager", "logs.txt");

                if (File.Exists(logsFilePath))
                {
                    File.Delete(logsFilePath);
                    MessageBox.Show("Log file deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The file doesn't exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}