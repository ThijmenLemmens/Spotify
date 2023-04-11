using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System.Data.SqlTypes;

namespace Spotify.customControlls {

    public partial class SearchView : UserControl {

        private MySqlConnection con = Database.Instance().Connection;

        private List<Opnamen> opnamens;

        private List<Album> albums;

        private MySqlCommand cmd;

        private GroupBox GbMain;

        public SearchView(GroupBox GbMain) {
            InitializeComponent();
            opnamens = GetOpnamens();
            albums = getAlbums();

            this.GbMain = GbMain;
        }

        private void SearchView_Load(Object sender, EventArgs e) {
            fillLayoutOpnamen();
        }

        private void fillLayoutOpnamen() {
            opnamens.ForEach(opnamen => {
                FlpSearch.Controls.Add(new SongInfoContainer(opnamen));
            });
        }

        private void fillLayoutAlbum() {
            albums.ForEach(album => {
                FlpSearch.Controls.Add(new AlbumInfo(album, GbMain));
            });
        }

        private List<Opnamen> GetOpnamens() {
            List<Opnamen> opnamens = new();

            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM opnames";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {
                opnamens.Add(new Opnamen() {
                    id = data.GetInt32("id"), 
                    name = data.GetString("name"),
                    creator = JsonConvert.DeserializeObject<List<string>>(data.GetString("creator")),
                    url = data.GetString("url")
                });
            }

            return opnamens;
        }

        private List<Album> getAlbums() {
            List<Album> albums = new();

            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM album";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {
                Album album = new() {
                    id = data.GetInt32("id"),
                    Name = data.GetString("name"),
                    artiestNames = JsonConvert.DeserializeObject<List<string>>(data.GetString("artiest_names"))
                };

                try {
                    album.rawJson = data.GetString("song_ids");

                    List<Int32> songIds = JsonConvert.DeserializeObject<List<Int32>>(album.rawJson);

                    opnamens.ForEach(opnamen => {
                        if (songIds.Contains(opnamen.id))
                            album.items.Add(opnamen);   
                    });

                } catch (SqlNullValueException) { }

                albums.Add(album);
            }

            return albums;
        }

        private void CbCats_SelectedIndexChanged(Object sender, EventArgs e) {
            FlpSearch.Controls.Clear();

            switch (CbCats.Text) {
                case "Songs":
                    fillLayoutOpnamen();
                    break;
                case "Album":
                    fillLayoutAlbum();
                    break;
            }
        }
    }
}
