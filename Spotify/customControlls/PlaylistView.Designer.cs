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
            LbPlaylistName = new Label();
            FlpOpnamens = new FlowLayoutPanel();
            CbShuffle = new CheckBox();
            LbCreator = new Label();
            LbOwnedBy = new Label();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // LbPlaylistName
            // 
            LbPlaylistName.AutoSize = true;
            LbPlaylistName.Font = new Font("Microsoft YaHei", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LbPlaylistName.Location = new Point(12, 14);
            LbPlaylistName.Name = "LbPlaylistName";
            LbPlaylistName.Size = new Size(351, 62);
            LbPlaylistName.TabIndex = 0;
            LbPlaylistName.Text = "PlayList Name";
            LbPlaylistName.Click += LbPlaylistName_Click;
            // 
            // FlpOpnamens
            // 
            FlpOpnamens.AutoScroll = true;
            FlpOpnamens.Location = new Point(73, 135);
            FlpOpnamens.Name = "FlpOpnamens";
            FlpOpnamens.Size = new Size(655, 311);
            FlpOpnamens.TabIndex = 1;
            // 
            // CbShuffle
            // 
            CbShuffle.AutoSize = true;
            CbShuffle.Location = new Point(73, 110);
            CbShuffle.Name = "CbShuffle";
            CbShuffle.Size = new Size(63, 19);
            CbShuffle.TabIndex = 2;
            CbShuffle.Text = "Shuffle";
            CbShuffle.UseVisualStyleBackColor = true;
            // 
            // LbCreator
            // 
            LbCreator.AutoEllipsis = true;
            LbCreator.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCreator.Location = new Point(441, 48);
            LbCreator.Name = "LbCreator";
            LbCreator.Size = new Size(287, 24);
            LbCreator.TabIndex = 3;
            LbCreator.Text = "Owners";
            // 
            // LbOwnedBy
            // 
            LbOwnedBy.AutoSize = true;
            LbOwnedBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOwnedBy.Location = new Point(360, 47);
            LbOwnedBy.Name = "LbOwnedBy";
            LbOwnedBy.Size = new Size(84, 21);
            LbOwnedBy.TabIndex = 7;
            LbOwnedBy.Text = "Owned by:";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(142, 107);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 8;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // PlaylistView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnDelete);
            Controls.Add(LbOwnedBy);
            Controls.Add(LbCreator);
            Controls.Add(CbShuffle);
            Controls.Add(FlpOpnamens);
            Controls.Add(LbPlaylistName);
            Name = "PlaylistView";
            Size = new Size(797, 466);
            Load += PlaylistView_Load;
            ResumeLayout(false);
            PerformLayout();
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
