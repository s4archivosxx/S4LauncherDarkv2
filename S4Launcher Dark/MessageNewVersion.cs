using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace S4Launcher_Dark
{
    public partial class MessageNewVersion : Form
    {
        IniFile inifile = new IniFile("Settings.ini");
        //string Server = "http://localhost/Game/Patchs/VersionLauncher/";
        string Server = "http://s4ldark.dynv6.net/Game/Patchs/VersionLauncher/";
        string errorfile = "No se ha podido reconocer el idioma establecido.";
        Point point;
        bool mauseaction;
        public MessageNewVersion()
        {
            InitializeComponent();
            
        }

        private void RedWeb()
        {
            try
            {
                ////server's list of updates
                XDocument serverXml = XDocument.Load(@Server + "VersionLauncher.xml");

                //The Update Process
                foreach (XElement launcher in serverXml.Descendants("launcher"))
                {
                    string downloadc = launcher.Element("DownloadC").Value;
                    string descargarc = launcher.Element("DescargarC").Value;

                    string lacread = inifile.Read("Language", "CONFIG");

                    if (lacread == "Español")
                    {
                        Process.Start(descargarc);
                        Environment.Exit(0);

                    }
                    else if (lacread == "English")
                    {
                        Process.Start(downloadc);
                        Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show(errorfile, "S4League Dark Force", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Environment.Exit(0);
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "S4League Dark Force", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void LoadMessage()
        {
            //string Server = WebLauncher.Url.ToString();
            try
            {
                ////server's list of updates
                XDocument serverXml = XDocument.Load(@Server + "VersionLauncher.xml");

                //The Update Process
                foreach (XElement launcher in serverXml.Descendants("launcher"))
                {
                    string version = launcher.Element("version").Value;
                    string msgoldv = launcher.Element("MsgOldV").Value;
                    string engmsgoldv = launcher.Element("EngMsgOldV").Value;
                    string btndescargar = launcher.Element("BtnDescargar").Value;
                    string btndownload = launcher.Element("BtnDownload").Value;

                    string lacread = inifile.Read("Language", "CONFIG");

                    string localversion = inifile.Read("Version", "UPDATE");

                    if (lacread == "Español")
                    {
                        lblMessage.Text = "Mensaje:\n" + msgoldv;
                        BtnDownload.Text = btndescargar;
                        lblLocalVersion.Text = "Su Versión: " + localversion;
                        lblNewVersion.Text = "Nueva Version: " + version;
                    }
                    else if (lacread == "English")
                    {
                        lblMessage.Text = "Message:\n" + engmsgoldv;
                        BtnDownload.Text = btndownload;
                        lblLocalVersion.Text = "Su Versión: " + localversion;
                        lblNewVersion.Text = "Nueva Version: " + version;
                    }
                    else
                    {
                        MessageBox.Show(errorfile, "S4League Dark Force", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                    
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "S4League Dark Force", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void MessageNewVersion_Load(object sender, EventArgs e)
        {
            LoadMessage();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            RedWeb();
        }

        #region MoveForm
        private void MessageNewVersion_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseaction = true;
        }

        private void MessageNewVersion_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseaction == true)
            {
                Location = new Point(Cursor.Position.X - point.X, Cursor.Position.Y - point.Y);
            }
        }

        private void MessageNewVersion_MouseUp(object sender, MouseEventArgs e)
        {
            mauseaction = false;
        }

        private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseaction = true;
        }

        private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseaction == true)
            {
                Location = new Point(Cursor.Position.X - point.X, Cursor.Position.Y - point.Y);
            }
        }

        private void MenuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            mauseaction = false;
        }
        #endregion
    }
}
