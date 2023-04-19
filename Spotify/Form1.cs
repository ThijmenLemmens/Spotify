using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.customControlls;
using Spotify.Properties;
using Spotify.sql;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System.Data.SqlTypes;
using System.Security.Policy;
using System.Windows.Forms;

namespace Spotify {

    public partial class Form1 : Form {

        private MySqlConnection con = Database.Instance().Connection;

        private bool playingSong = false;

        public static Account account;

        public static List<Playlist> playlists;

        public static bool repeat = false;

        public Form1(Account account) {
            Form1.account = account;
            InitializeComponent();
            this.Text = $"Spotify | {account.name}";
            playlists = new();
            SqlQuery.getAllFriends(account);
            playlists = SqlQuery.getPlayList(account);
            addSongs();
            GbMainSection.Controls.Add(new HomeView());

            MediaPlayer.lbArtiest = LbArtiest;
            MediaPlayer.lbSongName = LbSongName;

            FlpPlaylist.HorizontalScroll.Maximum = 0;
            FlpPlaylist.AutoScroll = false;
            FlpPlaylist.VerticalScroll.Visible = false;
            FlpPlaylist.AutoScroll = true;
        }

        private void BtnPlayStop_Click(Object sender, EventArgs e) {

            if (!playingSong) {
                BtnPlayStop.Image.Dispose();
                BtnPlayStop.Image = Resource.play_buttton;
                MediaPlayer.pause();
                playingSong = true;
            } else {
                BtnPlayStop.Image.Dispose();
                BtnPlayStop.Image = Resource.pause;
                MediaPlayer.resume();
                playingSong = false;
            }

        }

        private void BtnHome_Click(Object sender, EventArgs e) {
            GbMainSection.Controls.Clear();
            GbMainSection.Controls.Add(new HomeView());
        }

        private void BtnCreatePlayList_Click(Object sender, EventArgs e) {

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO playlist (name, owner_ids) VALUES (?name, ?owner_ids)";

            List<Int32> list = new() {
                account.id
            };

            cmd.Parameters.AddWithValue("?name", "new Playlist");
            cmd.Parameters.AddWithValue("?owner_ids", JsonConvert.SerializeObject(list));

            cmd.ExecuteNonQuery();

            playlists = SqlQuery.getPlayList(account);
            updatePlaylist();
            addSongs();
        }

        private void BtnSearch_Click(Object sender, EventArgs e) {
            GbMainSection.Controls.Clear();
            GbMainSection.Controls.Add(new SearchView(GbMainSection));
        }

        private void BtnFriends_Click(Object sender, EventArgs e) {
            GbMainSection.Controls.Clear();
            GbMainSection.Controls.Add(new FriendsView());
        }

        private void Form1_Load(Object sender, EventArgs e) {
            updatePlaylist();
        }

        private void Form1_FormClosed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Form1_Shown(Object sender, EventArgs e) {

        }

        private void addSongs() {
            playlists.ForEach(playlist => {
                if (playlist.rawJson != null)
                    SqlQuery.getAllSongs(playlist);
            });
        }

        private void updatePlaylist() {
            FlpPlaylist.Controls.Clear();
            playlists.ForEach(playlist => {
                FlpPlaylist.Controls.Add(new PlaylistLabel(playlist, GbMainSection));
            });
        }

        private void CbRepeat_CheckedChanged(Object sender, EventArgs e) {
            if (CbRepeat.Checked)
                repeat = true;
            else
                repeat = false;
        }

        public void setLabels(string name, string artiest) {
            LbSongName.Text = name;
            LbArtiest.Text = artiest;
        }
    }
}