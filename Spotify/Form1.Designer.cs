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
            this.GbUnder = new System.Windows.Forms.GroupBox();
            this.BtnPrev = new System.Windows.Forms.PictureBox();
            this.BtnNext = new System.Windows.Forms.PictureBox();
            this.BtnPlayStop = new System.Windows.Forms.PictureBox();
            this.GbSidebar = new System.Windows.Forms.GroupBox();
            this.BtnCreatePlayList = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.GbMainSection = new System.Windows.Forms.GroupBox();
            this.LbPlaylist = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LbSongName = new System.Windows.Forms.Label();
            this.LbArtiest = new System.Windows.Forms.Label();
            this.GbUnder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlayStop)).BeginInit();
            this.GbSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbUnder
            // 
            this.GbUnder.Controls.Add(this.LbArtiest);
            this.GbUnder.Controls.Add(this.LbSongName);
            this.GbUnder.Controls.Add(this.BtnPrev);
            this.GbUnder.Controls.Add(this.BtnNext);
            this.GbUnder.Controls.Add(this.BtnPlayStop);
            this.GbUnder.Location = new System.Drawing.Point(0, 449);
            this.GbUnder.Name = "GbUnder";
            this.GbUnder.Size = new System.Drawing.Size(954, 108);
            this.GbUnder.TabIndex = 0;
            this.GbUnder.TabStop = false;
            // 
            // BtnPrev
            // 
            this.BtnPrev.Image = global::Spotify.Properties.Resource.previous;
            this.BtnPrev.Location = new System.Drawing.Point(410, 28);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(30, 23);
            this.BtnPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPrev.TabIndex = 2;
            this.BtnPrev.TabStop = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Image = global::Spotify.Properties.Resource.next;
            this.BtnNext.Location = new System.Drawing.Point(515, 28);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(30, 23);
            this.BtnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNext.TabIndex = 1;
            this.BtnNext.TabStop = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
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
            this.GbSidebar.Controls.Add(this.flowLayoutPanel1);
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
            // BtnCreatePlayList
            // 
            this.BtnCreatePlayList.Location = new System.Drawing.Point(6, 98);
            this.BtnCreatePlayList.Name = "BtnCreatePlayList";
            this.BtnCreatePlayList.Size = new System.Drawing.Size(145, 33);
            this.BtnCreatePlayList.TabIndex = 2;
            this.BtnCreatePlayList.Text = "Create Playlist";
            this.BtnCreatePlayList.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(6, 59);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(145, 33);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(6, 20);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(145, 33);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            // 
            // GbMainSection
            // 
            this.GbMainSection.Location = new System.Drawing.Point(157, -8);
            this.GbMainSection.Name = "GbMainSection";
            this.GbMainSection.Size = new System.Drawing.Size(797, 466);
            this.GbMainSection.TabIndex = 2;
            this.GbMainSection.TabStop = false;
            // 
            // LbPlaylist
            // 
            this.LbPlaylist.AutoSize = true;
            this.LbPlaylist.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPlaylist.Location = new System.Drawing.Point(40, 134);
            this.LbPlaylist.Name = "LbPlaylist";
            this.LbPlaylist.Size = new System.Drawing.Size(73, 28);
            this.LbPlaylist.TabIndex = 3;
            this.LbPlaylist.Text = "Playlist";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(157, 295);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // LbSongName
            // 
            this.LbSongName.AutoSize = true;
            this.LbSongName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSongName.Location = new System.Drawing.Point(12, 22);
            this.LbSongName.Name = "LbSongName";
            this.LbSongName.Size = new System.Drawing.Size(127, 30);
            this.LbSongName.TabIndex = 3;
            this.LbSongName.Text = "Song Name";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 555);
            this.Controls.Add(this.GbMainSection);
            this.Controls.Add(this.GbSidebar);
            this.Controls.Add(this.GbUnder);
            this.MaximumSize = new System.Drawing.Size(967, 594);
            this.MinimumSize = new System.Drawing.Size(967, 594);
            this.Name = "Form1";
            this.Text = "Spotify";
            this.GbUnder.ResumeLayout(false);
            this.GbUnder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNext)).EndInit();
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
        private PictureBox BtnNext;
        private PictureBox BtnPrev;
        private Button BtnHome;
        private Button BtnSearch;
        private Button BtnCreatePlayList;
        private Label LbArtiest;
        private Label LbSongName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LbPlaylist;
    }
}