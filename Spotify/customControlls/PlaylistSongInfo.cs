using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;

namespace Spotify.customControlls {

    public partial class PlaylistSongInfo : UserControl {

        private MySqlConnection con = Database.Instance().Connection;

        private Opnamen opnamen;

        private Playlist playlist;

        private List<Playlist> playlists = Form1.playlists;

        public PlaylistSongInfo(Opnamen opnamen, Playlist playlist) {
            InitializeComponent();
            this.opnamen = opnamen;
            this.playlist = playlist;

            this.LbOpnamenName.Text = opnamen.name;

            playlists.ForEach(playlist => {
                CbAddToPlaylist.Items.Add(playlist.Name);
            });
        }

        private void BtnRemove_Click(Object sender, EventArgs e) {
            playlist.items.Remove(opnamen);

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE playlist SET opnamen_ids = ?opnamen_ids WHERE id = ?id";

            cmd.Parameters.AddWithValue("?opnamen_ids", JsonConvert.SerializeObject(playlist.items));
            cmd.Parameters.AddWithValue("?id", playlist.id);
            
            cmd.ExecuteNonQuery();

            this.Dispose();
        }

        private void CbAddToPlaylist_SelectedIndexChanged(Object sender, EventArgs e) {
            playlists[CbAddToPlaylist.SelectedIndex].items.Add(opnamen);

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE playlist SET opnamen_ids = ?opnamen_ids WHERE id = ?id";

            List<Int32> ids = new();

            playlists[CbAddToPlaylist.SelectedIndex].items.ForEach(opnamen => {
                ids.Add(opnamen.id);
            });

            cmd.Parameters.AddWithValue("?opnamen_ids", JsonConvert.SerializeObject(ids));
            cmd.Parameters.AddWithValue("?id", playlists[CbAddToPlaylist.SelectedIndex].id);

            cmd.ExecuteNonQuery();
        }

        private void pictureBox1_Click(Object sender, EventArgs e) {

        }
    }
}
