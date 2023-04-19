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
            this.PbPlay = new System.Windows.Forms.PictureBox();
            this.LbSongName = new System.Windows.Forms.Label();
            this.LbAddSongTo = new System.Windows.Forms.Label();
            this.LbArtiestName = new System.Windows.Forms.Label();
            this.CbPlaylist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // PbPlay
            // 
            this.PbPlay.Image = global::Spotify.Properties.Resource.play_buttton;
            this.PbPlay.InitialImage = null;
            this.PbPlay.Location = new System.Drawing.Point(3, 3);
            this.PbPlay.Name = "PbPlay";
            this.PbPlay.Size = new System.Drawing.Size(31, 27);
            this.PbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPlay.TabIndex = 0;
            this.PbPlay.TabStop = false;
            this.PbPlay.Click += new System.EventHandler(this.PbPlay_Click);
            // 
            // LbSongName
            // 
            this.LbSongName.AutoSize = true;
            this.LbSongName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSongName.Location = new System.Drawing.Point(45, -1);
            this.LbSongName.Name = "LbSongName";
            this.LbSongName.Size = new System.Drawing.Size(92, 21);
            this.LbSongName.TabIndex = 1;
            this.LbSongName.Text = "Song Name";
            // 
            // LbAddSongTo
            // 
            this.LbAddSongTo.AutoSize = true;
            this.LbAddSongTo.Location = new System.Drawing.Point(237, 9);
            this.LbAddSongTo.Name = "LbAddSongTo";
            this.LbAddSongTo.Size = new System.Drawing.Size(72, 15);
            this.LbAddSongTo.TabIndex = 2;
            this.LbAddSongTo.Text = "Add song to";
            // 
            // LbArtiestName
            // 
            this.LbArtiestName.AutoSize = true;
            this.LbArtiestName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbArtiestName.Location = new System.Drawing.Point(45, 20);
            this.LbArtiestName.Name = "LbArtiestName";
            this.LbArtiestName.Size = new System.Drawing.Size(69, 13);
            this.LbArtiestName.TabIndex = 3;
            this.LbArtiestName.Text = "ArtiestName";
            // 
            // CbPlaylist
            // 
            this.CbPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlaylist.FormattingEnabled = true;
            this.CbPlaylist.Location = new System.Drawing.Point(312, 5);
            this.CbPlaylist.Name = "CbPlaylist";
            this.CbPlaylist.Size = new System.Drawing.Size(121, 23);
            this.CbPlaylist.TabIndex = 4;
            // 
            // FriendSongContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbPlaylist);
            this.Controls.Add(this.LbArtiestName);
            this.Controls.Add(this.LbAddSongTo);
            this.Controls.Add(this.LbSongName);
            this.Controls.Add(this.PbPlay);
            this.Name = "FriendSongContainer";
            this.Size = new System.Drawing.Size(473, 33);
            ((System.ComponentModel.ISupportInitialize)(this.PbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PbPlay;
        private Label LbSongName;
        private Label LbAddSongTo;
        private Label LbArtiestName;
        private ComboBox CbPlaylist;
    }
}
