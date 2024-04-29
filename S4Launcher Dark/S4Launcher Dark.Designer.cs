namespace S4Launcher_Dark
{
    partial class S4LauncherDark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S4LauncherDark));
            this.NOTICE1 = new System.Windows.Forms.WebBrowser();
            this.VersionLauncherNotes = new System.Windows.Forms.WebBrowser();
            this.PatcherClient = new System.ComponentModel.BackgroundWorker();
            this.btnStart_1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.PLAYCOMPLETE = new System.Windows.Forms.PictureBox();
            this.DOWNLOADUPDATES = new System.Windows.Forms.PictureBox();
            this.bg_launcher = new System.Windows.Forms.PictureBox();
            this.lblspa = new System.Windows.Forms.Label();
            this.lbleng = new System.Windows.Forms.Label();
            this.SPA = new System.Windows.Forms.PictureBox();
            this.USA = new System.Windows.Forms.PictureBox();
            this.SPA_1 = new System.Windows.Forms.PictureBox();
            this.USA_1 = new System.Windows.Forms.PictureBox();
            this.patchNotes = new System.Windows.Forms.WebBrowser();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblFileDownloadVersion = new System.Windows.Forms.Label();
            this.pbDownload = new ProgressBarEx();
            this.pbInstall = new ProgressBarEx();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYCOMPLETE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOWNLOADUPDATES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_launcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // NOTICE1
            // 
            this.NOTICE1.AllowNavigation = false;
            this.NOTICE1.AllowWebBrowserDrop = false;
            this.NOTICE1.IsWebBrowserContextMenuEnabled = false;
            this.NOTICE1.Location = new System.Drawing.Point(343, 34);
            this.NOTICE1.MinimumSize = new System.Drawing.Size(20, 20);
            this.NOTICE1.Name = "NOTICE1";
            this.NOTICE1.ScriptErrorsSuppressed = true;
            this.NOTICE1.ScrollBarsEnabled = false;
            this.NOTICE1.Size = new System.Drawing.Size(465, 218);
            this.NOTICE1.TabIndex = 29;
            this.NOTICE1.Url = new System.Uri("http://s4ldark.dynv6.net/Game/Notice/index.php", System.UriKind.Absolute);
            this.NOTICE1.WebBrowserShortcutsEnabled = false;
            // 
            // VersionLauncherNotes
            // 
            this.VersionLauncherNotes.AllowNavigation = false;
            this.VersionLauncherNotes.AllowWebBrowserDrop = false;
            this.VersionLauncherNotes.IsWebBrowserContextMenuEnabled = false;
            this.VersionLauncherNotes.Location = new System.Drawing.Point(105, 73);
            this.VersionLauncherNotes.MinimumSize = new System.Drawing.Size(20, 20);
            this.VersionLauncherNotes.Name = "VersionLauncherNotes";
            this.VersionLauncherNotes.ScriptErrorsSuppressed = true;
            this.VersionLauncherNotes.ScrollBarsEnabled = false;
            this.VersionLauncherNotes.Size = new System.Drawing.Size(29, 23);
            this.VersionLauncherNotes.TabIndex = 39;
            this.VersionLauncherNotes.Url = new System.Uri("http://s4ldark.dynv6.net/Game/Patchs/VersionLauncher/", System.UriKind.Absolute);
            this.VersionLauncherNotes.Visible = false;
            this.VersionLauncherNotes.WebBrowserShortcutsEnabled = false;
            // 
            // PatcherClient
            // 
            this.PatcherClient.WorkerReportsProgress = true;
            this.PatcherClient.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PatcherClient_DoWork);
            this.PatcherClient.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PatcherClient_ProgressChanged);
            this.PatcherClient.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PatcherClient_Completed);
            // 
            // btnStart_1
            // 
            this.btnStart_1.BackColor = System.Drawing.Color.Transparent;
            this.btnStart_1.Image = global::S4Launcher_Dark.Properties.Resources.Start_1_1;
            this.btnStart_1.Location = new System.Drawing.Point(64, 184);
            this.btnStart_1.Name = "btnStart_1";
            this.btnStart_1.Size = new System.Drawing.Size(222, 215);
            this.btnStart_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart_1.TabIndex = 44;
            this.btnStart_1.TabStop = false;
            this.btnStart_1.Visible = false;
            this.btnStart_1.Click += new System.EventHandler(this.BtnStart_1_Click);
            this.btnStart_1.MouseLeave += new System.EventHandler(this.BtnStart_1_MouseLeave);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Image = global::S4Launcher_Dark.Properties.Resources.Start_0_0_0;
            this.btnStart.Location = new System.Drawing.Point(64, 184);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(222, 215);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 43;
            this.btnStart.TabStop = false;
            this.btnStart.MouseHover += new System.EventHandler(this.BtnStart_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::S4Launcher_Dark.Properties.Resources.Exit;
            this.btnClose.Location = new System.Drawing.Point(789, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 42;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PLAYCOMPLETE
            // 
            this.PLAYCOMPLETE.BackColor = System.Drawing.Color.Transparent;
            this.PLAYCOMPLETE.Cursor = System.Windows.Forms.Cursors.Default;
            this.PLAYCOMPLETE.Image = global::S4Launcher_Dark.Properties.Resources.PLAY_GAME;
            this.PLAYCOMPLETE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PLAYCOMPLETE.Location = new System.Drawing.Point(350, 329);
            this.PLAYCOMPLETE.Name = "PLAYCOMPLETE";
            this.PLAYCOMPLETE.Size = new System.Drawing.Size(96, 15);
            this.PLAYCOMPLETE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PLAYCOMPLETE.TabIndex = 28;
            this.PLAYCOMPLETE.TabStop = false;
            this.PLAYCOMPLETE.Visible = false;
            // 
            // DOWNLOADUPDATES
            // 
            this.DOWNLOADUPDATES.BackColor = System.Drawing.Color.Transparent;
            this.DOWNLOADUPDATES.Cursor = System.Windows.Forms.Cursors.Default;
            this.DOWNLOADUPDATES.Image = global::S4Launcher_Dark.Properties.Resources.DOWNLOAD_UPDATES;
            this.DOWNLOADUPDATES.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DOWNLOADUPDATES.Location = new System.Drawing.Point(493, 329);
            this.DOWNLOADUPDATES.Name = "DOWNLOADUPDATES";
            this.DOWNLOADUPDATES.Size = new System.Drawing.Size(206, 15);
            this.DOWNLOADUPDATES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DOWNLOADUPDATES.TabIndex = 27;
            this.DOWNLOADUPDATES.TabStop = false;
            this.DOWNLOADUPDATES.Visible = false;
            // 
            // bg_launcher
            // 
            this.bg_launcher.BackColor = System.Drawing.Color.Transparent;
            this.bg_launcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_launcher.Image = global::S4Launcher_Dark.Properties.Resources.bg_launcher24;
            this.bg_launcher.Location = new System.Drawing.Point(0, 0);
            this.bg_launcher.Name = "bg_launcher";
            this.bg_launcher.Size = new System.Drawing.Size(814, 420);
            this.bg_launcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_launcher.TabIndex = 0;
            this.bg_launcher.TabStop = false;
            this.bg_launcher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bg_launcher_MouseDown);
            this.bg_launcher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bg_launcher_MouseMove);
            this.bg_launcher.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bg_launcher_MouseUp);
            // 
            // lblspa
            // 
            this.lblspa.AutoSize = true;
            this.lblspa.Enabled = false;
            this.lblspa.Location = new System.Drawing.Point(23, 48);
            this.lblspa.Name = "lblspa";
            this.lblspa.Size = new System.Drawing.Size(24, 13);
            this.lblspa.TabIndex = 45;
            this.lblspa.Text = "spa";
            this.lblspa.Visible = false;
            // 
            // lbleng
            // 
            this.lbleng.AutoSize = true;
            this.lbleng.Enabled = false;
            this.lbleng.Location = new System.Drawing.Point(73, 48);
            this.lbleng.Name = "lbleng";
            this.lbleng.Size = new System.Drawing.Size(25, 13);
            this.lbleng.TabIndex = 46;
            this.lbleng.Text = "eng";
            this.lbleng.Visible = false;
            // 
            // SPA
            // 
            this.SPA.BackColor = System.Drawing.Color.Black;
            this.SPA.Cursor = System.Windows.Forms.Cursors.Default;
            this.SPA.Image = global::S4Launcher_Dark.Properties.Resources.SPA;
            this.SPA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SPA.Location = new System.Drawing.Point(12, 7);
            this.SPA.Name = "SPA";
            this.SPA.Size = new System.Drawing.Size(44, 38);
            this.SPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SPA.TabIndex = 48;
            this.SPA.TabStop = false;
            this.SPA.Click += new System.EventHandler(this.SPA_Click);
            // 
            // USA
            // 
            this.USA.BackColor = System.Drawing.Color.Black;
            this.USA.Cursor = System.Windows.Forms.Cursors.Default;
            this.USA.Image = global::S4Launcher_Dark.Properties.Resources.USA;
            this.USA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.USA.Location = new System.Drawing.Point(64, 7);
            this.USA.Name = "USA";
            this.USA.Size = new System.Drawing.Size(43, 38);
            this.USA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USA.TabIndex = 47;
            this.USA.TabStop = false;
            this.USA.Click += new System.EventHandler(this.USA_Click);
            // 
            // SPA_1
            // 
            this.SPA_1.BackColor = System.Drawing.Color.Black;
            this.SPA_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.SPA_1.Image = global::S4Launcher_Dark.Properties.Resources.SPA_1;
            this.SPA_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SPA_1.Location = new System.Drawing.Point(12, 7);
            this.SPA_1.Name = "SPA_1";
            this.SPA_1.Size = new System.Drawing.Size(44, 38);
            this.SPA_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SPA_1.TabIndex = 50;
            this.SPA_1.TabStop = false;
            this.SPA_1.Visible = false;
            // 
            // USA_1
            // 
            this.USA_1.BackColor = System.Drawing.Color.Black;
            this.USA_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.USA_1.Image = global::S4Launcher_Dark.Properties.Resources.USA_1;
            this.USA_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.USA_1.Location = new System.Drawing.Point(64, 7);
            this.USA_1.Name = "USA_1";
            this.USA_1.Size = new System.Drawing.Size(43, 38);
            this.USA_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USA_1.TabIndex = 49;
            this.USA_1.TabStop = false;
            this.USA_1.Visible = false;
            // 
            // patchNotes
            // 
            this.patchNotes.AllowNavigation = false;
            this.patchNotes.AllowWebBrowserDrop = false;
            this.patchNotes.IsWebBrowserContextMenuEnabled = false;
            this.patchNotes.Location = new System.Drawing.Point(76, 122);
            this.patchNotes.MinimumSize = new System.Drawing.Size(20, 20);
            this.patchNotes.Name = "patchNotes";
            this.patchNotes.ScriptErrorsSuppressed = true;
            this.patchNotes.ScrollBarsEnabled = false;
            this.patchNotes.Size = new System.Drawing.Size(29, 23);
            this.patchNotes.TabIndex = 51;
            this.patchNotes.Url = new System.Uri("http://s4ldark.dynv6.net/Game/Patchs/", System.UriKind.Absolute);
            this.patchNotes.Visible = false;
            this.patchNotes.WebBrowserShortcutsEnabled = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimized.Image = global::S4Launcher_Dark.Properties.Resources.minimized;
            this.btnMinimized.Location = new System.Drawing.Point(763, -4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(29, 28);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimized.TabIndex = 52;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Visible = false;
            this.btnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(183, 85);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(16, 13);
            this.lblIp.TabIndex = 55;
            this.lblIp.Text = "Ip";
            this.lblIp.Visible = false;
            // 
            // lblFileDownloadVersion
            // 
            this.lblFileDownloadVersion.AutoSize = true;
            this.lblFileDownloadVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblFileDownloadVersion.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDownloadVersion.ForeColor = System.Drawing.Color.Moccasin;
            this.lblFileDownloadVersion.Location = new System.Drawing.Point(346, 320);
            this.lblFileDownloadVersion.Name = "lblFileDownloadVersion";
            this.lblFileDownloadVersion.Size = new System.Drawing.Size(340, 24);
            this.lblFileDownloadVersion.TabIndex = 58;
            this.lblFileDownloadVersion.Text = "[Error] - Falied to download version.ini";
            this.lblFileDownloadVersion.Visible = false;
            // 
            // pbDownload
            // 
            this.pbDownload.BackColor = System.Drawing.Color.Transparent;
            this.pbDownload.BackgroundColor = System.Drawing.Color.Black;
            this.pbDownload.BorderColor = System.Drawing.Color.Navy;
            this.pbDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbDownload.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbDownload.GradiantColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbDownload.GradiantPosition = ProgressBarEx.GradiantArea.Center;
            this.pbDownload.Image = null;
            this.pbDownload.Location = new System.Drawing.Point(350, 350);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.ProgressColor = System.Drawing.Color.MediumBlue;
            this.pbDownload.Size = new System.Drawing.Size(452, 25);
            // 
            // pbInstall
            // 
            this.pbInstall.BackColor = System.Drawing.Color.Transparent;
            this.pbInstall.BackgroundColor = System.Drawing.Color.Black;
            this.pbInstall.BorderColor = System.Drawing.Color.Navy;
            this.pbInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbInstall.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbInstall.GradiantColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbInstall.GradiantPosition = ProgressBarEx.GradiantArea.Center;
            this.pbInstall.Image = null;
            this.pbInstall.Location = new System.Drawing.Point(350, 383);
            this.pbInstall.Name = "pbInstall";
            this.pbInstall.ProgressColor = System.Drawing.Color.MediumBlue;
            this.pbInstall.Size = new System.Drawing.Size(452, 25);
            // 
            // S4LauncherDark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::S4Launcher_Dark.Properties.Resources.bg_launcher24;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 420);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.pbInstall);
            this.Controls.Add(this.patchNotes);
            this.Controls.Add(this.SPA_1);
            this.Controls.Add(this.USA_1);
            this.Controls.Add(this.SPA);
            this.Controls.Add(this.USA);
            this.Controls.Add(this.lbleng);
            this.Controls.Add(this.lblspa);
            this.Controls.Add(this.btnStart_1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.VersionLauncherNotes);
            this.Controls.Add(this.NOTICE1);
            this.Controls.Add(this.PLAYCOMPLETE);
            this.Controls.Add(this.DOWNLOADUPDATES);
            this.Controls.Add(this.bg_launcher);
            this.Controls.Add(this.lblFileDownloadVersion);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "S4LauncherDark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S4Launcher Dark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.S4LauncherDark_FormClosed);
            this.Load += new System.EventHandler(this.S4LauncherDark_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S4LauncherDark_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYCOMPLETE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOWNLOADUPDATES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_launcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_launcher;
        private System.Windows.Forms.PictureBox PLAYCOMPLETE;
        private System.Windows.Forms.PictureBox DOWNLOADUPDATES;
        private System.Windows.Forms.WebBrowser NOTICE1;
        private System.Windows.Forms.WebBrowser VersionLauncherNotes;
        private System.ComponentModel.BackgroundWorker PatcherClient;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnStart_1;
        private System.Windows.Forms.Label lblspa;
        private System.Windows.Forms.Label lbleng;
        private System.Windows.Forms.PictureBox SPA;
        private System.Windows.Forms.PictureBox USA;
        private System.Windows.Forms.PictureBox SPA_1;
        private System.Windows.Forms.PictureBox USA_1;
        private System.Windows.Forms.WebBrowser patchNotes;
        private ProgressBarEx pbInstall;
        private ProgressBarEx pbDownload;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblFileDownloadVersion;
    }
}

