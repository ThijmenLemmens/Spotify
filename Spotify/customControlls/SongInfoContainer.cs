using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify.customControlls {

    public partial class SongInfoContainer : UserControl {

        private List<Playlist> playlists = Form1.playlists; 

        private Opnamen opnamen;

        private MySqlConnection con = Database.Instance().Connection;

        public SongInfoContainer(Opnamen opnamen) {
            InitializeComponent();
            this.opnamen = opnamen;

            LbSongName.Text = opnamen.name;

            playlists.ForEach(playlist => {
                CbPlaylist.Items.Add(playlist.Name);
            });
        }
         
        private void PbPlay_Click(Object sender, EventArgs e) {
            Task.Run(() => MediaPlayer.play(opnamen.url));
        }

        private void CbPlaylist_SelectedIndexChanged(Object sender, EventArgs e) {
            playlists[CbPlaylist.SelectedIndex].items.Add(opnamen);

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE playlist SET opnamen_ids = ?opnamen_ids WHERE id = ?id";

            List<Int32> ids = new();

            playlists[CbPlaylist.SelectedIndex].items.ForEach(opnamen => {
                ids.Add(opnamen.id);
            });

            cmd.Parameters.AddWithValue("?opnamen_ids", JsonConvert.SerializeObject(ids));
            cmd.Parameters.AddWithValue("?id", playlists[CbPlaylist.SelectedIndex].id);

            cmd.ExecuteNonQuery();
        }
    }
}
