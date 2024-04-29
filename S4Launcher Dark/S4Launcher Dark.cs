using Ionic.Zip;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace S4Launcher_Dark
{
    public partial class S4LauncherDark : Form
    {
        //private const string VersionPatch = "launcher.ini";
        private const string CONFIG_FILE = "language.config";
        IniFile ini = new IniFile("Settings.ini");
        IniFile VersionIni = new IniFile("version.ini");
        WebClient client = new WebClient();
        string errorfile = "No se ha podido reconocer el idioma establecido.";
        WebClient Downloader = new WebClient();
        private const String LocalUpdateFile = @".\version.ini";
        public String UpdateUrl = "http://s4ldark.dynv6.net/Game/release/S4DF/version.ini";
        //public String UpdateUrl = "http://localhost/Game/release/S4DF/version.ini";
        string Root = AppDomain.CurrentDomain.BaseDirectory;
        string Server = "http://s4ldark.dynv6.net/Game/Patchs/";
        //string Server = "http://localhost/Game/Patchs/";
        //private const String LocalUpdateFileVL = @".\VersionGame.xml";
        //public String UpdateUrlVL = "http://s4ldark.dynv6.net/Game/Patchs/VersionLauncher/VersionGame.xml";
        string Server2 = "http://s4ldark.dynv6.net/Game/Patchs/VersionLauncher/";
        //string Server2 = "http://localhost/Game/Patchs/VersionLauncher/";
        WebClient wc = new WebClient();

        Point formPosition;
        bool mauseAction;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        //private object w;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #region Comments
        //private string[] configArgs;


        //private void LoadConfig()
        //{
        //    try
        //    {
        //        configArgs = File.ReadAllLines(CONFIG_FILE);
        //        //string iniread = ini.Read("Language", "CONFIG");
        //        ////configArgs = iniread[""];
        //        //if (iniread == "Español")
        //        //{
        //        //    configArgs[0] = "spa";
        //        //}
        //        //else if (iniread == "English")
        //        //{
        //        //    configArgs[0] = "eng";
        //        //}
        //        //XDocument serverXml = XDocument.Load(@Server2 + "Updates.xml");
        //        //foreach (XElement update in serverXml.Descendants("update"))
        //        //{
        //        //    string Ip = update.Element("Ip").Value;

        //        //    lblIp.Text = Ip;
        //        //}
        //    }
        //    catch { CreateConfig(); LoadConfig(); }
        //}

        //private void CreateConfig()
        //{
        //    string[] newConfig = {  lblspa.Text };
        //    File.WriteAllLines(CONFIG_FILE, newConfig);
        //}

        //private void SaveConfig()
        //{
        //    //configArgs[0] = lblspa.Text;
        //    //var Language = new IniFile("Settings.ini");
        //    configArgs[0] = ini.Read("Language", "CONFIG");
        //    if (lblspa.Enabled == true)
        //    {
        //        configArgs[0] = lblspa.Text;
        //        //using (StreamWriter sw = new StreamWriter(CONFIG_FILE))
        //        //{
        //        //    sw.Write("spa");
        //        //}
        //        ini.Write("Language", "Español", "CONFIG");
        //        //Language.Write("Img", "1", "CONFIG");
        //    }
        //    if (lbleng.Enabled == true)
        //    {
        //        configArgs[0] = lbleng.Text;
        //        //using (StreamWriter sw = new StreamWriter(CONFIG_FILE))
        //        //{
        //        //    sw.Write("eng");
        //        //}
        //        ini.Write("Language", "English", "CONFIG");
        //        //Language.Write("Img", "2", "CONFIG");
        //    }

        //    File.WriteAllLines(CONFIG_FILE, configArgs);
        //}
        #endregion

        public S4LauncherDark()
        {
            InitializeComponent();
            //TransparenteImg();
            
            PatcherClient.RunWorkerAsync();
            //txtbLang2.Text = configArgs[0];
            //SetCombo();
            //LoadConfig();
        }

        public bool ExtractZip(string file)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(file))
                {
                    foreach (ZipEntry zipFiles in zip)
                    {
                        zipFiles.Extract(true);
                    }
                }

                return true;
            }

            catch (IOException)
            {
                return false;
            }

        }

        public static bool DeleteFile(string f)
        {
            try
            {
                File.Delete(f);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        private void LauncherProcess()
        {
            string process = "S4Launcher Dark";
            Process process2 = new Process();
            if (Process.GetProcessesByName(process).Length == 1)
            {
                //MessageBox.Show("Working", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("S4Launcher Dark is already running", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
                Environment.Exit(0);
            }
        }

        public void GameVersion()
        {
            //FileStream fs = null;

            //checks client version
            //string lclVersion;

            //var IniFile = new IniFile.IniFile("Settings.ini");
            try
            {
                string localV;
                localV = ini.Read("Version", "UPDATE");

                decimal LocalVersion = decimal.Parse(localV);
                #region Comments
                //using (StreamReader reader = new StreamReader("VersionGame.xml"))
                //{
                //    lclVersion = reader.ReadLine();
                //}
                //XmlReader r = XmlReader.Create("VersionGame.xml");
                //r.ReadStartElement("Game_Config");
                //lclVersion = r.ReadElementContentAsString();
                //r.Close();

                //decimal localVersion = decimal.Parse(lclVersion);

                #endregion
                ////server's list of updates
                XDocument serverXml = XDocument.Load(@Server2 + "VersionLauncher.xml");

                //The Update Process
                foreach (XElement launcher in serverXml.Descendants("launcher"))
                {
                    string oldversion = launcher.Element("oldversion").Value;
                    string version = launcher.Element("version").Value;

                    decimal serverVersion = decimal.Parse(version);

                    int oldver = int.Parse(oldversion);
                    //string sUrlToReadFileFrom = Server + version;

                    //string sFilePathToWriteFileTo = Root + version;

                    if (LocalVersion <= oldver)
                    {
                        ini.Write("Version", version, "UPDATE");
                        //MessageBox.Show("Su versión del juego es antigua, por favor descargue la nueva version del cliente.\n" + "Su versión: " + LocalVersion + "\n" + "Versión Actual: " + serverVersion, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Process.Start("http://s4ldark.dynv6.net/");
                        //PatcherClient.CancelAsync();
                    }
                    //else if (LocalVersion > serverVersion)
                    //{
                    //    MessageBox.Show("Usted no puede alterar el orden de los updates.", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    ini.Write("Version", version, "UPDATE");
                    //    Close();
                    //}
                    else if (serverVersion > LocalVersion)
                    {
                        Server = "";
                        client.Dispose();
                        //Hide();
                        MessageNewVersion msgnv = new MessageNewVersion();
                        msgnv.ShowDialog();
                        Close();
                    }
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message, "S4League Dark Force",
                //     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblFileDownloadVersion.Visible = true;
                PLAYCOMPLETE.Visible = false;
                DOWNLOADUPDATES.Visible = false;
            }

        }

        private void VersionClient()
        {
            //FileStream fs = null;
            //try
            //{
            //    WebClient wb = new WebClient();
            //    wb.DownloadFile(UpdateUrl, LocalUpdateFile);
            //    wb.Dispose();
            //}

            //catch (Exception ex)
            //{
            //    //MessageBox.Show("¡Error Message:\n" + "Failed to download version.ini" + "!\nSpa: ¡Comunicate Con el Servidor! " + "\nEng: Communicate with the Server!\n" + ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    lblFileDownloadVersion.Visible = true;
            //    PLAYCOMPLETE.Visible = false;
            //    DOWNLOADUPDATES.Visible = false;
            //}
            #region Comments
            //if (!File.Exists("version.ini"))
            //{
            //    using (fs = File.Create("version.ini"))
            //    {

            //    }

            //    using (StreamWriter sw = new StreamWriter("version.ini"))
            //    {
            //        sw.Write("[SERVER]\n\nIP1 = 35.202.21.48");
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        WebClient wb = new WebClient();
            //        wb.DownloadFile(UpdateUrl, LocalUpdateFile);
            //        wb.Dispose();
            //    }

            //    catch (Exception e)
            //    {
            //        MessageBox.Show("¡Error Message:\n" + "Failed to download version.ini" + "!\n¡Comunicate Con el Servidor! " + " Communicate with the Server!", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            #endregion
        }
        public void BatDetect()
        {
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            foreach (FileInfo fi in di.GetFiles("*.bat", SearchOption.AllDirectories))
            {
                fi.Delete();
            }

        }
        public void CreateCarpeta()
        {
            //FileStream fc = null;
            //DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            if (!Directory.Exists("shop"))
                Directory.CreateDirectory("shop");
            else
                CleanUp();
        }

        private void CheckForUpdates()
        {
            try
            {
                string localV = VersionIni.Read("Launcher", "CONFIG");

                // if (localV == "8.0.2.2")
                // {
                //    VersionIni.Write("launcher_version", "8022" ,"VERSION");
                // }

                Version LocalVersion = Version.Parse(localV);
                ////server's list of updates
                XDocument serverXml = XDocument.Load(@Server2 + "VersionLauncher.xml");

                //The Update Process
                foreach (XElement launcher in serverXml.Descendants("launcher"))
                {
                    string launcher_version = launcher.Element("NewVersionLauncher").Value;

                    Version serverVersion = Version.Parse(launcher_version);

                    if (serverVersion > LocalVersion)
                    {
                        Server = "";
                        client.Dispose();
                        //Updater.CheckForUpdates();
                    }
                }
            }
            catch
            {
               
            }
        }

        private void S4LauncherDark_Load(object sender, EventArgs e)
        {
            CheckForUpdates();
            LauncherProcess();
            GameVersion();
            //VersionClient();
            BatDetect();
            CreateCarpeta();
            IniFileConfig();
        }
        private void IniFileConfig()
        {
            //var Lang = new IniFile.IniFile("Settings.ini");
            if (!File.Exists("Settings.ini"))
            {
                ini.Write("Language", "Español", "CONFIG");
                ini.Write("Launcher", ProductVersion, "CONFIG");
                ini.Write("Version", "171", "UPDATE");
            }

            if (!ini.KeyExists("Version", "UPDATE"))
            {
                ini.Write("Version", "171", "UPDATE");
                //MyIni.Write("Language", "Spanish", "CONFIG");

            }
            if (!ini.KeyExists("Launcher", "CONFIG"))
            {
                ini.Write("Launcher", ProductVersion, "CONFIG");
                //MyIni.Write("Language", "Spanish", "CONFIG");

            }
            if (!ini.KeyExists("Language", "CONFIG"))
            {
                ini.Write("Language", "Español", "CONFIG");
                //ImgLang.Write("Img", "1", "CONFIG");
            }

            string VersionApp = Application.ProductVersion;
            
            //VersionIni.Read("VERSION");
            //VersionIni.Write("launcher_version", VersionApp, "VERSION");
            //VersionIni.Read("DOWNLOAD");
            //VersionIni.Write("server1", Server, "DOWNLOAD");
            //VersionIni.Read("SERVER");
            //VersionIni.Write("URL1", UpdateUrl, "SERVER");
            string Ipread = VersionIni.Read("IP1", "SERVER");
            if (Ipread == "25.2.222.181")
            {
                VersionIni.Write("IP1", "PAtKDT/EfbyiqoX4rROG4Q==", "SERVER");
            }
            
            //string lclVersion;
            //lclVersion = ImgLang.Read("Img", "CONFIG");
            //int Img = int.Parse(lclVersion);
            string language;
            language = ini.Read("Language", "CONFIG");
            
            if (language == "Español")
            {
                SPA_1.Visible = true;
                //lblspa.Enabled = true;
                //configArgs[0] = "spa";
            }
            else if (language == "English")
            {
                USA_1.Visible = true;
                //lbleng.Enabled = true;
                //configArgs[0] = "eng";
            }

            #region Comments
            //var MyIni = new IniFile.IniFile("Settings.ini");
            //MyIni.Read("Update");

            //// Or specify a specific name in the current dir
            ////var MyIni = new IniFile.IniFile("Settings.ini");
            //MyIni.Write("Version", "164", "Update");

            //if(!MyIni.KeyExists("Version", "Update"))
            //{
            //    MyIni.Write("Version", "164", "Update");
            //}
            // Or specify a specific name in a specific dir
            //var MyIni = new IniFile.IniFile(@"C:\Settings.ini");
            #endregion
        }

        private void PatcherClient_DoWork(object sender, DoWorkEventArgs e)
        {
            #region Comments
            //var MyIni = new IniFile.IniFile("Settings.ini");
            //MyIni.Read("Version", "UPDATE");


            //if (!File.Exists("Settings.ini"))
            //{
            //    ini.Write("Version", "163", "UPDATE");
            //}

            //FileStream fs = null;
            //if (!File.Exists("launcher.ini"))
            //{
            //    using (fs = File.Create("launcher.ini"))
            //    {

            //    }

            //    using (StreamWriter sw = new StreamWriter("launcher.ini"))
            //    {
            //        sw.Write("159");
            //    }
            //}
            // Or specify a specific name in the current dir
            //var MyIni = new IniFile.IniFile("Settings.ini");
            //MyIni.Write("Version", "164", "Update");


            //if (!ini.KeyExists("Version", "UPDATE"))
            //{
            //    ini.Write("Version", "163", "UPDATE");
            //    //MyIni.Write("Language", "Spanish", "CONFIG");
            //}
            #endregion
            //checks client version
            //string lclVersion;
            //using (StreamReader reader = new StreamReader("launcher.ini"))
            //{
            //    lclVersion = reader.ReadLine();
            //}
            string lclVersion = ini.Read("Version", "UPDATE");
            decimal localVersion = decimal.Parse(lclVersion);

            //server's list of updates
            XDocument serverXml = XDocument.Load(@Server + "Updates.xml");

            //The Update Process
            foreach (XElement update in serverXml.Descendants("update"))
            {
                string version = update.Element("version").Value;
                string file = update.Element("file").Value;
                string Ip = update.Element("Ip").Value;

                decimal serverVersion = decimal.Parse(version);

                lblIp.Text = Ip;
                //lblIp.Text = configArgs[1];

                string sUrlToReadFileFrom = Server + file;

                string sFilePathToWriteFileTo = Root + file;

                if (serverVersion > localVersion)
                {
                    Uri url = new Uri(sUrlToReadFileFrom);
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    response.Close();

                    long iSize = response.ContentLength;

                    long iRunningByteTotal = 0;

                    using (client)
                    {
                        using (Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                        {
                            using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                int iByteSize = 0;
                                byte[] byteBuffer = new byte[iSize];
                                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                {
                                    streamLocal.Write(byteBuffer, 0, iByteSize);
                                    iRunningByteTotal += iByteSize;

                                    double dIndex = (iRunningByteTotal);
                                    double dTotal = byteBuffer.Length;
                                    double pbInstall = (dIndex / dTotal);
                                    int iProgressPercentage = (int)(pbInstall * 100);

                                    PatcherClient.ReportProgress(iProgressPercentage);
                                }

                                streamLocal.Close();
                            }

                            streamRemote.Close();
                        }
                    }

                    //unzip
                    ExtractZip(file);

                    if (DeleteFile(file) == true)
                    {
                        if (pbInstall.Value == 0)
                        {
                            pbInstall.Value = 5;
                        }

                        else if (pbInstall.Value == 5)
                        {
                            pbInstall.Value = 10;
                        }

                        else if (pbInstall.Value == 10)
                        {
                            pbInstall.Value = 15;
                        }

                        else if (pbInstall.Value == 15)
                        {
                            pbInstall.Value = 20;
                        }

                        else if (pbInstall.Value == 20)
                        {
                            pbInstall.Value = 25;
                        }

                        else if (pbInstall.Value == 25)
                        {
                            pbInstall.Value = 30;
                        }

                        else if (pbInstall.Value == 30)
                        {
                            pbInstall.Value = 35;
                        }

                        else if (pbInstall.Value == 35)
                        {
                            pbInstall.Value = 40;
                        }

                        else if (pbInstall.Value == 40)
                        {
                            pbInstall.Value = 45;
                        }

                        else if (pbInstall.Value == 50)
                        {
                            pbInstall.Value = 55;
                        }

                        else if (pbInstall.Value == 55)
                        {
                            pbInstall.Value = 60;
                        }

                        else if (pbInstall.Value == 60)
                        {
                            pbInstall.Value = 65;
                        }

                        else if (pbInstall.Value == 65)
                        {
                            pbInstall.Value = 70;
                        }

                        else if (pbInstall.Value == 70)
                        {
                            pbInstall.Value = 75;
                        }

                        else if (pbInstall.Value == 75)
                        {
                            pbInstall.Value = 80;
                        }

                        else if(pbInstall.Value == 80)
                        {
                            pbInstall.Value = 85;
                        }

                        else if (pbInstall.Value == 85)
                        {
                            pbInstall.Value = 90;
                        }

                        else if (pbInstall.Value == 95)
                        {
                            pbInstall.Value = 100;
                        }

                        ini.Write("Version", serverVersion.ToString(), "UPDATE");
                    }

                    //Delete Zip File
                    DeleteFile(file);
                }
            }
        }
		
        private void PatcherClient_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbDownload.Value = e.ProgressPercentage;
            PLAYCOMPLETE.Visible = false;
            DOWNLOADUPDATES.Visible = true;
            btnStart.Enabled = false;
            btnStart_1.Enabled = false;
        }

        private void PatcherClient_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            pbInstall.Value = 100;
            pbDownload.Value = 100;
            DOWNLOADUPDATES.Visible = false;
            PLAYCOMPLETE.Visible = true;
            btnStart.Enabled = true;
            btnStart_1.Enabled = true;
            
            //Downloader.DownloadFile(Server + "update.ini", @Root + "launcher.ini");
            //Downloader.DownloadFile(Server2 + "VersionGame.xml", @Root + "VersionGame.xml");
            //Downloader.DownloadFile(Server + "Settings.ini", @Root + "Settings.ini");
        }
		
        private void CleanUp()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
                foreach (FileInfo fi in di.GetFiles(".\\shop\\*.s4", SearchOption.AllDirectories))
                {
                    fi.Delete();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStart_1.Visible = true;
        }

        private void Bg_launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void Bg_launcher_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseAction = true;
        }

        private void Bg_launcher_MouseUp(object sender, MouseEventArgs e)
        {
            mauseAction = false;
        }

        private void BtnStart_1_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnStart_1.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnStart_1_Click(object sender, EventArgs e)
        {
            //try { IPAddress.Parse(txtbLang2.Text); }
            //catch
            //{
            //    MessageBox.Show("Invalid IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            try
            {
                //SaveConfig();
                StartS4League();
                //Environment.Exit(0);
            }
            catch
            {
                //deleteFile(CONFIG_FILE);
                //Application.Restart();
            }
            //SaveConfig();
            //StartS4League();
            //Environment.Exit(0);
        }

        private void StartS4League()
        {
            try
            {
                string lac = ini.Read("Language", "CONFIG");
                string S4Client = "S4Client";
                Process process = new Process();
                if (Process.GetProcessesByName(S4Client).Length == 0)
                {
                    if (lac == "Español")
                    {
                        process.StartInfo.FileName = S4Client;
                        process.StartInfo.Arguments = string.Format("-rc:eu -lac:spa -auth_server_ip:{0}", lblIp.Text);
                        process.Start();
                        Environment.Exit(0);
                    }

                    else if (lac == "English")
                    {
                        process.StartInfo.FileName = S4Client;
                        process.StartInfo.Arguments = string.Format("-rc:eu -lac:eng -auth_server_ip:{0}", lblIp.Text);
                        process.Start();
                        Environment.Exit(0);
                    }

                    else
                    {
                        MessageBox.Show(errorfile, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("S4Client is already running", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        private void S4LauncherDark_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void S4LauncherDark_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void USA_Click(object sender, EventArgs e)
        {
            lbleng.Enabled = true;
            lblspa.Enabled = false;
            USA_1.Visible = true;
            SPA_1.Visible = false;
            SPA.Visible = true;
            //var Language = new IniFile.IniFile("Settings.ini");
            ini.Write("Language", "English", "CONFIG");
            //Language.Write("Img", "2", "CONFIG");
            //File.WriteAllText(CONFIG_FILE, "eng");
        }

        private void SPA_Click(object sender, EventArgs e)
        {
            lblspa.Enabled = true;
            lbleng.Enabled = false;
            //USA.Visible = false;
            USA_1.Visible = false;
            SPA_1.Visible = true;
            USA.Visible = true;
            //var Language = new IniFile.IniFile("Settings.ini");
            ini.Write("Language", "Español", "CONFIG");
            //Language.Write("Img", "1", "CONFIG");
            //File.WriteAllText(CONFIG_FILE, "spa");
        }

        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
