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
            LbPlaylistName = new Label();
            SuspendLayout();
            // 
            // LbPlaylistName
            // 
            LbPlaylistName.AutoSize = true;
            LbPlaylistName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbPlaylistName.Location = new Point(3, 7);
            LbPlaylistName.Name = "LbPlaylistName";
            LbPlaylistName.Size = new Size(99, 21);
            LbPlaylistName.TabIndex = 0;
            LbPlaylistName.Text = "Summer hits";
            LbPlaylistName.Click += LbPlaylistName_Click;
            LbPlaylistName.MouseEnter += LbPlaylistName_MouseEnter;
            LbPlaylistName.MouseLeave += LbPlaylistName_MouseLeave;
            // 
            // PlaylistLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbPlaylistName);
            Name = "PlaylistLabel";
            Size = new Size(150, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbPlaylistName;
    }
}
