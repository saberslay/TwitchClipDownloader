using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Twitch_Clip_Downloader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        WebClient client;
        private int _Count = 1;

        static string CurrentPath = Directory.GetCurrentDirectory();

        private async void button1_Click(object sender, EventArgs e) {

            if (TB.Text != null) {
                string[] lines = File.ReadAllLines($@"{CurrentPath}\{TB.Text}_clips.txt");
                // To do put downloaded file in to folder
                //if (!Directory.Exists(Path.Combine(CurrentPath, "Twitch Clips"))) {
                //    Directory.CreateDirectory(Path.Combine(CurrentPath, "Twitch Clips"));
                //}

                foreach (var _url in lines) {
                   await client.DownloadFileTaskAsync(_url, $@"Twitch Clip " + _Count + ".mp4");
                    _Count++;

                }
            } else {
                MessageBox.Show("Twitch Name Error", "Twitch Clip Downloaded",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)  {
            Invoke(new MethodInvoker(delegate() {
                PB.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                label1.Text = $"Dowload {string.Format("{0:0.##}", percentage)}%";
                PB.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void twitchClipsToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.twitchanz.com/clips/");

        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/saberslay/TwitchClipDownloader");
        }
    }
}
