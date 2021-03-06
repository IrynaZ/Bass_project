﻿using System;
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
        int selectedSongIndex = 0;
        private bool isplaying = false;
        private bool ispaused = false;
        MusicFolder folderMusic = new MusicFolder("Music", "Music");
        MusicFolder folderSongs = new MusicFolder("Songs", "Songs");
        MusicFolder folderArtists = new MusicFolder("Artists", "Artists");
        MusicFolder folderAlbums = new MusicFolder("Albums", "Albums");
        MusicFolder folderGenres = new MusicFolder("Genres", "Genres");
        MusicFolder lastExpandedFolder = new MusicFolder("", "");
        string lastSubfolder = null;

        public MainForm()
        {
            InitializeComponent();
            libraryTreeView.ExpandAll();
            List<string> files = new List<string>(); 
            if (!FileHandling.MissingFileCreation("LibraryContent.txt"))
            {
                folderMusic.ReadFolderFromFile("LibraryContent.txt");
            }
            folderMusic.AddFolderToListView(musicFilesListView);
            UpdateFolders(folderMusic);
            AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
            SetDefaultView();
            CheckButtonsStateAndUpdate();
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
            folderMusic.AddItemFromFile(file);
            UpdateFolders(folderMusic);
            folderMusic.AddFolderToListView(musicFilesListView);
            SetDefaultView();
            FileHandling.WriteToFile(Vars.Files, "LibraryContent.txt");
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                ispaused = BassMethods.Pause();
                isplaying = false;

            }
            else
            {
                isplaying = true;
                ispaused = false;
                StartPlaying();
            }
            CheckButtonsStateAndUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
            Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
            Vars.CurrentTrackNumber = selectedSongIndex;
            if (BassMethods.ToNextTrack())
            {
                selectedSongIndex++;
                label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
                label3.Text = TimeSpan.FromSeconds(BassMethods.GetTimeOfStream(BassMethods.Stream)).ToString();
                Time_sl.Maximum = BassMethods.GetTimeOfStream(BassMethods.Stream);
                Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
                CutMusicLabel(folderMusic.GetItem(musicFilesListView.Items[selectedSongIndex].Text).fileName);

            }
            if (BassMethods.EndPlaylist)
            {
                Stop_btn_click(this, new EventArgs());
                selectedSongIndex = Vars.CurrentTrackNumber = 0;
                BassMethods.EndPlaylist = false;
            }
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
            isplaying = false;
            timer1.Enabled = false;
            Time_sl.Value = 0;
            label2.Text = "00:00:00";
            ispaused = false;
            CheckButtonsStateAndUpdate();
        }

        private void UpdateFolders(MusicFolder sourceToUpdate)
        {
            folderMusic.SyncFolderItems(sourceToUpdate.folderItems);
            folderSongs.SyncFolderItems(sourceToUpdate.folderItems);
            folderArtists.SyncFolderItems(sourceToUpdate.folderItems);
            folderArtists.FillSubFolders();
            folderAlbums.SyncFolderItems(sourceToUpdate.folderItems);
            folderAlbums.FillSubFolders();
            folderGenres.SyncFolderItems(sourceToUpdate.folderItems);
            folderGenres.FillSubFolders();
        }

        protected void libraryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            musicFilesListView.View = View.List;
            musicFilesListView.Clear();
            switch (e.Node.Text)
            {
                case "Music":
                    folderMusic.AddFolderToListView(musicFilesListView);
                    AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                    ListViewItemsSetIcon(2);
                    break;
                case "Songs":
                    folderSongs.SyncFolderItems(folderMusic.folderItems);
                    folderSongs.AddFolderToListView(musicFilesListView);
                    AddColumnsToListView(new[] { "Song", "File Name", "Artist", "Album", "Genre" });
                    ListViewItemsSetIcon(2);
                    break;
                case "Artists":                    
                    folderArtists.AddFolderToListView(musicFilesListView);
                    AddColumnsToListView(new[] { e.Node.Text.ToString() });
                    ListViewItemsSetIcon(1);
                    break;
                case "Albums":
                    folderAlbums.AddFolderToListView(musicFilesListView);
                    AddColumnsToListView(new[] { e.Node.Text.ToString() });
                    ListViewItemsSetIcon(1);
                    break;
                case "Genres":
                    folderGenres.AddFolderToListView(musicFilesListView);
                    AddColumnsToListView(new[] { e.Node.Text.ToString() });
                    ListViewItemsSetIcon(1);
                    break;
            }
            CheckButtonsStateAndUpdate();
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
                    folderMusic.AddItemFromFile(file);
                }
                UpdateFolders(folderMusic);
                folderMusic.AddFolderToListView(musicFilesListView);
            }
            SetDefaultView();
            CheckButtonsStateAndUpdate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((musicFilesListView.Items.Count != 0) && (musicFilesListView.SelectedItems.Count != 0))
            {
                foreach (ListViewItem item in musicFilesListView.SelectedItems)
                {
                    string selection = item.Text;
                    if (libraryTreeView.SelectedNode != null)
                    {
                        switch (libraryTreeView.SelectedNode.Text)
                        {
                            case "Music":
                            case "Songs":
                                folderMusic.RemoveItem(folderMusic.GetItem(selection));
                                UpdateFolders(folderMusic);
                                folderMusic.AddFolderToListView(musicFilesListView);
                                ListViewItemsSetIcon(2);
                                break;
                            case "Artists":
                                folderArtists.RemoveSubFolder(selection);
                                UpdateFolders(folderArtists);
                                folderArtists.AddFolderToListView(musicFilesListView);
                                ListViewItemsSetIcon(1);
                                break;
                            case "Albums":
                                folderAlbums.RemoveSubFolder(selection);
                                UpdateFolders(folderAlbums);
                                folderAlbums.AddFolderToListView(musicFilesListView);
                                ListViewItemsSetIcon(1);
                                break;
                            case "Genres":
                                folderGenres.RemoveSubFolder(selection);
                                UpdateFolders(folderGenres);
                                folderGenres.AddFolderToListView(musicFilesListView);
                                ListViewItemsSetIcon(1);
                                break;
                        }
                    }
                    else
                    {
                        lastExpandedFolder.RemoveItemInSubfolder(lastSubfolder, lastExpandedFolder.GetItem(selection));
                        lastExpandedFolder.RemoveItem(lastExpandedFolder.GetItem(selection));
                        UpdateFolders(lastExpandedFolder);
                        lastExpandedFolder.ExpandSubFolderInListView(lastSubfolder, musicFilesListView);
                        if (lastExpandedFolder.GetSubFolder(lastSubfolder) == null)
                            ListViewItemsSetIcon(1);
                        else
                            ListViewItemsSetIcon(2);
                    }
                }
            }
            CheckButtonsStateAndUpdate();
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


        private void buttonIconsView_Click(object sender, EventArgs e)
        {
            musicFilesListView.View = View.LargeIcon;
            ChangeViewIcons();
        }

        private void buttonViewList_Click(object sender, EventArgs e)
        {
            musicFilesListView.View = View.List;
            musicFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ChangeViewIcons();
        }

        private void buttonDetailsView_Click(object sender, EventArgs e)
        {
            musicFilesListView.View = View.Details;
            musicFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ChangeViewIcons();
        }

        private void musicFilesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtonsStateAndUpdate();
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
                string item = musicFilesListView.SelectedItems[0].Text;
                switch (libraryTreeView.SelectedNode.Text)
                {
                    case "Music":
                    case "Songs":
                        StartPlaying();
                        break;
                    case "Artists":
                        lastSubfolder = folderArtists.GetSubFolder(musicFilesListView.SelectedItems[0].Text).folderName;
                        folderArtists.ExpandSubFolderInListView(musicFilesListView.SelectedItems[0].Text, musicFilesListView);
                        AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                        lastExpandedFolder = folderArtists;
                        libraryTreeView.SelectedNode = null;                       
                        ChangeViewIcons();
                        break;
                    case "Albums":
                        lastSubfolder = folderAlbums.GetSubFolder(musicFilesListView.SelectedItems[0].Text).folderName;
                        folderAlbums.ExpandSubFolderInListView(musicFilesListView.SelectedItems[0].Text, musicFilesListView);
                        AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                        lastExpandedFolder = folderAlbums;
                        libraryTreeView.SelectedNode = null;
                        ChangeViewIcons();
                        break;
                    case "Genres":
                        lastSubfolder = folderGenres.GetSubFolder(musicFilesListView.SelectedItems[0].Text).folderName;
                        folderGenres.ExpandSubFolderInListView(musicFilesListView.SelectedItems[0].Text, musicFilesListView);
                        AddColumnsToListView(new[] { "File Name", "Song", "Artist", "Album", "Genre" });
                        lastExpandedFolder = folderGenres;
                        libraryTreeView.SelectedNode = null;
                        ChangeViewIcons();
                        break;
                }
            }
            else
                StartPlaying();
            CheckButtonsStateAndUpdate();
        }

        private void SetDefaultView()
        {
            musicFilesListView.View = View.List;
            libraryTreeView.SelectedNode = libraryTreeView.Nodes[0];
            ListViewItemsSetIcon(2);
        }

        private void ChangeViewIcons()
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

        private void StartPlaying()
        {
            CutMusicLabel(folderMusic.GetItem(musicFilesListView.SelectedItems[0].Text).fileName);
            BassMethods.Play(folderMusic.GetItem(musicFilesListView.SelectedItems[0].Text).filePath, BassMethods.Volume);
            label2.Text = TimeSpan.FromSeconds(BassMethods.GetPosOfStream(BassMethods.Stream)).ToString();
            label3.Text = TimeSpan.FromSeconds(BassMethods.GetTimeOfStream(BassMethods.Stream)).ToString();
            Time_sl.Maximum = BassMethods.GetTimeOfStream(BassMethods.Stream);
            Time_sl.Value = BassMethods.GetPosOfStream(BassMethods.Stream);
            timer1.Enabled = true;
            isplaying = true;
            ispaused = false;
            SetPlayOrPauseImageAndGrayStop();
        }

        private void SetPlayOrPauseImageAndGrayStop()
        {
            if (isplaying)
            {
                Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_pause_9601;
                Stop_btn.Enabled = true;
                Stop_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_stop_7437;
            }
            else
            {
                if (ispaused)
                {
                    Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_play_2538;
                    Stop_btn.Enabled = true;
                    Stop_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_stop_7437;
                }
                else
                {
                    Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_play_2538;
                    Stop_btn.Enabled = false;
                    Stop_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_stop_7437_gray;
                }
            }
        }

        private void CheckButtonsStateAndUpdate()
        {
            if ((musicFilesListView.SelectedItems.Count == 0) && (!isplaying))
            {
                Play_btn.Enabled = false;
                Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_play_2538_gray;
                Stop_btn.Enabled = false;
                Stop_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_stop_7437_gray;
                buttonPreviousMusicFile.Enabled = false;
                buttonPreviousMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_rew_6538_gray;
                buttonNextMusicFile.Enabled = false;
                buttonNextMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_fwd_2900_gray;
            }
            else
            {
                if (musicFilesListView.SelectedItems.Count != 0)
                    selectedSongIndex = musicFilesListView.Items.IndexOf(musicFilesListView.SelectedItems[0]);
                Play_btn.Enabled = true;
                SetPlayOrPauseImageAndGrayStop();
                if ((selectedSongIndex != 0) && (selectedSongIndex != musicFilesListView.Items.Count - 1) && (musicFilesListView.Items.Count > 1))
                {
                    buttonPreviousMusicFile.Enabled = true;
                    buttonPreviousMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_rew_6538;
                    buttonNextMusicFile.Enabled = true;
                    buttonNextMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_fwd_2900;
                }
                else
                {
                    if ((selectedSongIndex == 0) && (musicFilesListView.Items.Count > 1))
                    {
                        buttonPreviousMusicFile.Enabled = false;
                        buttonPreviousMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_rew_6538_gray;
                        buttonNextMusicFile.Enabled = true;
                        buttonNextMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_fwd_2900;
                    }
                    if ((selectedSongIndex == musicFilesListView.Items.Count - 1) && (musicFilesListView.Items.Count > 1))
                    {
                        buttonPreviousMusicFile.Enabled = true;
                        buttonPreviousMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_rew_6538;
                        buttonNextMusicFile.Enabled = false;
                        buttonNextMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_fwd_2900_gray;
                    }
                    if (musicFilesListView.Items.Count < 1)
                    {
                        buttonPreviousMusicFile.Enabled = false;
                        buttonPreviousMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_rew_6538_gray;
                        buttonNextMusicFile.Enabled = false;
                        buttonNextMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_fwd_2900_gray;
                    }
                }
            }
            if (libraryTreeView.SelectedNode != null)
            {
                if ((libraryTreeView.SelectedNode.Text == "Artists") || (libraryTreeView.SelectedNode.Text == "Albums") || (libraryTreeView.SelectedNode.Text == "Genres"))
                {
                    Stop_btn.Enabled = false;
                    Stop_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_stop_7437_gray;
                    Play_btn.Enabled = false;
                    Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_play_2538_gray;
                    buttonPreviousMusicFile.Enabled = false;
                    buttonPreviousMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_rew_6538_gray;
                    buttonNextMusicFile.Enabled = false;
                    buttonNextMusicFile.BackgroundImage = global::BassPlayer.Properties.Resources.player_fwd_2900_gray;
                }
            }
        }

        private void CutMusicLabel(string file)
        {
            if (file.Length > 50)
            {
                labelFilePlaying.Text = file.Substring(0, 50) + "...";
            }
            else
            {
                labelFilePlaying.Text = file;
            }
        }
    }
}
