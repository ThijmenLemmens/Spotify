using Spotify.sql;
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
    public partial class FriendSongContainer : UserControl {

        private List<Playlist> playlists = Form1.playlists;

        private Opnamen opnamen;

        public FriendSongContainer(Opnamen opnamen) {
            InitializeComponent();

            this.opnamen = opnamen;

            LbSongName.Text = this.opnamen.name;
            LbArtiestName.Text = Util.setOwners(this.opnamen);

            playlists.ForEach(playlist => {
                CbPlaylist.Items.Add(playlist.Name);
            });
        }

        /// <summary>
        /// plays a song 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbPlay_Click(Object sender, EventArgs e) {
            Program.form1.setLabels(opnamen.name, Util.setOwners(opnamen));
            Task.Run(() => MediaPlayer.play(opnamen));
        }

        private void CbPlaylist_SelectedIndexChanged(Object sender, EventArgs e) {
            SqlQuery.addSongToPlaylist(playlists, CbPlaylist.SelectedIndex, opnamen);
        }
    }
}
