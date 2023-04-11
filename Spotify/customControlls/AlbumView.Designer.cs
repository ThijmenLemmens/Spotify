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
            this.FlpOpnamens = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.BtnCopyList = new System.Windows.Forms.Button();
            this.CbShuffle = new System.Windows.Forms.CheckBox();
            this.LbOwnedBy = new System.Windows.Forms.Label();
            this.LbCreator = new System.Windows.Forms.Label();
            this.LbAlbumName = new System.Windows.Forms.Label();
            this.CbAddToPlaylist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FlpOpnamens
            // 
            this.FlpOpnamens.AutoScroll = true;
            this.FlpOpnamens.Location = new System.Drawing.Point(76, 137);
            this.FlpOpnamens.Name = "FlpOpnamens";
            this.FlpOpnamens.Size = new System.Drawing.Size(655, 311);
            this.FlpOpnamens.TabIndex = 2;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(239, 108);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(90, 23);
            this.BtnCompare.TabIndex = 9;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            // 
            // BtnCopyList
            // 
            this.BtnCopyList.Location = new System.Drawing.Point(143, 108);
            this.BtnCopyList.Name = "BtnCopyList";
            this.BtnCopyList.Size = new System.Drawing.Size(90, 23);
            this.BtnCopyList.TabIndex = 8;
            this.BtnCopyList.Text = "Copy List";
            this.BtnCopyList.UseVisualStyleBackColor = true;
            this.BtnCopyList.Click += new System.EventHandler(this.BtnCopyList_Click);
            // 
            // CbShuffle
            // 
            this.CbShuffle.AutoSize = true;
            this.CbShuffle.Location = new System.Drawing.Point(74, 112);
            this.CbShuffle.Name = "CbShuffle";
            this.CbShuffle.Size = new System.Drawing.Size(63, 19);
            this.CbShuffle.TabIndex = 7;
            this.CbShuffle.Text = "Shuffle";
            this.CbShuffle.UseVisualStyleBackColor = true;
            // 
            // LbOwnedBy
            // 
            this.LbOwnedBy.AutoSize = true;
            this.LbOwnedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbOwnedBy.Location = new System.Drawing.Point(364, 44);
            this.LbOwnedBy.Name = "LbOwnedBy";
            this.LbOwnedBy.Size = new System.Drawing.Size(84, 21);
            this.LbOwnedBy.TabIndex = 13;
            this.LbOwnedBy.Text = "Owned by:";
            // 
            // LbCreator
            // 
            this.LbCreator.AutoEllipsis = true;
            this.LbCreator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCreator.Location = new System.Drawing.Point(445, 45);
            this.LbCreator.Name = "LbCreator";
            this.LbCreator.Size = new System.Drawing.Size(287, 24);
            this.LbCreator.TabIndex = 12;
            this.LbCreator.Text = "Owners";
            // 
            // LbAlbumName
            // 
            this.LbAlbumName.AutoEllipsis = true;
            this.LbAlbumName.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAlbumName.Location = new System.Drawing.Point(16, 11);
            this.LbAlbumName.Name = "LbAlbumName";
            this.LbAlbumName.Size = new System.Drawing.Size(332, 62);
            this.LbAlbumName.TabIndex = 11;
            this.LbAlbumName.Text = "Album Name";
            // 
            // CbAddToPlaylist
            // 
            this.CbAddToPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAddToPlaylist.FormattingEnabled = true;
            this.CbAddToPlaylist.Location = new System.Drawing.Point(335, 108);
            this.CbAddToPlaylist.Name = "CbAddToPlaylist";
            this.CbAddToPlaylist.Size = new System.Drawing.Size(121, 23);
            this.CbAddToPlaylist.TabIndex = 14;
            this.CbAddToPlaylist.SelectedIndexChanged += new System.EventHandler(this.CbAddToPlaylist_SelectedIndexChanged);
            // 
            // AlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbAddToPlaylist);
            this.Controls.Add(this.LbOwnedBy);
            this.Controls.Add(this.LbCreator);
            this.Controls.Add(this.LbAlbumName);
            this.Controls.Add(this.BtnCompare);
            this.Controls.Add(this.BtnCopyList);
            this.Controls.Add(this.CbShuffle);
            this.Controls.Add(this.FlpOpnamens);
            this.Name = "AlbumView";
            this.Size = new System.Drawing.Size(797, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel FlpOpnamens;
        private Button BtnCompare;
        private Button BtnCopyList;
        private CheckBox CbShuffle;
        private Label LbOwnedBy;
        private Label LbCreator;
        private Label LbAlbumName;
        private ComboBox CbAddToPlaylist;
    }
}
