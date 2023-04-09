namespace Spotify.customControlls {
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
            this.LbSongName = new System.Windows.Forms.Label();
            this.PbPlay = new System.Windows.Forms.PictureBox();
            this.CbPlaylist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // LbSongName
            // 
            this.LbSongName.AutoSize = true;
            this.LbSongName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSongName.Location = new System.Drawing.Point(51, 7);
            this.LbSongName.Name = "LbSongName";
            this.LbSongName.Size = new System.Drawing.Size(80, 19);
            this.LbSongName.TabIndex = 0;
            this.LbSongName.Text = "Song Name";
            // 
            // PbPlay
            // 
            this.PbPlay.Image = global::Spotify.Properties.Resource.play_buttton;
            this.PbPlay.Location = new System.Drawing.Point(3, 2);
            this.PbPlay.Name = "PbPlay";
            this.PbPlay.Size = new System.Drawing.Size(31, 29);
            this.PbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPlay.TabIndex = 1;
            this.PbPlay.TabStop = false;
            this.PbPlay.Click += new System.EventHandler(this.PbPlay_Click);
            // 
            // CbPlaylist
            // 
            this.CbPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlaylist.FormattingEnabled = true;
            this.CbPlaylist.Location = new System.Drawing.Point(469, 6);
            this.CbPlaylist.Name = "CbPlaylist";
            this.CbPlaylist.Size = new System.Drawing.Size(121, 23);
            this.CbPlaylist.TabIndex = 2;
            this.CbPlaylist.SelectedIndexChanged += new System.EventHandler(this.CbPlaylist_SelectedIndexChanged);
            // 
            // SongInfoContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbPlaylist);
            this.Controls.Add(this.PbPlay);
            this.Controls.Add(this.LbSongName);
            this.Name = "SongInfoContainer";
            this.Size = new System.Drawing.Size(640, 34);
            ((System.ComponentModel.ISupportInitialize)(this.PbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbSongName;
        private PictureBox PbPlay;
        private ComboBox CbPlaylist;
    }
}
