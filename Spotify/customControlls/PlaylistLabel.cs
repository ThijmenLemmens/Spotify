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

    public partial class PlaylistLabel : UserControl {

        private Playlist playlist;

        private GroupBox gbMainSection;

        public PlaylistLabel(Playlist playlist, GroupBox gbMainSection) {
            InitializeComponent();
            this.playlist = playlist;
            LbPlaylistName.Text = playlist.Name;
            LbPlaylistName.ForeColor = Color.DarkGray;
            this.gbMainSection = gbMainSection;
        }

        private void LbPlaylistName_Click(Object sender, EventArgs e) {
            gbMainSection.Controls.Clear();
            gbMainSection.Controls.Add(new PlaylistView(playlist, this));
        }

        private void LbPlaylistName_MouseEnter(Object sender, EventArgs e) {
            LbPlaylistName.ForeColor = Color.Black;
            //LbPlaylistName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void LbPlaylistName_MouseLeave(Object sender, EventArgs e) {
            LbPlaylistName.ForeColor = Color.DarkGray;
            //LbPlaylistName.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }
    }
}
