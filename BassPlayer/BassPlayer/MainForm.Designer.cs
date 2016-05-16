namespace MusicLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Songs", 0, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Artists", 0, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Albums", 0, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Genres", 0, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Music", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Vol_sl = new MB.Controls.ColorSlider();
            this.Time_sl = new MB.Controls.ColorSlider();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.libraryTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.musicFilesListView = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.labelFilePlaying = new System.Windows.Forms.Label();
            this.labelView = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPreviousMusicFile = new System.Windows.Forms.Button();
            this.buttonNextMusicFile = new System.Windows.Forms.Button();
            this.buttonDetailsView = new System.Windows.Forms.Button();
            this.buttonIconsView = new System.Windows.Forms.Button();
            this.buttonViewList = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(760, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Vol_sl
            // 
            this.Vol_sl.BackColor = System.Drawing.Color.Transparent;
            this.Vol_sl.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.Vol_sl.LargeChange = ((uint)(5u));
            this.Vol_sl.Location = new System.Drawing.Point(425, 49);
            this.Vol_sl.Name = "Vol_sl";
            this.Vol_sl.Size = new System.Drawing.Size(122, 18);
            this.Vol_sl.SmallChange = ((uint)(1u));
            this.Vol_sl.TabIndex = 5;
            this.Vol_sl.Text = "Vol_sl";
            this.Vol_sl.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.Vol_sl.Value = 100;
            this.Vol_sl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderVolume_Scroll);
            // 
            // Time_sl
            // 
            this.Time_sl.BackColor = System.Drawing.Color.Transparent;
            this.Time_sl.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.Time_sl.LargeChange = ((uint)(5u));
            this.Time_sl.Location = new System.Drawing.Point(354, 362);
            this.Time_sl.Name = "Time_sl";
            this.Time_sl.Size = new System.Drawing.Size(434, 19);
            this.Time_sl.SmallChange = ((uint)(1u));
            this.Time_sl.TabIndex = 4;
            this.Time_sl.Text = "Time_sl";
            this.Time_sl.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.Time_sl.Value = 0;
            this.Time_sl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Position_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 98);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.libraryTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.musicFilesListView);
            this.splitContainer1.Size = new System.Drawing.Size(832, 236);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 9;
            // 
            // libraryTreeView
            // 
            this.libraryTreeView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.libraryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryTreeView.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.libraryTreeView.ImageIndex = 0;
            this.libraryTreeView.ImageList = this.imageList1;
            this.libraryTreeView.Location = new System.Drawing.Point(0, 0);
            this.libraryTreeView.Name = "libraryTreeView";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Songs";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Songs";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "Artists";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Artists";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "Albums";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Albums";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "Genres";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Genres";
            treeNode10.Name = "Music";
            treeNode10.Text = "Music";
            this.libraryTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.libraryTreeView.SelectedImageIndex = 0;
            this.libraryTreeView.Size = new System.Drawing.Size(277, 236);
            this.libraryTreeView.TabIndex = 0;
            this.libraryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.libraryTreeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_cyan_open_6776.ico");
            this.imageList1.Images.SetKeyName(1, "folder_sound_4752.ico");
            this.imageList1.Images.SetKeyName(2, "knotify_5361.ico");
            // 
            // musicFilesListView
            // 
            this.musicFilesListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.musicFilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicFilesListView.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicFilesListView.LargeImageList = this.imageList2;
            this.musicFilesListView.Location = new System.Drawing.Point(0, 0);
            this.musicFilesListView.Name = "musicFilesListView";
            this.musicFilesListView.Size = new System.Drawing.Size(551, 236);
            this.musicFilesListView.SmallImageList = this.imageList1;
            this.musicFilesListView.TabIndex = 0;
            this.musicFilesListView.UseCompatibleStateImageBehavior = false;
            this.musicFilesListView.View = System.Windows.Forms.View.List;
            this.musicFilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.musicFilesListView_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "knotify_5164.ico");
            this.imageList2.Images.SetKeyName(1, "folder_sound_3364.ico");
            // 
            // labelFilePlaying
            // 
            this.labelFilePlaying.AutoSize = true;
            this.labelFilePlaying.Font = new System.Drawing.Font("Tahoma", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePlaying.Location = new System.Drawing.Point(17, 360);
            this.labelFilePlaying.Name = "labelFilePlaying";
            this.labelFilePlaying.Size = new System.Drawing.Size(20, 16);
            this.labelFilePlaying.TabIndex = 10;
            this.labelFilePlaying.Text = "...";
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelView.Location = new System.Drawing.Point(639, 49);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(46, 21);
            this.labelView.TabIndex = 11;
            this.labelView.Text = "View";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 27);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.addFolderToolStripMenuItem.Text = "Add Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPreviousMusicFile
            // 
            this.buttonPreviousMusicFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPreviousMusicFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPreviousMusicFile.BackgroundImage")));
            this.buttonPreviousMusicFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPreviousMusicFile.Location = new System.Drawing.Point(17, 34);
            this.buttonPreviousMusicFile.Name = "buttonPreviousMusicFile";
            this.buttonPreviousMusicFile.Size = new System.Drawing.Size(49, 52);
            this.buttonPreviousMusicFile.TabIndex = 2;
            this.buttonPreviousMusicFile.UseVisualStyleBackColor = false;
            this.buttonPreviousMusicFile.Click += new System.EventHandler(this.buttonPreviousMusicFile_Click);
            // 
            // buttonNextMusicFile
            // 
            this.buttonNextMusicFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNextMusicFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNextMusicFile.BackgroundImage")));
            this.buttonNextMusicFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextMusicFile.Location = new System.Drawing.Point(179, 35);
            this.buttonNextMusicFile.Name = "buttonNextMusicFile";
            this.buttonNextMusicFile.Size = new System.Drawing.Size(49, 52);
            this.buttonNextMusicFile.TabIndex = 2;
            this.buttonNextMusicFile.UseVisualStyleBackColor = false;
            this.buttonNextMusicFile.Click += new System.EventHandler(this.buttonNextMusicFile_Click);
            // 
            // buttonDetailsView
            // 
            this.buttonDetailsView.BackColor = System.Drawing.Color.White;
            this.buttonDetailsView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDetailsView.BackgroundImage")));
            this.buttonDetailsView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDetailsView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDetailsView.Location = new System.Drawing.Point(784, 35);
            this.buttonDetailsView.Name = "buttonDetailsView";
            this.buttonDetailsView.Size = new System.Drawing.Size(49, 52);
            this.buttonDetailsView.TabIndex = 14;
            this.buttonDetailsView.UseVisualStyleBackColor = false;
            this.buttonDetailsView.Click += new System.EventHandler(this.buttonDetailsView_Click);
            // 
            // buttonIconsView
            // 
            this.buttonIconsView.BackColor = System.Drawing.Color.White;
            this.buttonIconsView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIconsView.BackgroundImage")));
            this.buttonIconsView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIconsView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIconsView.Location = new System.Drawing.Point(690, 35);
            this.buttonIconsView.Name = "buttonIconsView";
            this.buttonIconsView.Size = new System.Drawing.Size(49, 52);
            this.buttonIconsView.TabIndex = 13;
            this.buttonIconsView.UseVisualStyleBackColor = false;
            this.buttonIconsView.Click += new System.EventHandler(this.buttonIconsView_Click);
            // 
            // buttonViewList
            // 
            this.buttonViewList.BackColor = System.Drawing.Color.White;
            this.buttonViewList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewList.BackgroundImage")));
            this.buttonViewList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonViewList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewList.Location = new System.Drawing.Point(737, 35);
            this.buttonViewList.Name = "buttonViewList";
            this.buttonViewList.Size = new System.Drawing.Size(49, 52);
            this.buttonViewList.TabIndex = 12;
            this.buttonViewList.UseVisualStyleBackColor = false;
            this.buttonViewList.Click += new System.EventHandler(this.buttonViewList_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Stop_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_btn.BackgroundImage")));
            this.Stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Stop_btn.Location = new System.Drawing.Point(123, 35);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(51, 52);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_click);
            // 
            // Play_btn
            // 
            this.Play_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.player_play_2538;
            this.Play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_btn.Location = new System.Drawing.Point(70, 35);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(49, 52);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.UseVisualStyleBackColor = false;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(856, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPreviousMusicFile);
            this.Controls.Add(this.buttonNextMusicFile);
            this.Controls.Add(this.buttonDetailsView);
            this.Controls.Add(this.buttonIconsView);
            this.Controls.Add(this.buttonViewList);
            this.Controls.Add(this.labelView);
            this.Controls.Add(this.labelFilePlaying);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vol_sl);
            this.Controls.Add(this.Time_sl);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Library";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Stop_btn;
        private MB.Controls.ColorSlider Time_sl;
        private MB.Controls.ColorSlider Vol_sl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView libraryTreeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView musicFilesListView;
        private System.Windows.Forms.Label labelFilePlaying;
        private System.Windows.Forms.Label labelView;
        private System.Windows.Forms.Button buttonViewList;
        private System.Windows.Forms.Button buttonIconsView;
        private System.Windows.Forms.Button buttonDetailsView;
        private System.Windows.Forms.Button buttonNextMusicFile;
        private System.Windows.Forms.Button buttonPreviousMusicFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

