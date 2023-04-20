using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.sql;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System.Text;

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

            LbOpnamenName.Text = opnamen.name;

            LbArtiestName.Text = Util.setOwners(opnamen);

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
            SqlQuery.addSongToPlaylist(playlists, CbAddToPlaylist.SelectedIndex, opnamen);
        }

        private void PbPlay_Click(Object sender, EventArgs e) {
            Program.form1.setLabels(opnamen.name, Util.setOwners(opnamen));
            Task.Run(() => MediaPlayer.play(opnamen));
        }
    }
}
