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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Songs", 0, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Artists", 0, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Albums", 0, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Genres", 0, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Music", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.Eject_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
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
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFilePlaying = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eject_btn
            // 
            this.Eject_btn.BackColor = System.Drawing.Color.Transparent;
            this.Eject_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eject_btn.BackgroundImage")));
            this.Eject_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eject_btn.Location = new System.Drawing.Point(179, 12);
            this.Eject_btn.Name = "Eject_btn";
            this.Eject_btn.Size = new System.Drawing.Size(51, 52);
            this.Eject_btn.TabIndex = 3;
            this.Eject_btn.UseVisualStyleBackColor = false;
            this.Eject_btn.Click += new System.EventHandler(this.Eject_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Stop_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_btn.BackgroundImage")));
            this.Stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop_btn.Location = new System.Drawing.Point(122, 12);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(51, 52);
            this.Stop_btn.TabIndex = 2;
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_click);
            // 
            // Play_btn
            // 
            this.Play_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play_btn.BackgroundImage")));
            this.Play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_btn.Location = new System.Drawing.Point(67, 12);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(49, 52);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
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
            this.Vol_sl.Location = new System.Drawing.Point(265, 27);
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
            this.Time_sl.Location = new System.Drawing.Point(430, 340);
            this.Time_sl.Name = "Time_sl";
            this.Time_sl.Size = new System.Drawing.Size(390, 22);
            this.Time_sl.SmallChange = ((uint)(1u));
            this.Time_sl.TabIndex = 4;
            this.Time_sl.Text = "Time_sl";
            this.Time_sl.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.Time_sl.Value = 0;
            this.Time_sl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Position_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 76);
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
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Songs";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Songs";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Artists";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Artists";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Albums";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Albums";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Genres";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Genres";
            treeNode5.Name = "Music";
            treeNode5.Text = "Music";
            this.libraryTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.libraryTreeView.SelectedImageIndex = 0;
            this.libraryTreeView.Size = new System.Drawing.Size(277, 236);
            this.libraryTreeView.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_cyan_open_6776.ico");
            this.imageList1.Images.SetKeyName(1, "folder_sound_4752.ico");
            // 
            // musicFilesListView
            // 
            this.musicFilesListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.musicFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnArtist,
            this.columnAlbum,
            this.columnGenre});
            this.musicFilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicFilesListView.Location = new System.Drawing.Point(0, 0);
            this.musicFilesListView.Name = "musicFilesListView";
            this.musicFilesListView.Size = new System.Drawing.Size(551, 236);
            this.musicFilesListView.SmallImageList = this.imageList1;
            this.musicFilesListView.TabIndex = 0;
            this.musicFilesListView.UseCompatibleStateImageBehavior = false;
            this.musicFilesListView.View = System.Windows.Forms.View.List;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 400;
            // 
            // columnArtist
            // 
            this.columnArtist.Text = "Artist";
            // 
            // columnAlbum
            // 
            this.columnAlbum.Text = "Album";
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Genre";
            // 
            // labelFilePlaying
            // 
            this.labelFilePlaying.AutoSize = true;
            this.labelFilePlaying.Location = new System.Drawing.Point(12, 340);
            this.labelFilePlaying.Name = "labelFilePlaying";
            this.labelFilePlaying.Size = new System.Drawing.Size(79, 13);
            this.labelFilePlaying.TabIndex = 10;
            this.labelFilePlaying.Text = "labelFilePlaying";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(856, 392);
            this.Controls.Add(this.labelFilePlaying);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vol_sl);
            this.Controls.Add(this.Time_sl);
            this.Controls.Add(this.Eject_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Play_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Library";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FormClosing += MainForm_FormClosing;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Eject_btn;
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
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnArtist;
        private System.Windows.Forms.ColumnHeader columnAlbum;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.Label labelFilePlaying;
    }
}

