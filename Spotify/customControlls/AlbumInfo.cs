using Spotify.util.afspeellijsten;
using System.Text;

namespace Spotify.customControlls {

    public partial class AlbumInfo : UserControl {

        private Album album;

        private GroupBox GbMain;

        public AlbumInfo(Album album, GroupBox GbMain) {
            InitializeComponent();

            this.album = album;

            LbAlbumName.Text = album.Name;
            setOwners();

            this.GbMain = GbMain;
        }

        private void BtnOpenAlbum_Click(Object sender, EventArgs e) {
            GbMain.Controls.Clear();
            GbMain.Controls.Add(new AlbumView(album));
        }

        /// <summary>
        /// returns a string with the owners names 
        /// </summary>
        private void setOwners() {
            StringBuilder builder = new();

            for (Int32 i = 0; i < album.artiestNames.Count; i++) {
                if (i == 0) {
                    builder.Append(album.artiestNames[i]);
                    continue;
                }

                builder.Append($", {album.artiestNames[i]}");
            }

            LbArtiestName.Text = builder.ToString();
        }
    }
}
