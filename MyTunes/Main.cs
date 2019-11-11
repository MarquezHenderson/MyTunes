using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTunes
{
    public partial class fm_Main : Form
    {
        public fm_Main()
        {
            InitializeComponent();
        }
        List<String> playlist;
        OpenFileDialog ofd = new OpenFileDialog();
        Mplayer player;
        
        //set ofd params
      
        private void btn_Open_Click(object sender, EventArgs e)
        {
            ofd.Filter = "MP3|*.mp3"; 
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //lb_Filename.Text = ofd.SafeFileName;
                
                //wired-up mp3 file to player
                player = new Mplayer(ofd.FileName);

                //add to the  listbox
                setPlaylist(ofd.SafeFileName);

                
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.open();
                player.Play();
            }
            else
            {
                lb_Filename.Text = "Path is empty.";
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void list_playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox songName = (ListBox)sender;
            //lb_Filename.Text = songName.SelectedItem.ToString();
            lb_Filename.Text = songName.Text;
        }
        void setPlaylist(string filename)
        {
            ///playlist = ofd.SafeFileName;
            playlist = new List<string>();
            playlist.Add(ofd.SafeFileName);
            list_playlist.Items.Add(filename);

            lab_song_count.Text = list_playlist.Items.Count.ToString();
                

        }
    }
}
