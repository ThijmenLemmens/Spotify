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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbOpnamenName = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.CbAddToPlaylist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spotify.Properties.Resource.play_buttton;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LbOpnamenName
            // 
            this.LbOpnamenName.AutoEllipsis = true;
            this.LbOpnamenName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbOpnamenName.Location = new System.Drawing.Point(44, 6);
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
            // PlaylistSongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbAddToPlaylist);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.LbOpnamenName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlaylistSongInfo";
            this.Size = new System.Drawing.Size(640, 34);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label LbOpnamenName;
        private Button BtnRemove;
        private ComboBox CbAddToPlaylist;
    }
}
