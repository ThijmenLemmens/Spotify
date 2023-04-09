using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.customControlls;
using Spotify.Properties;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Spotify {

    public partial class Form1 : Form {

        private MySqlConnection con = Database.Instance().Connection;

        private bool playingSong = false;

        public static Account account;

        public static List<Playlist> playlists;

        public Form1(Account account) {
            Form1.account = account;
            InitializeComponent();
            this.Text = $"Spotify | {account.name}";
            playlists = new();
            playlists = getPlayList();
            addSongs();

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

        private void BtnNext_Click(Object sender, EventArgs e) {

        }

        private void BtnPrev_Click(Object sender, EventArgs e) {

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

            playlists = getPlayList();
            updatePlaylist();
        }

        private void BtnSearch_Click(Object sender, EventArgs e) {
            GbMainSection.Controls.Clear();
            GbMainSection.Controls.Add(new SearchView());
        }

        private void Form1_Load(Object sender, EventArgs e) {
           updatePlaylist();
        }

        private void Form1_FormClosed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Form1_Shown(Object sender, EventArgs e) {
            
        }

        private List<Playlist> getPlayList() {
            Form1.playlists.Clear();

            List<Playlist> playlists = new();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM playlist";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {
                Playlist playlist = new(data.GetInt32("id"));

                List<Int32> owners = JsonConvert.DeserializeObject<List<Int32>>(data.GetString("owner_ids"));

                if (owners.Contains(account.id)) {
                    playlist.owners.Add(account);
                    playlist.Name = data.GetString("name");

                    try {
                        playlist.rawJson = data.GetString("opnamen_ids");
                    } catch (SqlNullValueException) { }

                    playlists.Add(playlist);
                }
            }

            return playlists;
        }

        private void addSongs() {
            playlists.ForEach(playlist => {
                if (playlist.rawJson != null) 
                    getAllSongs(playlist, playlist.rawJson);
            });
        }

        private void getAllSongs(Playlist playlist, string jsonString) {
            
            List<Int32> songIds = JsonConvert.DeserializeObject<List<Int32>>(jsonString);

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM opnames";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {

                if (songIds.Contains(data.GetInt32("id"))) {
                    playlist.items.Add(new Opnamen() {
                        id = data.GetInt32("id"),
                        creator = JsonConvert.DeserializeObject<List<string>>(data.GetString("creator")),
                        url = data.GetString("url"),
                        name = data.GetString("name"),
                    });
                }
            }
        }

        private void updatePlaylist() {
            FlpPlaylist.Controls.Clear();
            playlists.ForEach(playlist => {
                FlpPlaylist.Controls.Add(new PlaylistLabel(playlist, GbMainSection, FlpPlaylist));
            });
        }

    }
}