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
    public partial class FriendPlaylistView : UserControl {

        private Playlist playlist;

        private List<Playlist> playlists = Form1.playlists;

        public FriendPlaylistView(Playlist playlist) {
            InitializeComponent();

            this.playlist = playlist;

            LbPlaylistName.Text = playlist.Name;
            LbOwners.Text = Util.setOwners(playlist);

            loadPlaylist();

            playlists.ForEach(playlist => {
                CbCompare.Items.Add(playlist.Name);
            });
        }

        private void BtnCompare_Click(Object sender, EventArgs e) {

        }

        private void loadPlaylist() {
            playlist.items.ForEach(opnamen => {
                FlpPlaylist.Controls.Add(new FriendSongContainer(opnamen));
            });
        }

        private void CbCompare_SelectedIndexChanged(Object sender, EventArgs e) {
            List<Opnamen> opnamens = Util.comparePlaylist(playlist, playlists[CbCompare.SelectedIndex]);

            StringBuilder builder = new();

            builder.AppendLine("This songs Do you have similar!");

            opnamens.ForEach(opnamen => {
                builder.Append($"{opnamen.name}, ");
            });

            MessageBox.Show(builder.ToString());
        }
    }
}
