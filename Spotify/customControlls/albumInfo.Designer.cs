namespace Spotify.customControlls {
    partial class AlbumInfo {
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
            this.LbAlbumName = new System.Windows.Forms.Label();
            this.LbArtiestName = new System.Windows.Forms.Label();
            this.BtnOpenAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbAlbumName
            // 
            this.LbAlbumName.AutoEllipsis = true;
            this.LbAlbumName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAlbumName.Location = new System.Drawing.Point(70, 0);
            this.LbAlbumName.Name = "LbAlbumName";
            this.LbAlbumName.Size = new System.Drawing.Size(217, 30);
            this.LbAlbumName.TabIndex = 1;
            this.LbAlbumName.Text = "Album Name";
            // 
            // LbArtiestName
            // 
            this.LbArtiestName.AutoEllipsis = true;
            this.LbArtiestName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbArtiestName.Location = new System.Drawing.Point(70, 21);
            this.LbArtiestName.Name = "LbArtiestName";
            this.LbArtiestName.Size = new System.Drawing.Size(214, 13);
            this.LbArtiestName.TabIndex = 4;
            this.LbArtiestName.Text = "ArtiestName";
            // 
            // BtnOpenAlbum
            // 
            this.BtnOpenAlbum.Location = new System.Drawing.Point(3, 3);
            this.BtnOpenAlbum.Name = "BtnOpenAlbum";
            this.BtnOpenAlbum.Size = new System.Drawing.Size(61, 28);
            this.BtnOpenAlbum.TabIndex = 5;
            this.BtnOpenAlbum.Text = "Open";
            this.BtnOpenAlbum.UseVisualStyleBackColor = true;
            this.BtnOpenAlbum.Click += new System.EventHandler(this.BtnOpenAlbum_Click);
            // 
            // albumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnOpenAlbum);
            this.Controls.Add(this.LbArtiestName);
            this.Controls.Add(this.LbAlbumName);
            this.Name = "albumInfo";
            this.Size = new System.Drawing.Size(640, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LbAlbumName;
        private Label LbArtiestName;
        private Button BtnOpenAlbum;
    }
}
