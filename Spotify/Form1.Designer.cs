using System.Windows.Forms;

namespace Spotify {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GbUnder = new System.Windows.Forms.GroupBox();
            this.CbRepeat = new System.Windows.Forms.CheckBox();
            this.LbArtiest = new System.Windows.Forms.Label();
            this.LbSongName = new System.Windows.Forms.Label();
            this.BtnPlayStop = new System.Windows.Forms.PictureBox();
            this.GbSidebar = new System.Windows.Forms.GroupBox();
            this.BtnFriends = new System.Windows.Forms.Button();
            this.FlpPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.LbPlaylist = new System.Windows.Forms.Label();
            this.BtnCreatePlayList = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.GbMainSection = new System.Windows.Forms.GroupBox();
            this.GbUnder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlayStop)).BeginInit();
            this.GbSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbUnder
            // 
            this.GbUnder.Controls.Add(this.CbRepeat);
            this.GbUnder.Controls.Add(this.LbArtiest);
            this.GbUnder.Controls.Add(this.LbSongName);
            this.GbUnder.Controls.Add(this.BtnPlayStop);
            this.GbUnder.Location = new System.Drawing.Point(0, 449);
            this.GbUnder.Name = "GbUnder";
            this.GbUnder.Size = new System.Drawing.Size(954, 108);
            this.GbUnder.TabIndex = 0;
            this.GbUnder.TabStop = false;
            // 
            // CbRepeat
            // 
            this.CbRepeat.AutoSize = true;
            this.CbRepeat.Location = new System.Drawing.Point(886, 28);
            this.CbRepeat.Name = "CbRepeat";
            this.CbRepeat.Size = new System.Drawing.Size(62, 19);
            this.CbRepeat.TabIndex = 5;
            this.CbRepeat.Text = "Repeat";
            this.CbRepeat.UseVisualStyleBackColor = true;
            this.CbRepeat.CheckedChanged += new System.EventHandler(this.CbRepeat_CheckedChanged);
            // 
            // LbArtiest
            // 
            this.LbArtiest.AutoSize = true;
            this.LbArtiest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbArtiest.Location = new System.Drawing.Point(12, 62);
            this.LbArtiest.Name = "LbArtiest";
            this.LbArtiest.Size = new System.Drawing.Size(101, 21);
            this.LbArtiest.TabIndex = 4;
            this.LbArtiest.Text = "Artiest Name";
            // 
            // LbSongName
            // 
            this.LbSongName.AutoEllipsis = true;
            this.LbSongName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSongName.Location = new System.Drawing.Point(12, 22);
            this.LbSongName.Name = "LbSongName";
            this.LbSongName.Size = new System.Drawing.Size(209, 30);
            this.LbSongName.TabIndex = 3;
            this.LbSongName.Text = "Song Name";
            // 
            // BtnPlayStop
            // 
            this.BtnPlayStop.Image = global::Spotify.Properties.Resource.pause;
            this.BtnPlayStop.Location = new System.Drawing.Point(455, 22);
            this.BtnPlayStop.Name = "BtnPlayStop";
            this.BtnPlayStop.Size = new System.Drawing.Size(43, 35);
            this.BtnPlayStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPlayStop.TabIndex = 0;
            this.BtnPlayStop.TabStop = false;
            this.BtnPlayStop.Click += new System.EventHandler(this.BtnPlayStop_Click);
            // 
            // GbSidebar
            // 
            this.GbSidebar.Controls.Add(this.BtnFriends);
            this.GbSidebar.Controls.Add(this.FlpPlaylist);
            this.GbSidebar.Controls.Add(this.LbPlaylist);
            this.GbSidebar.Controls.Add(this.BtnCreatePlayList);
            this.GbSidebar.Controls.Add(this.BtnSearch);
            this.GbSidebar.Controls.Add(this.BtnHome);
            this.GbSidebar.Location = new System.Drawing.Point(0, -8);
            this.GbSidebar.Name = "GbSidebar";
            this.GbSidebar.Size = new System.Drawing.Size(163, 466);
            this.GbSidebar.TabIndex = 1;
            this.GbSidebar.TabStop = false;
            // 
            // BtnFriends
            // 
            this.BtnFriends.Location = new System.Drawing.Point(6, 98);
            this.BtnFriends.Name = "BtnFriends";
            this.BtnFriends.Size = new System.Drawing.Size(145, 33);
            this.BtnFriends.TabIndex = 5;
            this.BtnFriends.Text = "Friends";
            this.BtnFriends.UseVisualStyleBackColor = true;
            this.BtnFriends.Click += new System.EventHandler(this.BtnFriends_Click);
            // 
            // FlpPlaylist
            // 
            this.FlpPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlpPlaylist.Location = new System.Drawing.Point(0, 203);
            this.FlpPlaylist.Name = "FlpPlaylist";
            this.FlpPlaylist.Size = new System.Drawing.Size(157, 260);
            this.FlpPlaylist.TabIndex = 4;
            // 
            // LbPlaylist
            // 
            this.LbPlaylist.AutoSize = true;
            this.LbPlaylist.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPlaylist.Location = new System.Drawing.Point(40, 172);
            this.LbPlaylist.Name = "LbPlaylist";
            this.LbPlaylist.Size = new System.Drawing.Size(73, 28);
            this.LbPlaylist.TabIndex = 3;
            this.LbPlaylist.Text = "Playlist";
            // 
            // BtnCreatePlayList
            // 
            this.BtnCreatePlayList.Location = new System.Drawing.Point(6, 136);
            this.BtnCreatePlayList.Name = "BtnCreatePlayList";
            this.BtnCreatePlayList.Size = new System.Drawing.Size(145, 33);
            this.BtnCreatePlayList.TabIndex = 2;
            this.BtnCreatePlayList.Text = "Create Playlist";
            this.BtnCreatePlayList.UseVisualStyleBackColor = true;
            this.BtnCreatePlayList.Click += new System.EventHandler(this.BtnCreatePlayList_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(6, 59);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(145, 33);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(6, 20);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(145, 33);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // GbMainSection
            // 
            this.GbMainSection.Location = new System.Drawing.Point(163, -8);
            this.GbMainSection.Name = "GbMainSection";
            this.GbMainSection.Size = new System.Drawing.Size(791, 465);
            this.GbMainSection.TabIndex = 2;
            this.GbMainSection.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 555);
            this.Controls.Add(this.GbMainSection);
            this.Controls.Add(this.GbSidebar);
            this.Controls.Add(this.GbUnder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(967, 594);
            this.MinimumSize = new System.Drawing.Size(967, 594);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbUnder.ResumeLayout(false);
            this.GbUnder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlayStop)).EndInit();
            this.GbSidebar.ResumeLayout(false);
            this.GbSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbUnder;
        private GroupBox GbSidebar;
        private GroupBox GbMainSection;
        private PictureBox BtnPlayStop;
        private Button BtnHome;
        private Button BtnSearch;
        private Button BtnCreatePlayList;
        private Label LbArtiest;
        private Label LbSongName;
        private FlowLayoutPanel FlpPlaylist;
        private Label LbPlaylist;
        private Button BtnFriends;
        private CheckBox CbRepeat;
    }
}