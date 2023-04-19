namespace Spotify.customControlls {
    partial class AlbumView {
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
            FlpOpnamens = new FlowLayoutPanel();
            CbShuffle = new CheckBox();
            LbOwnedBy = new Label();
            LbCreator = new Label();
            LbAlbumName = new Label();
            CbAddToPlaylist = new ComboBox();
            LbAddTo = new Label();
            SuspendLayout();
            // 
            // FlpOpnamens
            // 
            FlpOpnamens.AutoScroll = true;
            FlpOpnamens.Location = new Point(76, 137);
            FlpOpnamens.Name = "FlpOpnamens";
            FlpOpnamens.Size = new Size(655, 311);
            FlpOpnamens.TabIndex = 2;
            // 
            // CbShuffle
            // 
            CbShuffle.AutoSize = true;
            CbShuffle.Location = new Point(74, 112);
            CbShuffle.Name = "CbShuffle";
            CbShuffle.Size = new Size(63, 19);
            CbShuffle.TabIndex = 7;
            CbShuffle.Text = "Shuffle";
            CbShuffle.UseVisualStyleBackColor = true;
            // 
            // LbOwnedBy
            // 
            LbOwnedBy.AutoSize = true;
            LbOwnedBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOwnedBy.Location = new Point(364, 44);
            LbOwnedBy.Name = "LbOwnedBy";
            LbOwnedBy.Size = new Size(84, 21);
            LbOwnedBy.TabIndex = 13;
            LbOwnedBy.Text = "Owned by:";
            // 
            // LbCreator
            // 
            LbCreator.AutoEllipsis = true;
            LbCreator.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCreator.Location = new Point(445, 45);
            LbCreator.Name = "LbCreator";
            LbCreator.Size = new Size(287, 24);
            LbCreator.TabIndex = 12;
            LbCreator.Text = "Owners";
            // 
            // LbAlbumName
            // 
            LbAlbumName.AutoEllipsis = true;
            LbAlbumName.Font = new Font("Microsoft YaHei", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LbAlbumName.Location = new Point(16, 11);
            LbAlbumName.Name = "LbAlbumName";
            LbAlbumName.Size = new Size(332, 62);
            LbAlbumName.TabIndex = 11;
            LbAlbumName.Text = "Album Name";
            // 
            // CbAddToPlaylist
            // 
            CbAddToPlaylist.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAddToPlaylist.FormattingEnabled = true;
            CbAddToPlaylist.Location = new Point(192, 112);
            CbAddToPlaylist.Name = "CbAddToPlaylist";
            CbAddToPlaylist.Size = new Size(121, 23);
            CbAddToPlaylist.TabIndex = 14;
            CbAddToPlaylist.SelectedIndexChanged += CbAddToPlaylist_SelectedIndexChanged;
            // 
            // LbAddTo
            // 
            LbAddTo.AutoSize = true;
            LbAddTo.Location = new Point(143, 113);
            LbAddTo.Name = "LbAddTo";
            LbAddTo.Size = new Size(43, 15);
            LbAddTo.TabIndex = 15;
            LbAddTo.Text = "Add to";
            // 
            // AlbumView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbAddTo);
            Controls.Add(CbAddToPlaylist);
            Controls.Add(LbOwnedBy);
            Controls.Add(LbCreator);
            Controls.Add(LbAlbumName);
            Controls.Add(CbShuffle);
            Controls.Add(FlpOpnamens);
            Name = "AlbumView";
            Size = new Size(797, 466);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FlpOpnamens;
        private CheckBox CbShuffle;
        private Label LbOwnedBy;
        private Label LbCreator;
        private Label LbAlbumName;
        private ComboBox CbAddToPlaylist;
        private Label LbAddTo;
    }
}
