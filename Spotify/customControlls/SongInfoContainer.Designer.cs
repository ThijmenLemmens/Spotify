﻿namespace Spotify.customControlls {
    partial class SongInfoContainer {
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
            LbSongName = new Label();
            PbPlay = new PictureBox();
            CbPlaylist = new ComboBox();
            LbArtiestName = new Label();
            LbAddSongTo = new Label();
            ((System.ComponentModel.ISupportInitialize) PbPlay).BeginInit();
            SuspendLayout();
            // 
            // LbSongName
            // 
            LbSongName.AutoEllipsis = true;
            LbSongName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSongName.Location = new Point(51, -1);
            LbSongName.Name = "LbSongName";
            LbSongName.Size = new Size(217, 30);
            LbSongName.TabIndex = 0;
            LbSongName.Text = "Song Name";
            // 
            // PbPlay
            // 
            PbPlay.Image = Properties.Resource.play_buttton;
            PbPlay.Location = new Point(3, 2);
            PbPlay.Name = "PbPlay";
            PbPlay.Size = new Size(34, 29);
            PbPlay.SizeMode = PictureBoxSizeMode.Zoom;
            PbPlay.TabIndex = 1;
            PbPlay.TabStop = false;
            PbPlay.Click += PbPlay_Click;
            // 
            // CbPlaylist
            // 
            CbPlaylist.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPlaylist.FormattingEnabled = true;
            CbPlaylist.Location = new Point(469, 6);
            CbPlaylist.Name = "CbPlaylist";
            CbPlaylist.Size = new Size(121, 23);
            CbPlaylist.TabIndex = 2;
            CbPlaylist.SelectedIndexChanged += CbPlaylist_SelectedIndexChanged;
            // 
            // LbArtiestName
            // 
            LbArtiestName.AutoEllipsis = true;
            LbArtiestName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbArtiestName.Location = new Point(53, 20);
            LbArtiestName.Name = "LbArtiestName";
            LbArtiestName.Size = new Size(214, 13);
            LbArtiestName.TabIndex = 3;
            LbArtiestName.Text = "ArtiestName";
            // 
            // LbAddSongTo
            // 
            LbAddSongTo.AutoSize = true;
            LbAddSongTo.Location = new Point(395, 10);
            LbAddSongTo.Name = "LbAddSongTo";
            LbAddSongTo.Size = new Size(72, 15);
            LbAddSongTo.TabIndex = 4;
            LbAddSongTo.Text = "Add song to";
            // 
            // SongInfoContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbAddSongTo);
            Controls.Add(LbArtiestName);
            Controls.Add(CbPlaylist);
            Controls.Add(PbPlay);
            Controls.Add(LbSongName);
            Name = "SongInfoContainer";
            Size = new Size(640, 34);
            ((System.ComponentModel.ISupportInitialize) PbPlay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbSongName;
        private PictureBox PbPlay;
        private ComboBox CbPlaylist;
        private Label LbArtiestName;
        private Label LbAddSongTo;
    }
}
