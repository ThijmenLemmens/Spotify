using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.sql {

    public class SqlQuery {

        /// <summary>
        /// gets the connection to the Database
        /// </summary>
        private static MySqlConnection con = Database.Instance().Connection;

        /// <summary>
        /// gets record account from the Database where user_name = a given name
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public static Account? selectAccount(string accountName) {
            Account? account = null;

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM accounts WHERE user_name = ?user_name";

            cmd.Parameters.AddWithValue("?user_name", accountName);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {
                account = new();
                account.id = data.GetInt32(0);
                account.name = data.GetString(1);
                account.password = data.GetString(2);

                try {
                    account.friendIds = JsonConvert.DeserializeObject<List<Int32>>(data.GetString(3));
                } catch (SqlNullValueException) { }
            }

            return account;
        }

        /// <summary>
        /// returns a list for friends (accounts) from the currently logged in account 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static List<Account> getFriends(Account account) {

            List<Account> accounts = new();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM accounts";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {

                int id = data.GetInt32("id");

                if (account.friendIds.Contains(id) && account.id != id) {
                    Console.WriteLine(account.friendIds.Contains(data.GetInt32("id")));
                    Account friend = new() {
                        id = data.GetInt32("id"),
                        name = data.GetString("user_name"),
                    };

                    try {
                        account.friendIds = JsonConvert.DeserializeObject<List<Int32>>(data.GetString("friends"));
                    } catch (SqlNullValueException) { }


                    accounts.Add(friend);
                }
            }

            return accounts;
        }

        /// <summary>
        /// returns a list of playlits from the currently logged in account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static List<Playlist> getPlayList(Account account) {
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

        /// <summary>
        /// fills the playlists with the correct songs
        /// </summary>
        /// <param name="playlist"></param>
        public static void getAllSongs(Playlist playlist) {

            List<Int32> songIds = new();

            try {
                songIds = JsonConvert.DeserializeObject<List<Int32>>(playlist.rawJson);
            } catch (ArgumentNullException) { }

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

        /// <summary>
        /// fills the friend accounts with songs and playlists
        /// </summary>
        /// <param name="account"></param>
        public static void getAllFriends(Account account) {
            List<Account> accounts = getFriends(account);

            accounts.ForEach(account => {
                account.playlists = getPlayList(account);
            });

            accounts.ForEach(account => {
                account.playlists.ForEach(playlist => {
                    if (playlist.rawJson != null)
                        getAllSongs(playlist);
                });
            });

            account.friends = accounts;
        }

        /// <summary>
        /// adds the song to a playlist and updates the record
        /// </summary>
        /// <param name="playlists"></param>
        /// <param name="index"></param>
        /// <param name="opnamen"></param>
        public static void addSongToPlaylist(List<Playlist> playlists, int index, Opnamen opnamen) {
            playlists[index].items.Add(opnamen);

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE playlist SET opnamen_ids = ?opnamen_ids WHERE id = ?id";

            List<Int32> ids = new();

            playlists[index].items.ForEach(opnamen => {
                ids.Add(opnamen.id);
            });

            cmd.Parameters.AddWithValue("?opnamen_ids", JsonConvert.SerializeObject(ids));
            cmd.Parameters.AddWithValue("?id", playlists[index].id);

            cmd.ExecuteNonQuery();
        }
    }
}
