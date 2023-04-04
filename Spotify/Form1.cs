using Spotify.Properties;

namespace Spotify {
    public partial class Form1 : Form {

        private bool playingSong = false;

        private Account account;

        public Form1(Account account) {
            this.account = account;
            InitializeComponent();
            this.Text = $"Spotify | {account.name}";
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

        private void BtnHome_Click(Object sender, EventArgs e) {

        }

        private void Form1_FormClosed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}