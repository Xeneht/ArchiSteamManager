namespace ArchiSteamManager
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pathTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.changePathButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.changeGamesButton = new Guna.UI2.WinForms.Guna2Button();
            this.gamesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.changeNameButton = new Guna.UI2.WinForms.Guna2Button();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.resetConfigButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearLogsButton = new Guna.UI2.WinForms.Guna2Button();
            this.openLogs = new Guna.UI2.WinForms.Guna2Button();
            this.filesHelp = new System.Windows.Forms.PictureBox();
            this.gamesHelp = new System.Windows.Forms.PictureBox();
            this.removeAllAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.formatDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.formatHelp = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filesHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(15, 25);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(333, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Animated = true;
            this.pathTextBox.BorderRadius = 3;
            this.pathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathTextBox.DefaultText = "";
            this.pathTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathTextBox.FillColor = System.Drawing.Color.Transparent;
            this.pathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pathTextBox.ForeColor = System.Drawing.Color.Silver;
            this.pathTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.pathTextBox.Location = new System.Drawing.Point(15, 61);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.PasswordChar = '\0';
            this.pathTextBox.PlaceholderText = "";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.SelectedText = "";
            this.pathTextBox.Size = new System.Drawing.Size(221, 25);
            this.pathTextBox.TabIndex = 2;
            this.pathTextBox.TabStop = false;
            this.pathTextBox.Load += new System.EventHandler(this.pathTextBox_Load);
            // 
            // changePathButton
            // 
            this.changePathButton.Animated = true;
            this.changePathButton.BorderColor = System.Drawing.Color.DimGray;
            this.changePathButton.BorderRadius = 5;
            this.changePathButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePathButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePathButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePathButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePathButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.changePathButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.changePathButton.ForeColor = System.Drawing.Color.White;
            this.changePathButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.changePathButton.Location = new System.Drawing.Point(242, 61);
            this.changePathButton.Name = "changePathButton";
            this.changePathButton.Size = new System.Drawing.Size(106, 25);
            this.changePathButton.TabIndex = 12;
            this.changePathButton.Text = "Change";
            this.changePathButton.Click += new System.EventHandler(this.changePathButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ArchiSteamFarm Path";
            // 
            // closeButton
            // 
            this.closeButton.Animated = true;
            this.closeButton.BorderColor = System.Drawing.Color.DimGray;
            this.closeButton.BorderRadius = 5;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.closeButton.Location = new System.Drawing.Point(15, 320);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(333, 31);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Games List";
            // 
            // changeGamesButton
            // 
            this.changeGamesButton.Animated = true;
            this.changeGamesButton.BorderColor = System.Drawing.Color.DimGray;
            this.changeGamesButton.BorderRadius = 5;
            this.changeGamesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeGamesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeGamesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeGamesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeGamesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.changeGamesButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.changeGamesButton.ForeColor = System.Drawing.Color.White;
            this.changeGamesButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.changeGamesButton.Location = new System.Drawing.Point(242, 114);
            this.changeGamesButton.Name = "changeGamesButton";
            this.changeGamesButton.Size = new System.Drawing.Size(106, 25);
            this.changeGamesButton.TabIndex = 16;
            this.changeGamesButton.Text = "Apply";
            this.changeGamesButton.Click += new System.EventHandler(this.changeGamesButton_Click);
            // 
            // gamesTextBox
            // 
            this.gamesTextBox.Animated = true;
            this.gamesTextBox.BorderRadius = 3;
            this.gamesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gamesTextBox.DefaultText = "";
            this.gamesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gamesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gamesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gamesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gamesTextBox.FillColor = System.Drawing.Color.Transparent;
            this.gamesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gamesTextBox.ForeColor = System.Drawing.Color.Silver;
            this.gamesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.gamesTextBox.Location = new System.Drawing.Point(15, 114);
            this.gamesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gamesTextBox.MaxLength = 100;
            this.gamesTextBox.Name = "gamesTextBox";
            this.gamesTextBox.PasswordChar = '\0';
            this.gamesTextBox.PlaceholderText = "";
            this.gamesTextBox.SelectedText = "";
            this.gamesTextBox.Size = new System.Drawing.Size(221, 25);
            this.gamesTextBox.TabIndex = 15;
            this.gamesTextBox.TabStop = false;
            this.gamesTextBox.Load += new System.EventHandler(this.gamesTextBox_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Files Name";
            // 
            // changeNameButton
            // 
            this.changeNameButton.Animated = true;
            this.changeNameButton.BorderColor = System.Drawing.Color.DimGray;
            this.changeNameButton.BorderRadius = 5;
            this.changeNameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeNameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeNameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeNameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeNameButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.changeNameButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.changeNameButton.ForeColor = System.Drawing.Color.White;
            this.changeNameButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.changeNameButton.Location = new System.Drawing.Point(242, 167);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(106, 25);
            this.changeNameButton.TabIndex = 20;
            this.changeNameButton.Text = "Apply";
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Animated = true;
            this.nameTextBox.BorderRadius = 3;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FillColor = System.Drawing.Color.Transparent;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.nameTextBox.Location = new System.Drawing.Point(15, 167);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.MaxLength = 16;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(221, 25);
            this.nameTextBox.TabIndex = 19;
            this.nameTextBox.TabStop = false;
            this.nameTextBox.Load += new System.EventHandler(this.nameTextBox_Load);
            // 
            // resetConfigButton
            // 
            this.resetConfigButton.Animated = true;
            this.resetConfigButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.resetConfigButton.BorderRadius = 5;
            this.resetConfigButton.BorderThickness = 1;
            this.resetConfigButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetConfigButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetConfigButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetConfigButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetConfigButton.FillColor = System.Drawing.Color.Transparent;
            this.resetConfigButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.resetConfigButton.ForeColor = System.Drawing.Color.White;
            this.resetConfigButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.resetConfigButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.resetConfigButton.Location = new System.Drawing.Point(15, 254);
            this.resetConfigButton.Name = "resetConfigButton";
            this.resetConfigButton.Size = new System.Drawing.Size(106, 27);
            this.resetConfigButton.TabIndex = 23;
            this.resetConfigButton.Text = "Reset Config";
            this.resetConfigButton.Click += new System.EventHandler(this.resetConfigButton_Click);
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.Animated = true;
            this.clearLogsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.clearLogsButton.BorderRadius = 5;
            this.clearLogsButton.BorderThickness = 1;
            this.clearLogsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearLogsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearLogsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearLogsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearLogsButton.FillColor = System.Drawing.Color.Transparent;
            this.clearLogsButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.clearLogsButton.ForeColor = System.Drawing.Color.White;
            this.clearLogsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.clearLogsButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.clearLogsButton.Location = new System.Drawing.Point(242, 254);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(105, 27);
            this.clearLogsButton.TabIndex = 24;
            this.clearLogsButton.Text = "Clear Logs";
            this.clearLogsButton.Click += new System.EventHandler(this.clearLogsButton_Click);
            // 
            // openLogs
            // 
            this.openLogs.Animated = true;
            this.openLogs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.openLogs.BorderRadius = 5;
            this.openLogs.BorderThickness = 1;
            this.openLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openLogs.FillColor = System.Drawing.Color.Transparent;
            this.openLogs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.openLogs.ForeColor = System.Drawing.Color.White;
            this.openLogs.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.openLogs.HoverState.ForeColor = System.Drawing.Color.White;
            this.openLogs.Location = new System.Drawing.Point(131, 254);
            this.openLogs.Name = "openLogs";
            this.openLogs.Size = new System.Drawing.Size(101, 27);
            this.openLogs.TabIndex = 25;
            this.openLogs.Text = "Open Logs";
            this.openLogs.Click += new System.EventHandler(this.openLogs_Click);
            // 
            // filesHelp
            // 
            this.filesHelp.BackgroundImage = global::ArchiSteamManager.Properties.Resources.helpIcon;
            this.filesHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filesHelp.Location = new System.Drawing.Point(70, 147);
            this.filesHelp.Name = "filesHelp";
            this.filesHelp.Size = new System.Drawing.Size(15, 15);
            this.filesHelp.TabIndex = 22;
            this.filesHelp.TabStop = false;
            this.filesHelp.MouseLeave += new System.EventHandler(this.filesHelp_MouseLeave);
            this.filesHelp.MouseHover += new System.EventHandler(this.filesHelp_MouseHover);
            // 
            // gamesHelp
            // 
            this.gamesHelp.BackgroundImage = global::ArchiSteamManager.Properties.Resources.helpIcon;
            this.gamesHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamesHelp.Location = new System.Drawing.Point(70, 94);
            this.gamesHelp.Name = "gamesHelp";
            this.gamesHelp.Size = new System.Drawing.Size(15, 15);
            this.gamesHelp.TabIndex = 18;
            this.gamesHelp.TabStop = false;
            this.gamesHelp.MouseLeave += new System.EventHandler(this.gamesHelp_MouseLeave);
            this.gamesHelp.MouseHover += new System.EventHandler(this.gamesHelp_MouseHover);
            // 
            // removeAllAccounts
            // 
            this.removeAllAccounts.Animated = true;
            this.removeAllAccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.removeAllAccounts.BorderRadius = 5;
            this.removeAllAccounts.BorderThickness = 1;
            this.removeAllAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeAllAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeAllAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeAllAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeAllAccounts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.removeAllAccounts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllAccounts.ForeColor = System.Drawing.Color.White;
            this.removeAllAccounts.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.removeAllAccounts.Location = new System.Drawing.Point(14, 287);
            this.removeAllAccounts.Name = "removeAllAccounts";
            this.removeAllAccounts.Size = new System.Drawing.Size(332, 27);
            this.removeAllAccounts.TabIndex = 26;
            this.removeAllAccounts.Text = "Remove All Accounts";
            this.removeAllAccounts.Click += new System.EventHandler(this.removeAllAccounts_Click);
            // 
            // formatDropDown
            // 
            this.formatDropDown.BackColor = System.Drawing.Color.Transparent;
            this.formatDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.formatDropDown.BorderRadius = 3;
            this.formatDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.formatDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatDropDown.FillColor = System.Drawing.Color.Transparent;
            this.formatDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.formatDropDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.formatDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.formatDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formatDropDown.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.formatDropDown.ItemHeight = 19;
            this.formatDropDown.Items.AddRange(new object[] {
            "Bot1",
            "Bot01",
            "Bot001",
            "Bot0001",
            "Bot00001"});
            this.formatDropDown.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.formatDropDown.Location = new System.Drawing.Point(15, 220);
            this.formatDropDown.Name = "formatDropDown";
            this.formatDropDown.Size = new System.Drawing.Size(333, 25);
            this.formatDropDown.TabIndex = 27;
            this.formatDropDown.SelectedIndexChanged += new System.EventHandler(this.formatDropDown_SelectedIndexChanged);
            // 
            // formatHelp
            // 
            this.formatHelp.BackgroundImage = global::ArchiSteamManager.Properties.Resources.helpIcon;
            this.formatHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.formatHelp.Location = new System.Drawing.Point(111, 201);
            this.formatHelp.Name = "formatHelp";
            this.formatHelp.Size = new System.Drawing.Size(15, 15);
            this.formatHelp.TabIndex = 29;
            this.formatHelp.TabStop = false;
            this.formatHelp.MouseLeave += new System.EventHandler(this.formatHelp_MouseLeave);
            this.formatHelp.MouseHover += new System.EventHandler(this.formatHelp_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(14, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Numeration Format";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(360, 363);
            this.Controls.Add(this.formatHelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.formatDropDown);
            this.Controls.Add(this.removeAllAccounts);
            this.Controls.Add(this.openLogs);
            this.Controls.Add(this.clearLogsButton);
            this.Controls.Add(this.resetConfigButton);
            this.Controls.Add(this.filesHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gamesHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeGamesButton);
            this.Controls.Add(this.gamesTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changePathButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "ArchySteamManager";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            ((System.ComponentModel.ISupportInitialize)(this.filesHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox pathTextBox;
        private Guna.UI2.WinForms.Guna2Button changePathButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button changeGamesButton;
        private Guna.UI2.WinForms.Guna2TextBox gamesTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox gamesHelp;
        private System.Windows.Forms.PictureBox filesHelp;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button changeNameButton;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.ToolTip toolTip2;
        private Guna.UI2.WinForms.Guna2Button resetConfigButton;
        private Guna.UI2.WinForms.Guna2Button clearLogsButton;
        private Guna.UI2.WinForms.Guna2Button openLogs;
        private Guna.UI2.WinForms.Guna2Button removeAllAccounts;
        private Guna.UI2.WinForms.Guna2ComboBox formatDropDown;
        private System.Windows.Forms.PictureBox formatHelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}