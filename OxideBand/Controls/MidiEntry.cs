using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxideBand.Models;
using OxideBand.Modules;

namespace OxideBand.Controls
{
    public partial class MidiEntry : UserControl
    {
        public BitMidiResultEntry midi;
        public TaskScheduler TaskScheduler;
        public TaskFactory UITaskFactory;
        private bool IsDownloading = false;
        private bool CopyCommandOnFinish = false;

        public MidiEntry()
        {
            InitializeComponent();
        }

        public MidiEntry(BitMidiResultEntry midi)
        {
            InitializeComponent();
            this.midi = midi;
        }

        private void MidiEntry_Load(object sender, EventArgs e)
        {
            if (midi != null)
            {
                lblTitle.Text = midi.name;
                lblViews.Text = $"Views: {midi.views}";
                lblPlays.Text = $"Plays: {midi.plays}";
                TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
                UITaskFactory = new TaskFactory(TaskScheduler);
                StartDownloadArtwork();
            }
        }

        public void StartDownloadArtwork()
        {
            if (!string.IsNullOrEmpty(midi.image))
            new Thread(DownloadArtwork).Start();
        }

        public void DownloadArtwork()
        {
            using (WebClient DownloadClient = new WebClient())
            {
                byte[] Buffer = DownloadClient.DownloadData($"https://bitmidi.com{midi.image}");
                Image Cover = Image.FromStream(new MemoryStream(Buffer));
                UITaskFactory.StartNew(() => pbIcon.Image = Cover);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!IsDownloading) CopyCommandOnFinish = false;
            Download();
        }

        private void Download()
        {
            if (IsDownloading) return;
            IsDownloading = true;
            try
            {
                pgDownload.Show();
                pgDownload.Value = 0;
                using (WebClient client = new WebClient())
                {
                    client.DownloadDataAsync(new Uri($"https://bitmidi.com{midi.downloadUrl}"));
                    client.DownloadProgressChanged += Client_DownloadProgressChanged;
                    client.DownloadDataCompleted += Client_DownloadDataCompleted;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsDownloading = false;
            }
        }

        private void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            File.WriteAllBytes(Path.Combine(SettingsManager.InstrumentsDirectory, $"{midi.slug}.mid"), e.Result);
            lblDownloadFinished.Show();
            lblDownloadFinished.BringToFront();
            new Thread(() =>
            {
                Thread.Sleep(800);
                UITaskFactory.StartNew(() => pgDownload.Hide());
                UITaskFactory.StartNew(() => lblDownloadFinished.Hide());
            }).Start();
            if (CopyCommandOnFinish)
            {
                CopyCommand();
            }
        }
        [STAThread]
        public void CopyCommand()
        {
            string Command = $"instruments.playrecording {midi.slug}";
            Clipboard.SetText(Command);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pgDownload.Value = e.ProgressPercentage;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyCommandOnFinish = true;
            if (File.Exists(Path.Combine(SettingsManager.InstrumentsDirectory, $"{midi.slug}.mid")))
            {
                CopyCommand();
            } else
            {
                Download();
            }
        }
    }
}