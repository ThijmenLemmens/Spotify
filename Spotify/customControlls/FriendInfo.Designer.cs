namespace Spotify.customControlls {
    partial class FriendInfo {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            GbPlaylist = new GroupBox();
            FlpFriendPlaylist = new FlowLayoutPanel();
            GbSongs = new GroupBox();
            GbPlaylist.SuspendLayout();
            SuspendLayout();
            // 
            // GbPlaylist
            // 
            GbPlaylist.Controls.Add(FlpFriendPlaylist);
            GbPlaylist.Location = new Point(4, 0);
            GbPlaylist.Name = "GbPlaylist";
            GbPlaylist.Size = new Size(127, 345);
            GbPlaylist.TabIndex = 0;
            GbPlaylist.TabStop = false;
            GbPlaylist.Text = "Playlist";
            // 
            // FlpFriendPlaylist
            // 
            FlpFriendPlaylist.Location = new Point(6, 22);
            FlpFriendPlaylist.Name = "FlpFriendPlaylist";
            FlpFriendPlaylist.Size = new Size(115, 314);
            FlpFriendPlaylist.TabIndex = 0;
            // 
            // GbSongs
            // 
            GbSongs.Location = new Point(136, 0);
            GbSongs.Name = "GbSongs";
            GbSongs.Size = new Size(473, 345);
            GbSongs.TabIndex = 1;
            GbSongs.TabStop = false;
            // 
            // FriendInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GbSongs);
            Controls.Add(GbPlaylist);
            Name = "FriendInfo";
            Size = new Size(622, 348);
            Load += FriendInfo_Load;
            GbPlaylist.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbPlaylist;
        private FlowLayoutPanel FlpFriendPlaylist;
        private GroupBox GbSongs;
    }
}
