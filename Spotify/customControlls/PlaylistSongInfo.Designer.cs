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
            this.PbPlay = new System.Windows.Forms.PictureBox();
            this.LbOpnamenName = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.CbAddToPlaylist = new System.Windows.Forms.ComboBox();
            this.LbArtiestName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // PbPlay
            // 
            this.PbPlay.Image = global::Spotify.Properties.Resource.play_buttton;
            this.PbPlay.Location = new System.Drawing.Point(2, 2);
            this.PbPlay.Name = "PbPlay";
            this.PbPlay.Size = new System.Drawing.Size(40, 31);
            this.PbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPlay.TabIndex = 0;
            this.PbPlay.TabStop = false;
            this.PbPlay.Click += new System.EventHandler(this.PbPlay_Click);
            // 
            // LbOpnamenName
            // 
            this.LbOpnamenName.AutoEllipsis = true;
            this.LbOpnamenName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbOpnamenName.Location = new System.Drawing.Point(44, 0);
            this.LbOpnamenName.Name = "LbOpnamenName";
            this.LbOpnamenName.Size = new System.Drawing.Size(209, 23);
            this.LbOpnamenName.TabIndex = 1;
            this.LbOpnamenName.Text = "Opnamen Name";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(575, 6);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(60, 23);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // CbAddToPlaylist
            // 
            this.CbAddToPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAddToPlaylist.FormattingEnabled = true;
            this.CbAddToPlaylist.Location = new System.Drawing.Point(448, 6);
            this.CbAddToPlaylist.Name = "CbAddToPlaylist";
            this.CbAddToPlaylist.Size = new System.Drawing.Size(121, 23);
            this.CbAddToPlaylist.TabIndex = 3;
            this.CbAddToPlaylist.SelectedIndexChanged += new System.EventHandler(this.CbAddToPlaylist_SelectedIndexChanged);
            // 
            // LbArtiestName
            // 
            this.LbArtiestName.AutoEllipsis = true;
            this.LbArtiestName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbArtiestName.Location = new System.Drawing.Point(49, 21);
            this.LbArtiestName.Name = "LbArtiestName";
            this.LbArtiestName.Size = new System.Drawing.Size(210, 23);
            this.LbArtiestName.TabIndex = 4;
            this.LbArtiestName.Text = "ArtiesName";
            // 
            // PlaylistSongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbArtiestName);
            this.Controls.Add(this.CbAddToPlaylist);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.LbOpnamenName);
            this.Controls.Add(this.PbPlay);
            this.Name = "PlaylistSongInfo";
            this.Size = new System.Drawing.Size(640, 34);
            ((System.ComponentModel.ISupportInitialize)(this.PbPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PbPlay;
        private Label LbOpnamenName;
        private Button BtnRemove;
        private ComboBox CbAddToPlaylist;
        private Label LbArtiestName;
    }
}
