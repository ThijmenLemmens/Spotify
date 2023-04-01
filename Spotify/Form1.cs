using Spotify.Properties;

namespace Spotify {
    public partial class Form1 : Form {

        private bool playingSong = false;

        public Form1() {
            InitializeComponent();
        }

        private void BtnPlayStop_Click(Object sender, EventArgs e) {

            if (!playingSong) {
                BtnPlayStop.Image.Dispose();
                BtnPlayStop.Image = Resource.play_buttton;
                playingSong = true;
            } else {
                BtnPlayStop.Image.Dispose();
                BtnPlayStop.Image = Resource.pause;
                playingSong = false;
            }

        }

        private void BtnNext_Click(Object sender, EventArgs e) {

        }

        private void BtnPrev_Click(Object sender, EventArgs e) {

        }
    }
}