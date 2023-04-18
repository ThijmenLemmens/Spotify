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
            GbUnder = new GroupBox();
            CbRepeat = new CheckBox();
            LbArtiest = new Label();
            LbSongName = new Label();
            BtnPrev = new PictureBox();
            BtnNext = new PictureBox();
            BtnPlayStop = new PictureBox();
            GbSidebar = new GroupBox();
            BtnFriends = new Button();
            FlpPlaylist = new FlowLayoutPanel();
            LbPlaylist = new Label();
            BtnCreatePlayList = new Button();
            BtnSearch = new Button();
            BtnHome = new Button();
            GbMainSection = new GroupBox();
            GbUnder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) BtnPrev).BeginInit();
            ((System.ComponentModel.ISupportInitialize) BtnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize) BtnPlayStop).BeginInit();
            GbSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // GbUnder
            // 
            GbUnder.Controls.Add(CbRepeat);
            GbUnder.Controls.Add(LbArtiest);
            GbUnder.Controls.Add(LbSongName);
            GbUnder.Controls.Add(BtnPrev);
            GbUnder.Controls.Add(BtnNext);
            GbUnder.Controls.Add(BtnPlayStop);
            GbUnder.Location = new Point(0, 449);
            GbUnder.Name = "GbUnder";
            GbUnder.Size = new Size(954, 108);
            GbUnder.TabIndex = 0;
            GbUnder.TabStop = false;
            // 
            // CbRepeat
            // 
            CbRepeat.AutoSize = true;
            CbRepeat.Location = new Point(886, 28);
            CbRepeat.Name = "CbRepeat";
            CbRepeat.Size = new Size(62, 19);
            CbRepeat.TabIndex = 5;
            CbRepeat.Text = "Repeat";
            CbRepeat.UseVisualStyleBackColor = true;
            CbRepeat.CheckedChanged += CbRepeat_CheckedChanged;
            // 
            // LbArtiest
            // 
            LbArtiest.AutoSize = true;
            LbArtiest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbArtiest.Location = new Point(12, 62);
            LbArtiest.Name = "LbArtiest";
            LbArtiest.Size = new Size(101, 21);
            LbArtiest.TabIndex = 4;
            LbArtiest.Text = "Artiest Name";
            // 
            // LbSongName
            // 
            LbSongName.AutoEllipsis = true;
            LbSongName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LbSongName.Location = new Point(12, 22);
            LbSongName.Name = "LbSongName";
            LbSongName.Size = new Size(209, 30);
            LbSongName.TabIndex = 3;
            LbSongName.Text = "Song Name";
            // 
            // BtnPrev
            // 
            BtnPrev.Image = Properties.Resource.previous;
            BtnPrev.Location = new Point(410, 28);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(30, 23);
            BtnPrev.SizeMode = PictureBoxSizeMode.Zoom;
            BtnPrev.TabIndex = 2;
            BtnPrev.TabStop = false;
            // 
            // BtnNext
            // 
            BtnNext.Image = Properties.Resource.next;
            BtnNext.Location = new Point(515, 28);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(30, 23);
            BtnNext.SizeMode = PictureBoxSizeMode.Zoom;
            BtnNext.TabIndex = 1;
            BtnNext.TabStop = false;
            // 
            // BtnPlayStop
            // 
            BtnPlayStop.Image = Properties.Resource.pause;
            BtnPlayStop.Location = new Point(455, 22);
            BtnPlayStop.Name = "BtnPlayStop";
            BtnPlayStop.Size = new Size(43, 35);
            BtnPlayStop.SizeMode = PictureBoxSizeMode.Zoom;
            BtnPlayStop.TabIndex = 0;
            BtnPlayStop.TabStop = false;
            BtnPlayStop.Click += BtnPlayStop_Click;
            // 
            // GbSidebar
            // 
            GbSidebar.Controls.Add(BtnFriends);
            GbSidebar.Controls.Add(FlpPlaylist);
            GbSidebar.Controls.Add(LbPlaylist);
            GbSidebar.Controls.Add(BtnCreatePlayList);
            GbSidebar.Controls.Add(BtnSearch);
            GbSidebar.Controls.Add(BtnHome);
            GbSidebar.Location = new Point(0, -8);
            GbSidebar.Name = "GbSidebar";
            GbSidebar.Size = new Size(163, 466);
            GbSidebar.TabIndex = 1;
            GbSidebar.TabStop = false;
            // 
            // BtnFriends
            // 
            BtnFriends.Location = new Point(6, 98);
            BtnFriends.Name = "BtnFriends";
            BtnFriends.Size = new Size(145, 33);
            BtnFriends.TabIndex = 5;
            BtnFriends.Text = "Friends";
            BtnFriends.UseVisualStyleBackColor = true;
            BtnFriends.Click += BtnFriends_Click;
            // 
            // FlpPlaylist
            // 
            FlpPlaylist.BackgroundImageLayout = ImageLayout.None;
            FlpPlaylist.Location = new Point(0, 203);
            FlpPlaylist.Name = "FlpPlaylist";
            FlpPlaylist.Size = new Size(157, 260);
            FlpPlaylist.TabIndex = 4;
            // 
            // LbPlaylist
            // 
            LbPlaylist.AutoSize = true;
            LbPlaylist.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LbPlaylist.Location = new Point(40, 172);
            LbPlaylist.Name = "LbPlaylist";
            LbPlaylist.Size = new Size(73, 28);
            LbPlaylist.TabIndex = 3;
            LbPlaylist.Text = "Playlist";
            // 
            // BtnCreatePlayList
            // 
            BtnCreatePlayList.Location = new Point(6, 136);
            BtnCreatePlayList.Name = "BtnCreatePlayList";
            BtnCreatePlayList.Size = new Size(145, 33);
            BtnCreatePlayList.TabIndex = 2;
            BtnCreatePlayList.Text = "Create Playlist";
            BtnCreatePlayList.UseVisualStyleBackColor = true;
            BtnCreatePlayList.Click += BtnCreatePlayList_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(6, 59);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(145, 33);
            BtnSearch.TabIndex = 1;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnHome
            // 
            BtnHome.Location = new Point(6, 20);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(145, 33);
            BtnHome.TabIndex = 0;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // GbMainSection
            // 
            GbMainSection.Location = new Point(163, -8);
            GbMainSection.Name = "GbMainSection";
            GbMainSection.Size = new Size(791, 465);
            GbMainSection.TabIndex = 2;
            GbMainSection.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 555);
            Controls.Add(GbMainSection);
            Controls.Add(GbSidebar);
            Controls.Add(GbUnder);
            Icon = (Icon) resources.GetObject("$this.Icon");
            MaximumSize = new Size(967, 594);
            MinimumSize = new Size(967, 594);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spotify";
            Load += Form1_Load;
            Shown += Form1_Shown;
            GbUnder.ResumeLayout(false);
            GbUnder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) BtnPrev).EndInit();
            ((System.ComponentModel.ISupportInitialize) BtnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize) BtnPlayStop).EndInit();
            GbSidebar.ResumeLayout(false);
            GbSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbUnder;
        private GroupBox GbSidebar;
        private GroupBox GbMainSection;
        private PictureBox BtnPlayStop;
        private PictureBox BtnNext;
        private PictureBox BtnPrev;
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