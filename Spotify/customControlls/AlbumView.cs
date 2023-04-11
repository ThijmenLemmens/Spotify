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

    public partial class AlbumView : UserControl {

        private MySqlConnection con = Database.Instance().Connection;

        private List<Playlist> playlists = Form1.playlists;

        private Album album;

        public AlbumView(Album album) {
            InitializeComponent();

            this.album = album;

            LbAlbumName.Text = album.Name;
            setOwners();
            fillLayoutOpnamen();

            playlists.ForEach(playlist => {
                CbAddToPlaylist.Items.Add(playlist.Name);
            });
        }

        private void BtnCopyList_Click(Object sender, EventArgs e) {

        }

        private void setOwners() {
            StringBuilder builder = new();

            for (Int32 i = 0; i < album.artiestNames.Count; i++) {
                if (i == 0) {
                    builder.Append(album.artiestNames[i]);
                    continue;
                }

                builder.Append($", {album.artiestNames[i]}");
            }

            LbCreator.Text = builder.ToString();
        }

        private void fillLayoutOpnamen() {
            album.items.ForEach(opnamen => {
                FlpOpnamens.Controls.Add(new SongInfoContainer(opnamen));
            });
        }

        private void CbAddToPlaylist_SelectedIndexChanged(Object sender, EventArgs e) {

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE playlist SET opnamen_ids = ?opnamen_ids WHERE id = ?id";

            List<Int32> ids = new();

            playlists[CbAddToPlaylist.SelectedIndex].items.ForEach(opnamen => {
                ids.Add(opnamen.id);
            });

            album.items.ForEach(opnamen => {
                ids.Add(opnamen.id);
                playlists[CbAddToPlaylist.SelectedIndex].items.Add(opnamen);
            });

            cmd.Parameters.AddWithValue("?opnamen_ids", JsonConvert.SerializeObject(ids));
            cmd.Parameters.AddWithValue("?id", playlists[CbAddToPlaylist.SelectedIndex].id);

            cmd.ExecuteNonQuery();

        }
    }
}
