using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.sql;
using Spotify.util.afspeellijsten;
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
    public partial class PlaylistView : UserControl {

        private MySqlConnection con = Database.Instance().Connection;

        private Playlist playlist;

        private List<Playlist> playlists = Form1.playlists;

        private PlaylistLabel playlistLabel;


        public PlaylistView(Playlist playlist, PlaylistLabel playlistLabel) {
            InitializeComponent();
            this.playlist = playlist;
            LbPlaylistName.Text = playlist.Name;
            this.playlistLabel = playlistLabel;
            setOwners();
        }

        private void PlaylistView_Load(Object sender, EventArgs e) {
            addSongToContainer();
        }

        private void BtnDelete_Click(Object sender, EventArgs e) {
            playlist.owners.Remove(Form1.account);

            MySqlCommand cmd = con.CreateCommand();

            if (playlist.owners.Count == 1) {
                cmd.CommandText = "DELETE FROM playlist WHERE id = ?id";    
            } else {
                cmd.CommandText = "UPDATE playlist SET owner_ids = ?owner_ids WHERE id = ?id";
                cmd.Parameters.AddWithValue("?owner_ids", JsonConvert.SerializeObject(playlist.owners));
            }

            cmd.Parameters.AddWithValue("?id", playlist.id);

            cmd.ExecuteNonQuery();

            Dispose();

            playlists.Remove(playlist);

            playlistLabel.Dispose();
        }

        private void addSongToContainer() {
            playlist.items.ForEach(opnamen => {
                FlpOpnamens.Controls.Add(new PlaylistSongInfo(opnamen, playlist));
            });
        }

        private void setOwners() {
            StringBuilder builder = new();

            for (Int32 i = 0; i < playlist.owners.Count; i++) {
                if (i == 0) {
                    builder.Append(playlist.owners[i].name);
                    continue;
                }

                builder.Append($", {playlist.owners[i].name}");
            }

            LbCreator.Text = builder.ToString();
        }

        private void LbPlaylistName_Click(Object sender, EventArgs e) {

        }

        private void BtnCopyList_Click(Object sender, EventArgs e) {

        }

        private void BtnCopyListInto_Click(Object sender, EventArgs e) {

        }

        private void BtnCompare_Click(Object sender, EventArgs e) {

        }
    }
}
