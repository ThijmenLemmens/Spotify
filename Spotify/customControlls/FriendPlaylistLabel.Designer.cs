namespace Spotify.customControlls {
    partial class FriendPlaylistLabel {
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
            LbFriendPlaylist = new Label();
            SuspendLayout();
            // 
            // LbFriendPlaylist
            // 
            LbFriendPlaylist.AutoEllipsis = true;
            LbFriendPlaylist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbFriendPlaylist.Location = new Point(0, 0);
            LbFriendPlaylist.Name = "LbFriendPlaylist";
            LbFriendPlaylist.Size = new Size(124, 24);
            LbFriendPlaylist.TabIndex = 0;
            LbFriendPlaylist.Text = "PlaylistName";
            LbFriendPlaylist.Click += LbFriendPlaylist_Click;
            LbFriendPlaylist.MouseEnter += LbFriendPlaylist_MouseEnter;
            LbFriendPlaylist.MouseLeave += LbFriendPlaylist_MouseLeave;
            // 
            // FriendPlaylistLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbFriendPlaylist);
            Name = "FriendPlaylistLabel";
            Size = new Size(124, 24);
            ResumeLayout(false);
        }

        #endregion

        private Label LbFriendPlaylist;
    }
}
