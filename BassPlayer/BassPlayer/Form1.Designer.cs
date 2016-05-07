namespace BassPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayList = new System.Windows.Forms.ListBox();
            this.Eject_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            this.Time_sl = new MB.Controls.ColorSlider();
            this.Vol_sl = new MB.Controls.ColorSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlayList
            // 
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(12, 22);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(399, 199);
            this.PlayList.TabIndex = 0;
            // 
            // Eject_btn
            // 
            this.Eject_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Eject_btn.BackgroundImage = global::BassPlayer.Properties.Resources.arrow_down_6345;
            this.Eject_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eject_btn.Location = new System.Drawing.Point(124, 294);
            this.Eject_btn.Name = "Eject_btn";
            this.Eject_btn.Size = new System.Drawing.Size(30, 30);
            this.Eject_btn.TabIndex = 3;
            this.Eject_btn.UseVisualStyleBackColor = false;
            this.Eject_btn.Click += new System.EventHandler(this.Eject_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stop_btn.BackgroundImage = global::BassPlayer.Properties.Resources.gtk_media_stop_3075;
            this.Stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop_btn.Location = new System.Drawing.Point(45, 294);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(30, 30);
            this.Stop_btn.TabIndex = 2;
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_click);
            // 
            // Play_btn
            // 
            this.Play_btn.BackgroundImage = global::BassPlayer.Properties.Resources.play_mark_3482;
            this.Play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_btn.Location = new System.Drawing.Point(12, 294);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(30, 30);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Time_sl
            // 
            this.Time_sl.BackColor = System.Drawing.Color.Transparent;
            this.Time_sl.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.Time_sl.LargeChange = ((uint)(5u));
            this.Time_sl.Location = new System.Drawing.Point(12, 244);
            this.Time_sl.Name = "Time_sl";
            this.Time_sl.Size = new System.Drawing.Size(390, 22);
            this.Time_sl.SmallChange = ((uint)(1u));
            this.Time_sl.TabIndex = 4;
            this.Time_sl.Text = "Time_sl";
            this.Time_sl.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.Time_sl.Value = 0;
            this.Time_sl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Position_Scroll);
            // 
            // Vol_sl
            // 
            this.Vol_sl.BackColor = System.Drawing.Color.Transparent;
            this.Vol_sl.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.Vol_sl.LargeChange = ((uint)(5u));
            this.Vol_sl.Location = new System.Drawing.Point(278, 304);
            this.Vol_sl.Name = "Vol_sl";
            this.Vol_sl.Size = new System.Drawing.Size(124, 13);
            this.Vol_sl.SmallChange = ((uint)(1u));
            this.Vol_sl.TabIndex = 5;
            this.Vol_sl.Text = "Vol_sl";
            this.Vol_sl.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.Vol_sl.Value = 100;
            this.Vol_sl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderVolume_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 228);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(418, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vol_sl);
            this.Controls.Add(this.Time_sl);
            this.Controls.Add(this.Eject_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.PlayList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BassPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Eject_btn;
        private MB.Controls.ColorSlider Time_sl;
        private MB.Controls.ColorSlider Vol_sl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

