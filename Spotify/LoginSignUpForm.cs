using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Data.SqlTypes;

namespace Spotify {
    public partial class LoginSignUpForm : Form {

        private MySqlConnection con = Database.Instance().Connection;

        public LoginSignUpForm() {
            InitializeComponent();
            BtnLoginSignUp.Click += login;
            TbPassword.PasswordChar = '\u25CF';
        }

        private void RbLogin_CheckedChanged(Object sender, EventArgs e) {
            if (RbLogin.Checked) {
                BtnLoginSignUp.Text = "Login";
                BtnLoginSignUp.Click += login;
                BtnLoginSignUp.Click -= signUp;
            }

        }

        private void RbSignUp_CheckedChanged(Object sender, EventArgs e) {
            if (RbSignUp.Checked) {
                BtnLoginSignUp.Text = "SignUp";
                BtnLoginSignUp.Click += signUp;
                BtnLoginSignUp.Click -= login;
            }
        }

        private void login(object sender, EventArgs e) {

            Account? account = selectAccount();

            if (account == null) {
                MessageBox.Show("Account does not exists!");
                reset();
                return;
            }

            if (account.password != TbPassword.Text) {
                MessageBox.Show("Wrong Password!");
                reset();
                return;
            }

            Form1 form = new(account);

            Thread myThread = new((ThreadStart) delegate {
                Application.Run(form);
            });

            myThread.Start();

            this.Dispose();
        }

        private void signUp(object sender, EventArgs e) {

            if (selectAccount() != null) {
                MessageBox.Show("Account already exists!");
                return;
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO accounts (user_name, password) VALUES (?user_name, ?password)";

            cmd.Parameters.AddWithValue("?user_name", TbAccountName.Text);
            cmd.Parameters.AddWithValue("?password", TbPassword.Text);

            cmd.ExecuteNonQuery();

            reset();
        }

        private Account? selectAccount() {
            Account? account = null;

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM accounts WHERE user_name = ?user_name";

            cmd.Parameters.AddWithValue("?user_name", TbAccountName.Text);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read()) {
                account = new();
                account.id = data.GetInt32(0);
                account.name = data.GetString(1);
                account.password = data.GetString(2);

                try {
                    account.friendIds = JsonConvert.DeserializeObject<List<Int32>>(data.GetString(3));
                } catch (SqlNullValueException) {
                    account.friendIds = null;
                }
            }

            return account;
        }

        private void reset() {
            RbLogin.Checked = true;
            TbAccountName.Text = "";
            TbPassword.Text = "";
        }
    }
}
