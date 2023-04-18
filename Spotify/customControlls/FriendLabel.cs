using Spotify.util.afspeellijsten;
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
    public partial class FriendLabel : UserControl {

        private Account account;

        private GroupBox gbFriendMainSection;

        public FriendLabel(Account account, GroupBox gbFriendMainSection) {
            InitializeComponent();

            this.account = account;
            this.gbFriendMainSection = gbFriendMainSection;
            LbFriendName.ForeColor = Color.DarkGray;

            LbFriendName.Text = account.name;
        }

        private void LbFriendName_Click(Object sender, EventArgs e) {
            gbFriendMainSection.Controls.Clear();
            gbFriendMainSection.Controls.Add(new FriendInfo(account));
        }

        private void LbFriendName_MouseEnter(Object sender, EventArgs e) {
            LbFriendName.ForeColor = Color.Black;
        }

        private void LbFriendName_MouseLeave(Object sender, EventArgs e) {
            LbFriendName.ForeColor = Color.DarkGray;
        }

    }
}
