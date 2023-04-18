namespace Spotify.customControlls {
    partial class FriendPlaylistView {
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
            LbPlaylistName = new Label();
            LbOwned = new Label();
            LbOwners = new Label();
            FlpPlaylist = new FlowLayoutPanel();
            BtnCompare = new Button();
            CbShuffle = new CheckBox();
            CbCompare = new ComboBox();
            SuspendLayout();
            // 
            // LbPlaylistName
            // 
            LbPlaylistName.AutoEllipsis = true;
            LbPlaylistName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LbPlaylistName.Location = new Point(14, 10);
            LbPlaylistName.Name = "LbPlaylistName";
            LbPlaylistName.Size = new Size(155, 27);
            LbPlaylistName.TabIndex = 0;
            LbPlaylistName.Text = "Playlist Name";
            // 
            // LbOwned
            // 
            LbOwned.AutoSize = true;
            LbOwned.Location = new Point(201, 18);
            LbOwned.Name = "LbOwned";
            LbOwned.Size = new Size(61, 15);
            LbOwned.TabIndex = 1;
            LbOwned.Text = "Owned by";
            // 
            // LbOwners
            // 
            LbOwners.AutoEllipsis = true;
            LbOwners.Location = new Point(268, 18);
            LbOwners.Name = "LbOwners";
            LbOwners.Size = new Size(133, 15);
            LbOwners.TabIndex = 2;
            LbOwners.Text = "Owners";
            // 
            // FlpPlaylist
            // 
            FlpPlaylist.Location = new Point(14, 100);
            FlpPlaylist.Name = "FlpPlaylist";
            FlpPlaylist.Size = new Size(446, 225);
            FlpPlaylist.TabIndex = 3;
            // 
            // BtnCompare
            // 
            BtnCompare.Location = new Point(83, 71);
            BtnCompare.Name = "BtnCompare";
            BtnCompare.Size = new Size(75, 23);
            BtnCompare.TabIndex = 4;
            BtnCompare.Text = "Compare";
            BtnCompare.UseVisualStyleBackColor = true;
            BtnCompare.Click += BtnCompare_Click;
            // 
            // CbShuffle
            // 
            CbShuffle.AutoSize = true;
            CbShuffle.Location = new Point(14, 74);
            CbShuffle.Name = "CbShuffle";
            CbShuffle.Size = new Size(63, 19);
            CbShuffle.TabIndex = 5;
            CbShuffle.Text = "Shuffle";
            CbShuffle.UseVisualStyleBackColor = true;
            // 
            // CbCompare
            // 
            CbCompare.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCompare.FormattingEnabled = true;
            CbCompare.Location = new Point(173, 72);
            CbCompare.Name = "CbCompare";
            CbCompare.Size = new Size(121, 23);
            CbCompare.TabIndex = 6;
            CbCompare.SelectedIndexChanged += CbCompare_SelectedIndexChanged;
            // 
            // FriendPlaylistView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(CbCompare);
            Controls.Add(CbShuffle);
            Controls.Add(BtnCompare);
            Controls.Add(FlpPlaylist);
            Controls.Add(LbOwners);
            Controls.Add(LbOwned);
            Controls.Add(LbPlaylistName);
            Name = "FriendPlaylistView";
            Size = new Size(471, 340);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbPlaylistName;
        private Label LbOwned;
        private Label LbOwners;
        private FlowLayoutPanel FlpPlaylist;
        private Button BtnCompare;
        private CheckBox CbShuffle;
        private ComboBox CbCompare;
    }
}
