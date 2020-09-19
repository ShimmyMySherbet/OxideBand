using System;
using System.Drawing;
using System.Windows.Forms;
using OxideBand.APIs;
using OxideBand.Controls;
using OxideBand.Models;
using OxideBand.Modules;

namespace OxideBand
{
    public partial class MainWindow : Form
    {
        public int MidiEntryGap = 30;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SettingsManager.Init(out bool newc);
            if (newc)
            {
                MessageBox.Show(this, "Please set your Rust game path in Config.ini", "Settings");
                Application.Exit();
            }
            Button btnSubmit = new Button();
            btnSubmit.Click += BtnSubmit_Click;
            AcceptButton = btnSubmit;
            txtSearch.AcceptsReturn = true;
            flowMidis.SizeChanged += FlowMidis_SizeChanged;
            SizeChanged += MainWindow_SizeChanged;
            CalculateCentre();
            LblCentreScreen.BringToFront();
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            CalculateCentre();
        }

        public void CalculateCentre()
        {
            int PX = (Size.Width / 2) - (LblCentreScreen.Width / 2);
            int PY = (Size.Height / 2) - (LblCentreScreen.Height) - 10;
            Console.WriteLine($"LOC: {PX} {PY}");
            Point Loc = new Point(PX, PY);
            if (LblCentreScreen.Location != Loc)
            {
                LblCentreScreen.Location = Loc;
            }
        }

        private void FlowMidis_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ct in flowMidis.Controls)
            {
                ct.Width = flowMidis.Width - MidiEntryGap;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            flowMidis.SuspendLayout();
            if (flowMidis.Controls.Count != 0)
            {
                foreach (Control control in flowMidis.Controls)
                    control.Dispose();
                flowMidis.Controls.Clear();
            }

            BitMidiResult midiResult = BitMidi.Search(txtSearch.Text);
            foreach (BitMidiResultEntry midi in midiResult.results)
            {
                Console.WriteLine("Add Control");
                MidiEntry midiEntry = new MidiEntry(midi);
                midiEntry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                midiEntry.Width = flowMidis.Width - MidiEntryGap;
                flowMidis.Controls.Add(midiEntry);
            }

            if (flowMidis.Controls.Count == 0)
            {
                LblCentreScreen.Show();
            }
            else
            {
                LblCentreScreen.Hide();
            }
            lblResults.Text = $"Found: {midiResult.total}";
            flowMidis.ResumeLayout();
        }
    }
}