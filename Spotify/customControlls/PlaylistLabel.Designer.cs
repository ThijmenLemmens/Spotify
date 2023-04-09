namespace Spotify.customControlls {
    partial class PlaylistLabel {
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
            this.LbPlaylistName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbPlaylistName
            // 
            this.LbPlaylistName.AutoSize = true;
            this.LbPlaylistName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPlaylistName.Location = new System.Drawing.Point(0, 0);
            this.LbPlaylistName.Name = "LbPlaylistName";
            this.LbPlaylistName.Size = new System.Drawing.Size(99, 21);
            this.LbPlaylistName.TabIndex = 0;
            this.LbPlaylistName.Text = "Summer hits";
            this.LbPlaylistName.Click += new System.EventHandler(this.LbPlaylistName_Click);
            this.LbPlaylistName.MouseEnter += new System.EventHandler(this.LbPlaylistName_MouseEnter);
            this.LbPlaylistName.MouseLeave += new System.EventHandler(this.LbPlaylistName_MouseLeave);
            // 
            // PlaylistLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbPlaylistName);
            this.Name = "PlaylistLabel";
            this.Size = new System.Drawing.Size(150, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbPlaylistName;
    }
}
