namespace Spotify.customControlls {
    partial class PlaylistSongInfo {
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
            LbOpnamenName = new Label();
            BtnRemove = new Button();
            CbAddToPlaylist = new ComboBox();
            LbArtiestName = new Label();
            LbAddSongTo = new Label();
            ((System.ComponentModel.ISupportInitialize) PbPlay).BeginInit();
            SuspendLayout();
            // 
            // PbPlay
            // 
            PbPlay.Image = Properties.Resource.play_buttton;
            PbPlay.Location = new Point(2, 2);
            PbPlay.Name = "PbPlay";
            PbPlay.Size = new Size(40, 31);
            PbPlay.SizeMode = PictureBoxSizeMode.Zoom;
            PbPlay.TabIndex = 0;
            PbPlay.TabStop = false;
            PbPlay.Click += PbPlay_Click;
            // 
            // LbOpnamenName
            // 
            LbOpnamenName.AutoEllipsis = true;
            LbOpnamenName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOpnamenName.Location = new Point(44, 0);
            LbOpnamenName.Name = "LbOpnamenName";
            LbOpnamenName.Size = new Size(209, 23);
            LbOpnamenName.TabIndex = 1;
            LbOpnamenName.Text = "Opnamen Name";
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(575, 6);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(60, 23);
            BtnRemove.TabIndex = 2;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // CbAddToPlaylist
            // 
            CbAddToPlaylist.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAddToPlaylist.FormattingEnabled = true;
            CbAddToPlaylist.Location = new Point(448, 6);
            CbAddToPlaylist.Name = "CbAddToPlaylist";
            CbAddToPlaylist.Size = new Size(121, 23);
            CbAddToPlaylist.TabIndex = 3;
            CbAddToPlaylist.SelectedIndexChanged += CbAddToPlaylist_SelectedIndexChanged;
            // 
            // LbArtiestName
            // 
            LbArtiestName.AutoEllipsis = true;
            LbArtiestName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbArtiestName.Location = new Point(49, 21);
            LbArtiestName.Name = "LbArtiestName";
            LbArtiestName.Size = new Size(210, 23);
            LbArtiestName.TabIndex = 4;
            LbArtiestName.Text = "ArtiesName";
            // 
            // LbAddSongTo
            // 
            LbAddSongTo.AutoSize = true;
            LbAddSongTo.Location = new Point(373, 10);
            LbAddSongTo.Name = "LbAddSongTo";
            LbAddSongTo.Size = new Size(72, 15);
            LbAddSongTo.TabIndex = 5;
            LbAddSongTo.Text = "Add song to";
            // 
            // PlaylistSongInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbAddSongTo);
            Controls.Add(LbArtiestName);
            Controls.Add(CbAddToPlaylist);
            Controls.Add(BtnRemove);
            Controls.Add(LbOpnamenName);
            Controls.Add(PbPlay);
            Name = "PlaylistSongInfo";
            Size = new Size(640, 34);
            ((System.ComponentModel.ISupportInitialize) PbPlay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbPlay;
        private Label LbOpnamenName;
        private Button BtnRemove;
        private ComboBox CbAddToPlaylist;
        private Label LbArtiestName;
        private Label LbAddSongTo;
    }
}
