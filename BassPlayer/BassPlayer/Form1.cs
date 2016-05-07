using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BassPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Eject_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Vars.Files.Add(openFileDialog1.FileName);
            PlayList.Items.Add(Vars.GetFileName(openFileDialog1.FileName));
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if ((PlayList.Items.Count !=0) && (PlayList.SelectedIndex != -1))
            {
                string current = Vars.Files[PlayList.SelectedIndex];
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
    }
}
