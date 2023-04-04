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

        public PlaylistLabel() {
            InitializeComponent();
        }

        private void LbPlaylistName_Click(Object sender, EventArgs e) {

        }

        private void LbPlaylistName_MouseEnter(Object sender, EventArgs e) {
            LbPlaylistName.Font = new Font(DefaultFont, FontStyle.Bold);
        }

        private void LbPlaylistName_MouseLeave(Object sender, EventArgs e) {
            LbPlaylistName.Font = new Font(DefaultFont, FontStyle.Regular);
        }
    }
}
