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

    public partial class FriendPlaylistLabel : UserControl {

        private Playlist playlist;

        private GroupBox GbSongs;

        public FriendPlaylistLabel(Playlist playlist, GroupBox GbSongs) {
            InitializeComponent();
            this.playlist = playlist;
            LbFriendPlaylist.Text = playlist.Name;
            LbFriendPlaylist.ForeColor = Color.DarkGray;
            this.GbSongs = GbSongs;
        }

        private void LbFriendPlaylist_Click(Object sender, EventArgs e) {
            GbSongs.Controls.Clear();
            GbSongs.Controls.Add(new FriendPlaylistView(playlist));
        }

        private void LbFriendPlaylist_MouseEnter(Object sender, EventArgs e) {
            LbFriendPlaylist.ForeColor = Color.Black;
        }

        private void LbFriendPlaylist_MouseLeave(Object sender, EventArgs e) {
            LbFriendPlaylist.ForeColor = Color.DarkGray;
        }
    }
}
