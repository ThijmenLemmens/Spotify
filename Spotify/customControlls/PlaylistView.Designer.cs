namespace Spotify.customControlls {
    partial class PlaylistView {
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
            this.FlpOpnamens = new System.Windows.Forms.FlowLayoutPanel();
            this.CbShuffle = new System.Windows.Forms.CheckBox();
            this.LbCreator = new System.Windows.Forms.Label();
            this.LbOwnedBy = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbPlaylistName
            // 
            this.LbPlaylistName.AutoSize = true;
            this.LbPlaylistName.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPlaylistName.Location = new System.Drawing.Point(12, 14);
            this.LbPlaylistName.Name = "LbPlaylistName";
            this.LbPlaylistName.Size = new System.Drawing.Size(351, 62);
            this.LbPlaylistName.TabIndex = 0;
            this.LbPlaylistName.Text = "PlayList Name";
            // 
            // FlpOpnamens
            // 
            this.FlpOpnamens.AutoScroll = true;
            this.FlpOpnamens.Location = new System.Drawing.Point(73, 135);
            this.FlpOpnamens.Name = "FlpOpnamens";
            this.FlpOpnamens.Size = new System.Drawing.Size(655, 311);
            this.FlpOpnamens.TabIndex = 1;
            // 
            // CbShuffle
            // 
            this.CbShuffle.AutoSize = true;
            this.CbShuffle.Location = new System.Drawing.Point(73, 110);
            this.CbShuffle.Name = "CbShuffle";
            this.CbShuffle.Size = new System.Drawing.Size(63, 19);
            this.CbShuffle.TabIndex = 2;
            this.CbShuffle.Text = "Shuffle";
            this.CbShuffle.UseVisualStyleBackColor = true;
            // 
            // LbCreator
            // 
            this.LbCreator.AutoEllipsis = true;
            this.LbCreator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCreator.Location = new System.Drawing.Point(441, 48);
            this.LbCreator.Name = "LbCreator";
            this.LbCreator.Size = new System.Drawing.Size(287, 24);
            this.LbCreator.TabIndex = 3;
            this.LbCreator.Text = "Owners";
            // 
            // LbOwnedBy
            // 
            this.LbOwnedBy.AutoSize = true;
            this.LbOwnedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbOwnedBy.Location = new System.Drawing.Point(360, 47);
            this.LbOwnedBy.Name = "LbOwnedBy";
            this.LbOwnedBy.Size = new System.Drawing.Size(84, 21);
            this.LbOwnedBy.TabIndex = 7;
            this.LbOwnedBy.Text = "Owned by:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(142, 107);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // PlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LbOwnedBy);
            this.Controls.Add(this.LbCreator);
            this.Controls.Add(this.CbShuffle);
            this.Controls.Add(this.FlpOpnamens);
            this.Controls.Add(this.LbPlaylistName);
            this.Name = "PlaylistView";
            this.Size = new System.Drawing.Size(797, 466);
            this.Load += new System.EventHandler(this.PlaylistView_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbPlaylistName;
        private FlowLayoutPanel FlpOpnamens;
        private CheckBox CbShuffle;
        private Label LbCreator;
        private Label LbOwnedBy;
        private Button BtnDelete;
    }
}
