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
        List<MusicFile> musicLibraryFiles{ get; set; }

        public MainForm()
        {
            InitializeComponent();
            libraryTreeView.ExpandAll();
            musicLibraryFiles = new List<MusicFile>();
            if (!FileHandling.MissingFileCreation("LibraryContent.txt"))
            {
                FileHandling.ReadFromFile("LibraryContent.txt", out Vars.Files);
                foreach (string file in Vars.Files)
                {
                    MusicFile musicItem = new MusicFile(file);
                    musicLibraryFiles.Add(musicItem);
                    musicFilesListView.Items.Add(new ListViewItem(new[] {musicItem.fileName, musicItem.song, musicItem.artist, musicItem.album, musicItem.genre }));
                }
            }
            ListViewItemsSetIcon(2);
            AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
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
                musicLibraryFiles.Add(new MusicFile(file));
            }
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            PerformPlay();
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
            musicFilesListView.View = View.List;
            musicFilesListView.Clear();
            switch (e.Node.Text)
            {
                case "Music":
                    foreach (MusicFile musicItem in musicLibraryFiles)
                    {
                        musicFilesListView.Items.Add(new ListViewItem(new[] { musicItem.fileName, musicItem.song, musicItem.artist, musicItem.album, musicItem.genre }));
                    }
                    AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                    ListViewItemsSetIcon(2);
                    break;
                case "Songs":
                    foreach (MusicFile musicItem in musicLibraryFiles)
                    {
                        musicFilesListView.Items.Add(new ListViewItem(new[] { musicItem.song, musicItem.fileName, musicItem.artist, musicItem.album, musicItem.genre }));
                    }
                    AddColumnsToListView(new[] { "Song", "File Name", "Artist", "Album", "Genre" });
                    ListViewItemsSetIcon(2);
                    break;
                case "Artists":
                    List<string> artists = new List<string>();
                    List<string> artistsNoDuplicates = new List<string>();
                    foreach (MusicFile musicItem in musicLibraryFiles)
                    {
                        artists.Add(musicItem.artist);
                    }
                    artistsNoDuplicates = artists.Distinct().ToList<string>();
                    foreach (string artist in artistsNoDuplicates)
                    {
                        musicFilesListView.Items.Add(new ListViewItem(new[] { artist }));
                    }
                    AddColumnsToListView(new[] { "Artist" });
                    ListViewItemsSetIcon(1);                 
                    break;
                case "Albums":
                    List<string> albums = new List<string>();
                    List<string> albumsNoDuplicates = new List<string>();
                    foreach (MusicFile musicItem in musicLibraryFiles)
                    {
                        albums.Add(musicItem.album);
                    }
                    albumsNoDuplicates = albums.Distinct().ToList<string>();
                    foreach (string album in albumsNoDuplicates)
                    {
                        musicFilesListView.Items.Add(new ListViewItem(new[] { album }));
                    }
                    AddColumnsToListView(new[] { "Album" });
                    ListViewItemsSetIcon(1);
                    break;
                case "Genres":
                    List<string> genres = new List<string>();
                    List<string> genresNoDuplicates = new List<string>();
                    foreach (MusicFile musicItem in musicLibraryFiles)
                    {
                        genres.Add(musicItem.genre);
                    }
                    genresNoDuplicates = genres.Distinct().ToList<string>();
                    foreach (string genre in genresNoDuplicates)
                    {
                        musicFilesListView.Items.Add(new ListViewItem(new[] { genre }));
                    }
                    AddColumnsToListView(new[] { "Genre" });
                    ListViewItemsSetIcon(1);
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
                        musicLibraryFiles.Add(new MusicFile(file));
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
                foreach (ListViewItem item in musicFilesListView.SelectedItems)
                {
                    string selection = item.Text;
                    MusicFile musicItem = musicLibraryFiles.Find(x => (x.fileName == selection) || (x.song == selection));
                    item.Remove();
                    Vars.Files.Remove(musicItem.filePath);
                }
            }
        }

        private void buttonIconsView_Click(object sender, EventArgs e)
        {
            musicFilesListView.View = View.LargeIcon;
            ChangeView();
        }

        private void buttonViewList_Click(object sender, EventArgs e)
        {
            musicFilesListView.View = View.List;
            musicFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonDetailsView_Click(object sender, EventArgs e)
        {
            musicFilesListView.View = View.Details;
            musicFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ListViewItemsSetIcon(int iconID)
        {
            foreach (ListViewItem itemRow in musicFilesListView.Items)
            {
                itemRow.ImageIndex = iconID;
            }
        }

        private void AddColumnsToListView(string[] columns)
        {
            foreach (string column in columns)
            {
                if (column != null)
                    musicFilesListView.Columns.Add(column, -1, HorizontalAlignment.Left);
            }
        }

        private void musicFilesListView_DoubleClick(object sender, MouseEventArgs e)
        {
            if (libraryTreeView.SelectedNode != null)
            { 
                switch (libraryTreeView.SelectedNode.Text)
                {
                    case "Music":
                    case "Songs":
                        PerformPlay();
                        break;
                    case "Artists":
                        string artist = musicFilesListView.SelectedItems[0].Text;
                        musicFilesListView.Clear();
                        foreach (MusicFile musicItem in musicLibraryFiles.FindAll(x => x.artist == artist))
                        {
                            musicFilesListView.Items.Add(new ListViewItem(new[] { musicItem.fileName, musicItem.song, musicItem.artist, musicItem.album, musicItem.genre }));
                        }
                        AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                        ChangeView();
                        libraryTreeView.SelectedNode = null;
                        break;
                    case "Albums":
                        string album = musicFilesListView.SelectedItems[0].Text;
                        musicFilesListView.Clear();
                        foreach (MusicFile musicItem in musicLibraryFiles.FindAll(x => x.album == album))
                        {
                            musicFilesListView.Items.Add(new ListViewItem(new[] { musicItem.fileName, musicItem.song, musicItem.artist, musicItem.album, musicItem.genre }));
                        }
                        AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                        ChangeView();
                        libraryTreeView.SelectedNode = null;
                        break;
                    case "Genres":
                        string genre = musicFilesListView.SelectedItems[0].Text;
                        musicFilesListView.Clear();
                        foreach (MusicFile musicItem in musicLibraryFiles.FindAll(x => x.genre == genre))
                        {
                            musicFilesListView.Items.Add(new ListViewItem(new[] { musicItem.fileName, musicItem.song, musicItem.artist, musicItem.album, musicItem.genre }));
                        }
                        AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                        ChangeView();
                        libraryTreeView.SelectedNode = null;
                        break;
                }
            }
            else
                PerformPlay();
        }

        private void ChangeView()
        {
            if ((libraryTreeView.SelectedNode == null) || (libraryTreeView.SelectedNode.Text == "Music") || (libraryTreeView.SelectedNode.Text == "Songs"))
            {
                switch (musicFilesListView.View.ToString())
                {
                    case "LargeIcon":
                        ListViewItemsSetIcon(0);
                        break;
                    case "List":
                    case "Details":
                        ListViewItemsSetIcon(2);
                        break;
                }

            }
            else
            {
                switch (musicFilesListView.View.ToString())
                {
                    case "LargeIcon":
                        ListViewItemsSetIcon(1);
                        break;
                    case "List":
                    case "Details":
                        ListViewItemsSetIcon(1);
                        break;
                }
            }
        }

        private void PerformPlay()
        {
            if ((musicFilesListView.Items.Count != 0) && (musicFilesListView.SelectedIndices != null))
            {
                string selection = musicFilesListView.SelectedItems[0].Text;
                MusicFile currentMF = musicLibraryFiles.Find(x => (x.fileName == selection) || (x.song == selection));
                labelFilePlaying.Text = currentMF.fileName;
                BassMethods.Play(currentMF.filePath, BassMethods.Volume);
                label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
                label3.Text = TimeSpan.FromSeconds(BassMethods.GetTimeOfStream(BassMethods.Stream)).ToString();
                Time_sl.Maximum = BassMethods.GetTimeOfStream(BassMethods.Stream);
                Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
                timer1.Enabled = true;
            }
        }
    }
}
