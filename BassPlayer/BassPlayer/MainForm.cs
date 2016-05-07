using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BassPlayer.CS;

namespace MusicLibrary
{
    public partial class MainForm : Form
    {
        FileHandling LibraryContent = new FileHandling("LibraryContent.txt");

        public MainForm()
        {
            InitializeComponent();
            Vars.Files = LibraryContent.inputContent;
            foreach (string file in Vars.Files)
            {
                musicFilesListView.Items.Add(Vars.GetFileName(file));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LibraryContent.outputContent = Vars.Files;
            LibraryContent.WriteOutputToFile("LibraryContent.txt");
        }

        private void Eject_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Vars.Files.Add(openFileDialog1.FileName);
            musicFilesListView.Items.Add(Vars.GetFileName(openFileDialog1.FileName));
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if ((musicFilesListView.Items.Count !=0) && (musicFilesListView.SelectedIndices != null))
            {
                string current = Vars.Files[musicFilesListView.SelectedIndices[0]];
                labelFilePlaying.Text = Vars.GetFileName(current);
                BassMethods.Play(current, BassMethods.Volume);
                label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
                label3.Text = TimeSpan.FromSeconds(BassMethods.GetTimeOfStream(BassMethods.Stream)).ToString();
                Time_sl.Maximum = BassMethods.GetTimeOfStream(BassMethods.Stream);
                Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
            Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
        }

        private void sliderVolume_Scroll(object sender, ScrollEventArgs e)
        {
            BassMethods.SetVolumeToStream(BassMethods.Stream, Vol_sl.Value);
        }

        private void Position_Scroll(object sender, ScrollEventArgs e)
        {
            BassMethods.SetPosOfScroll(BassMethods.Stream, Time_sl.Value);
        }

        private void Stop_btn_click(object sender, EventArgs e)
        {
            BassMethods.Stop();
            timer1.Enabled = false;
            Time_sl.Value = 0;
            label2.Text = "00:00:00";
        }

        protected void libraryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Songs":
                    break;
                case "Artists":
                    break;
                case "Albums":
                    break;
                case "Genres":
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
