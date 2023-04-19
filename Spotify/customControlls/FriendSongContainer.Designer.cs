namespace Spotify.customControlls {
    partial class FriendSongContainer {
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
            PbPlay = new PictureBox();
            LbSongName = new Label();
            LbAddSongTo = new Label();
            LbArtiestName = new Label();
            CbPlaylist = new ComboBox();
            ((System.ComponentModel.ISupportInitialize) PbPlay).BeginInit();
            SuspendLayout();
            // 
            // PbPlay
            // 
            PbPlay.Image = Properties.Resource.play_buttton;
            PbPlay.InitialImage = null;
            PbPlay.Location = new Point(3, 3);
            PbPlay.Name = "PbPlay";
            PbPlay.Size = new Size(31, 27);
            PbPlay.SizeMode = PictureBoxSizeMode.Zoom;
            PbPlay.TabIndex = 0;
            PbPlay.TabStop = false;
            PbPlay.Click += PbPlay_Click;
            // 
            // LbSongName
            // 
            LbSongName.AutoSize = true;
            LbSongName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSongName.Location = new Point(45, -1);
            LbSongName.Name = "LbSongName";
            LbSongName.Size = new Size(92, 21);
            LbSongName.TabIndex = 1;
            LbSongName.Text = "Song Name";
            // 
            // LbAddSongTo
            // 
            LbAddSongTo.AutoSize = true;
            LbAddSongTo.Location = new Point(237, 9);
            LbAddSongTo.Name = "LbAddSongTo";
            LbAddSongTo.Size = new Size(72, 15);
            LbAddSongTo.TabIndex = 2;
            LbAddSongTo.Text = "Add song to";
            // 
            // LbArtiestName
            // 
            LbArtiestName.AutoSize = true;
            LbArtiestName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbArtiestName.Location = new Point(45, 20);
            LbArtiestName.Name = "LbArtiestName";
            LbArtiestName.Size = new Size(69, 13);
            LbArtiestName.TabIndex = 3;
            LbArtiestName.Text = "ArtiestName";
            // 
            // CbPlaylist
            // 
            CbPlaylist.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPlaylist.FormattingEnabled = true;
            CbPlaylist.Location = new Point(312, 5);
            CbPlaylist.Name = "CbPlaylist";
            CbPlaylist.Size = new Size(121, 23);
            CbPlaylist.TabIndex = 4;
            CbPlaylist.SelectedIndexChanged += CbPlaylist_SelectedIndexChanged;
            // 
            // FriendSongContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CbPlaylist);
            Controls.Add(LbArtiestName);
            Controls.Add(LbAddSongTo);
            Controls.Add(LbSongName);
            Controls.Add(PbPlay);
            Name = "FriendSongContainer";
            Size = new Size(473, 33);
            ((System.ComponentModel.ISupportInitialize) PbPlay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbPlay;
        private Label LbSongName;
        private Label LbAddSongTo;
        private Label LbArtiestName;
        private ComboBox CbPlaylist;
    }
}
