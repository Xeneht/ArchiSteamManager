using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ArchiSteamManager
{
    public partial class Form2 : Form
    {
        private string appDataPath;
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

        public Form2()
        {
            InitializeComponent();
            // Start app config vars
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArchiSteamManager");
            configFile = Path.Combine(appDataPath, "config.json");
        }

        // Config setup
        public void SelectFolder(int form)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select ArchiSteamFarm Folder";

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    if (Directory.Exists(Path.Combine(dialog.SelectedPath, "config")))
                    {
                        if (!Directory.Exists(appDataPath))
                        {
                            Directory.CreateDirectory(appDataPath);
                        }

                        string selectedPath = dialog.SelectedPath;
                        string configFilePath = Path.Combine(appDataPath, "config.json");

                        var configData = new
                        {
                            Path = selectedPath,
                            Games = new int[] { 730 },
                            FileName = "Bot",
                            Format = 3
                        };

                        // Create the config file with default values and selected path
                        File.WriteAllText(configFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(configData, Newtonsoft.Json.Formatting.Indented));

                        if (form == 2)
                        {
                            this.Close();
                            Form1 form1 = new Form1();
                            form1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid folder. Select ArchiSteamFarm folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SelectFolder(2);
                    }
                }
            }
        }

        // Setup button
        private void SetupButton_Click(object sender, EventArgs e)
        {
            // Call SelectFolder method to initiate the setup process
            SelectFolder(2);
        }

        // Minimize button
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}