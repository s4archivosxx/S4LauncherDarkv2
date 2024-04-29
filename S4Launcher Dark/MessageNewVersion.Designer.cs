namespace S4Launcher_Dark
{
    partial class MessageNewVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageNewVersion));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.S4DF = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.WebLauncher = new System.Windows.Forms.WebBrowser();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.lblLocalVersion = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.MenuStrip.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S4DF});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(422, 30);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "S4League Dark Force";
            this.MenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseDown);
            this.MenuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseMove);
            this.MenuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseUp);
            // 
            // S4DF
            // 
            this.S4DF.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S4DF.Name = "S4DF";
            this.S4DF.Size = new System.Drawing.Size(183, 26);
            this.S4DF.Text = "S4League Dark Force";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(12, 46);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 44);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message:\r\n                  ";
            // 
            // WebLauncher
            // 
            this.WebLauncher.Location = new System.Drawing.Point(12, 196);
            this.WebLauncher.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebLauncher.Name = "WebLauncher";
            this.WebLauncher.ScriptErrorsSuppressed = true;
            this.WebLauncher.ScrollBarsEnabled = false;
            this.WebLauncher.Size = new System.Drawing.Size(29, 24);
            this.WebLauncher.TabIndex = 2;
            this.WebLauncher.Url = new System.Uri("http://s4ldark.dynv6.net/Game/Patchs/VersionLauncher/", System.UriKind.Absolute);
            this.WebLauncher.Visible = false;
            // 
            // BtnDownload
            // 
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownload.Location = new System.Drawing.Point(188, 196);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(222, 34);
            this.BtnDownload.TabIndex = 3;
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // lblLocalVersion
            // 
            this.lblLocalVersion.AutoSize = true;
            this.lblLocalVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalVersion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalVersion.ForeColor = System.Drawing.Color.White;
            this.lblLocalVersion.Location = new System.Drawing.Point(12, 126);
            this.lblLocalVersion.Name = "lblLocalVersion";
            this.lblLocalVersion.Size = new System.Drawing.Size(116, 22);
            this.lblLocalVersion.TabIndex = 4;
            this.lblLocalVersion.Text = "You Version :";
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.AutoSize = true;
            this.lblNewVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblNewVersion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVersion.ForeColor = System.Drawing.Color.White;
            this.lblNewVersion.Location = new System.Drawing.Point(12, 155);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(117, 22);
            this.lblNewVersion.TabIndex = 5;
            this.lblNewVersion.Text = "New Version:";
            // 
            // MessageNewVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 242);
            this.Controls.Add(this.lblNewVersion);
            this.Controls.Add(this.lblLocalVersion);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.WebLauncher);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MessageNewVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageNewVersion";
            this.Load += new System.EventHandler(this.MessageNewVersion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageNewVersion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MessageNewVersion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MessageNewVersion_MouseUp);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem S4DF;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.WebBrowser WebLauncher;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Label lblLocalVersion;
        private System.Windows.Forms.Label lblNewVersion;
    }
}