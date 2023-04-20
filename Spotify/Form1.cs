using MySql.Data.MySqlClient;
using NAudio.Utils;
using NAudio.Wave;
using Newtonsoft.Json;
using Spotify.customControlls;
using Spotify.Properties;
using Spotify.sql;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System.Data.SqlTypes;
using System.IO;
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

            // some magic code for removing scroll bars
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

        /// <summary>
        /// creates a playlist and makes a record for it in the Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// add songs to the playlists 
        /// </summary>
        private void addSongs() {
            playlists.ForEach(playlist => {
                if (playlist.rawJson != null)
                    SqlQuery.getAllSongs(playlist);
            });
        }

        /// <summary>
        /// adds the playlist labels to the flowlayloutpanel voor de playlist viewer
        /// </summary>
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

        private void TbVolumeSlider_Scroll(Object sender, EventArgs e) {
            LbVolume.Text = TbVolumeSlider.Value.ToString();
            if (MediaPlayer.waveOut != null)
                MediaPlayer.waveOut.Volume = (float) TbVolumeSlider.Value / 100;
        }

        private void TbTimeline_Scroll(Object sender, EventArgs e) {
            using Mp3FileReader mp3Reader = new Mp3FileReader(MediaPlayer.memoryStream);

            int time = (Int32) mp3Reader.TotalTime.TotalSeconds;

            //long time = (MediaPlayer.memoryStream.Length * 8) / (MediaPlayer.waveOut.OutputWaveFormat.SampleRate * MediaPlayer.waveOut.OutputWaveFormat.Channels);
            TbTimeline.Maximum = (int) time;
            Console.WriteLine(time);
            if (MediaPlayer.memoryStream != null) {
                var lengthInBytes = MediaPlayer.memoryStream.Length;
                var pos = (lengthInBytes / TbTimeline.Maximum) * TbTimeline.Value;   
                MediaPlayer.memoryStream.Seek(pos, SeekOrigin.Begin);
            }
        }
    }
}