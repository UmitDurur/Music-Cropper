using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace Music_Cropper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            wavePlayer = new WaveOut();
            wavePlayer.PlaybackStopped += WavePlayer_PlaybackStopped;
            timer1.Enabled = true;

        }

        private void WavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            btnPlay.Text = "Play";
            ChangeNotifState(Color.Black, "Music Stopped.");
        }

        private string MusicPath;
        private string MusicName;
        private int CropCounter;

        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;

        private async Task<string> Execute(string exePath, string parameters)
        {
            string result = String.Empty;

            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = exePath;
                p.StartInfo.Arguments = parameters;
                p.Start();
                p.WaitForExit();

                result = p.StandardOutput.ReadToEnd();
            }
            
            return result;
        }

        private async void btnCrop_Click(object sender, EventArgs e)
        {
            double startseconds = TimeSpan.Parse(txtStartTime.Text).TotalSeconds;
            double endseconds = TimeSpan.Parse(txtEndTime.Text).TotalSeconds-startseconds;
            string directoryPath = Path.Combine(Path.GetDirectoryName(MusicPath), MusicName.Insert(MusicName.Length - 4, "-"+CropCounter++.ToString()));
            ChangeNotifState(Color.Black, "Cropping...");
            
            await Task.Factory.StartNew(() => Execute("ffmpeg\\ffmpeg.exe", string.Format("-ss {0} -t {1} -i \"{2}\" -acodec copy \"{3}\"", startseconds, endseconds, MusicPath, directoryPath)));
            /*Task.Factory.StartNew(() =>
            {
                return Execute("ffmpeg\\ffmpeg.exe", string.Format("-ss {0} -t {1} -i \"{2}\" -acodec copy \"{3}\"", startseconds, endseconds, MusicPath, directoryPath));

            });*/
            //string result = await Task.Run(() => Execute("ffmpeg\\ffmpeg.exe", string.Format("-ss {0} -t {1} -i \"{2}\" -acodec copy \"{3}\"", startseconds, endseconds, MusicPath, directoryPath)));
            
            ChangeNotifState(Color.Green, "Cropped and saved.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                lblNowTime.Text = FormatTimeSpan(audioFileReader.CurrentTime);
                lblTotalTime.Text = FormatTimeSpan(audioFileReader.TotalTime);
                trackBar1.Value = Convert.ToInt32(audioFileReader.CurrentTime.TotalSeconds);
            }
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            audioFileReader.CurrentTime = TimeSpan.FromSeconds(trackBar1.Value);
        }

        private void btnGetStartTime_Click(object sender, EventArgs e)
        {
            txtStartTime.Text = FormatTimeSpan(audioFileReader.CurrentTime);
        }

        private void btnGetEndTime_Click(object sender, EventArgs e)
        {
            txtEndTime.Text = FormatTimeSpan(audioFileReader.CurrentTime);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                if (wavePlayer.PlaybackState != PlaybackState.Playing)
                {
                    btnPlay.Text = "Pause";
                    wavePlayer.Play();
                    ChangeNotifState(Color.Black, "Playing...");
                }
                else
                {
                    btnPlay.Text = "Play";
                    wavePlayer.Pause();
                    ChangeNotifState(Color.Black, "Paused");
                }
            }
            else ChangeNotifState(Color.Red, "Select file before play!");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff;*.wma";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (Control cntrlElement in this.Controls)
                    if (cntrlElement.Enabled == false)
                        cntrlElement.Enabled=true;
                MusicPath = ofd.FileName;
                MusicName = ofd.SafeFileName;
                lblFile.Text = MusicName;
                audioFileReader = new AudioFileReader(MusicPath);
                trackBar1.Maximum = Convert.ToInt32(audioFileReader.TotalTime.TotalSeconds);
                wavePlayer.Init(audioFileReader);
                CropCounter = 1;
                ChangeNotifState(Color.Black, "Music selected.");
            }
        }

        private void ChangeNotifState(Color color, string message)
        {
            toolStripStatusLabel1.Text = message;
            toolStripStatusLabel1.ForeColor = color;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space))
            {
                btnPlay.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Right))
            {
               audioFileReader.CurrentTime = TimeSpan.FromSeconds(audioFileReader.CurrentTime.TotalSeconds+5);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Left))
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(audioFileReader.CurrentTime.TotalSeconds -5);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnStartTimeToPlayer_Click(object sender, EventArgs e)
        {
            audioFileReader.CurrentTime = TimeSpan.Parse(txtStartTime.Text);
        }

        private void btnEndTimeToPlayer_Click(object sender, EventArgs e)
        {

            audioFileReader.CurrentTime = TimeSpan.Parse(txtEndTime.Text);
        }

        private void btnSTToET_Click(object sender, EventArgs e)
        {
            txtEndTime.Text = txtStartTime.Text;
        }

        private void btnETToST_Click(object sender, EventArgs e)
        {
            txtStartTime.Text = txtEndTime.Text;
        }

    }
}
