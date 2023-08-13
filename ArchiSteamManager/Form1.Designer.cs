namespace ArchiSteamManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImportButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.removeDupesButton = new Guna.UI2.WinForms.Guna2Button();
            this.githubButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.exportButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.Animated = true;
            this.ImportButton.BorderColor = System.Drawing.Color.DimGray;
            this.ImportButton.BorderRadius = 10;
            this.ImportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ImportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ImportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ImportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ImportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.ImportButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.ImportButton.Location = new System.Drawing.Point(102, 201);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(242, 48);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Import Account List";
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.minimizeButton);
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(732, 25);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Animated = true;
            this.minimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.Image = global::ArchiSteamManager.Properties.Resources.minimizeIcon;
            this.minimizeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.Location = new System.Drawing.Point(682, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 8;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Animated = true;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.Image = global::ArchiSteamManager.Properties.Resources.closeIcon;
            this.closeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.closeButton.Location = new System.Drawing.Point(707, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 7;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // removeDupesButton
            // 
            this.removeDupesButton.Animated = true;
            this.removeDupesButton.BorderColor = System.Drawing.Color.DimGray;
            this.removeDupesButton.BorderRadius = 10;
            this.removeDupesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeDupesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeDupesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeDupesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeDupesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.removeDupesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.removeDupesButton.ForeColor = System.Drawing.Color.White;
            this.removeDupesButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.removeDupesButton.Location = new System.Drawing.Point(389, 201);
            this.removeDupesButton.Name = "removeDupesButton";
            this.removeDupesButton.Size = new System.Drawing.Size(242, 48);
            this.removeDupesButton.TabIndex = 10;
            this.removeDupesButton.Text = "Remove duplicates";
            this.removeDupesButton.Click += new System.EventHandler(this.removeDupesButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.Color.Transparent;
            this.githubButton.BackgroundImage = global::ArchiSteamManager.Properties.Resources.githubIcon;
            this.githubButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.githubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubButton.Location = new System.Drawing.Point(638, 377);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(38, 36);
            this.githubButton.TabIndex = 11;
            this.githubButton.TabStop = false;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Location = new System.Drawing.Point(682, 377);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(38, 36);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Animated = true;
            this.exportButton.BorderColor = System.Drawing.Color.DimGray;
            this.exportButton.BorderRadius = 10;
            this.exportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.exportButton.Location = new System.Drawing.Point(232, 273);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(242, 48);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Export Account List";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(732, 425);
            this.ControlBox = false;
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.removeDupesButton);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ImportButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchySteamManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.githubButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ImportButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button removeDupesButton;
        private System.Windows.Forms.PictureBox githubButton;
        private Guna.UI2.WinForms.Guna2Button exportButton;
    }
}

