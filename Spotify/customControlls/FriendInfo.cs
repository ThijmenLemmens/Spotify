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

    public partial class FriendInfo : UserControl {

        private Account account;

        public FriendInfo(Account account) {
            InitializeComponent();

            this.account = account;

            loadPlaylist();
        }

        private void FriendInfo_Load(Object sender, EventArgs e) {

        }

        private void loadPlaylist() {
            account.playlists.ForEach(playlist => {
                FlpFriendPlaylist.Controls.Add(new FriendPlaylistLabel(playlist, GbSongs));
            });
        }
    }
}
