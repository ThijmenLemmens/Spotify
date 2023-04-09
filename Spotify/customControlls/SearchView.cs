using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.util.opnamens;

namespace Spotify.customControlls {

    public partial class SearchView : UserControl {

        private MySqlConnection con = Database.Instance().Connection;

        private List<Opnamen> opnamens;

        public SearchView() {
            InitializeComponent();
            opnamens = GetOpnamens();
        }

        private void SearchView_Load(Object sender, EventArgs e) {
            fillLayout();
        }

        private void fillLayout() {
            opnamens.ForEach(opnamen => {
                FlpSearch.Controls.Add(new SongInfoContainer(opnamen));
            });
        }

        private List<Opnamen> GetOpnamens() {
            List<Opnamen> opnamens = new();

            MySqlCommand cmd = con.CreateCommand();

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
    }
}
