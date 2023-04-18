using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Spotify.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify.customControlls {

    public partial class FriendsView : UserControl {

        private MySqlConnection con = Database.Instance().Connection;

        private Account account = Form1.account;

        public FriendsView() {
            InitializeComponent();
            loadFriends();
        }

        private void FriendsView_Load(Object sender, EventArgs e) {

        }

        private void BtnAddFriend_Click(Object sender, EventArgs e) {

            Account? friend = SqlQuery.selectAccount(TbFriendName.Text);

            if (account == null) {
                MessageBox.Show($"{TbFriendName.Text} Account not found!");
                return;
            }

            if (account.friendIds.Contains(friend.id)) {
                MessageBox.Show($"{TbFriendName.Text} is already a friend!");
                return;
            }

            account.friendIds.Add(friend.id);

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE accounts SET friends = ?friends WHERE id = ?id";

            cmd.Parameters.AddWithValue("?friends", JsonConvert.SerializeObject(account.friendIds));
            cmd.Parameters.AddWithValue("id", account.id);

            cmd.ExecuteNonQuery();

            SqlQuery.getAllFriends(account);

            loadFriends();
        }

        private void loadFriends() {
            for (int i = 0; i < account.friends.Count; i++)
                FlpFriends.Controls.Add(new FriendLabel(account.friends[i], GbFriendMainSection));
        }
    }
}
