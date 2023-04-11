using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.sql {
    internal class SqlSong {

        private static MySqlConnection con = Database.Instance().Connection;

        public static void getAllSongs(Playlist playlist, string jsonString) {

            List<Int32> songIds = new(); 

            try {
                songIds = JsonConvert.DeserializeObject<List<Int32>>(jsonString);
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
    }
}
