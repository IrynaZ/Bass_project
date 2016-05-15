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
        private int selectedSongIndex = 0;
        private bool isplaying = false;

        public MainForm()
        {
            InitializeComponent();
            libraryTreeView.ExpandAll();
            if (!FileHandling.MissingFileCreation("LibraryContent.txt"))
            {
                FileHandling.ReadFromFile("LibraryContent.txt", out Vars.Files);
                foreach (string file in Vars.Files)
                {
                    musicFilesListView.Items.Add(Vars.GetFileName(file));
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileHandling.WriteToFile(Vars.Files, "LibraryContent.txt");
        }

        private void Eject_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string file = openFileDialog1.FileName;
            if (!Vars.FileAlreadyExistsInFiles(file) && Vars.FileIsMP3(file))
            {
                Vars.Files.Add(file);
                musicFilesListView.Items.Add(Vars.GetFileName(file));
            }
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                BassMethods.Pause();
                isplaying = false;

            }
            else
            {
                isplaying = true;
                StartPlaying();
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

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath;
            if (openFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = openFolderDialog1.SelectedPath;
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    if (!Vars.FileAlreadyExistsInFiles(file) && Vars.FileIsMP3(file))
                    {
                        Vars.Files.Add(file);
                        musicFilesListView.Items.Add(Vars.GetFileName(file));
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((musicFilesListView.Items.Count != 0) && (musicFilesListView.SelectedIndices != null))
            {
                ListView.SelectedIndexCollection indexes = musicFilesListView.SelectedIndices;
                foreach (int index in indexes)
                {
                    musicFilesListView.Items[index].Remove();
                    Vars.Files.Remove(musicFilesListView.Items[index].Text);
                }
            }
        }

        private void buttonNextMusicFile_Click(object sender, EventArgs e)
        {
            BassMethods.Stop();
            musicFilesListView.Items[selectedSongIndex].Selected = false;

            if (selectedSongIndex >= musicFilesListView.Items.Count - 1)
                selectedSongIndex = 0;
            else
                ++selectedSongIndex;



            musicFilesListView.Items[selectedSongIndex].Selected = true;

            StartPlaying();
        }

        private void buttonPreviousMusicFile_Click(object sender, EventArgs e)
        {
            BassMethods.Stop();
            musicFilesListView.Items[selectedSongIndex].Selected = false;

            if (selectedSongIndex == 0 )
                selectedSongIndex = musicFilesListView.Items.Count - 1;
            else
                --selectedSongIndex;

            musicFilesListView.Items[selectedSongIndex].Selected = true;
            StartPlaying();
        }

        private void StartPlaying()
        {
            if ((musicFilesListView.Items.Count != 0) && (musicFilesListView.SelectedIndices != null))
            {

                string current = Vars.Files[musicFilesListView.SelectedIndices[0]];
                selectedSongIndex = musicFilesListView.SelectedIndices[0];
                labelFilePlaying.Text = Vars.GetFileName(current);
                BassMethods.Play(current, BassMethods.Volume);
                label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
                label3.Text = TimeSpan.FromSeconds(BassMethods.GetTimeOfStream(BassMethods.Stream)).ToString();
                Time_sl.Maximum = BassMethods.GetTimeOfStream(BassMethods.Stream);
                Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
                timer1.Enabled = true;
            }
        }
    }
}
