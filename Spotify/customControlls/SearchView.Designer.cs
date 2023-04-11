namespace Spotify.customControlls {
    partial class SearchView {
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
            this.FlpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.LbSearch = new System.Windows.Forms.Label();
            this.CbCats = new System.Windows.Forms.ComboBox();
            this.LbDiscover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FlpSearch
            // 
            this.FlpSearch.AutoScroll = true;
            this.FlpSearch.Location = new System.Drawing.Point(67, 133);
            this.FlpSearch.Name = "FlpSearch";
            this.FlpSearch.Size = new System.Drawing.Size(655, 311);
            this.FlpSearch.TabIndex = 0;
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(139, 104);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(161, 23);
            this.TbSearch.TabIndex = 1;
            // 
            // LbSearch
            // 
            this.LbSearch.AutoSize = true;
            this.LbSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSearch.Location = new System.Drawing.Point(83, 105);
            this.LbSearch.Name = "LbSearch";
            this.LbSearch.Size = new System.Drawing.Size(53, 20);
            this.LbSearch.TabIndex = 2;
            this.LbSearch.Text = "Search";
            // 
            // CbCats
            // 
            this.CbCats.BackColor = System.Drawing.SystemColors.Window;
            this.CbCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCats.FormattingEnabled = true;
            this.CbCats.Items.AddRange(new object[] {
            "Songs",
            "Album"});
            this.CbCats.Location = new System.Drawing.Point(306, 104);
            this.CbCats.Name = "CbCats";
            this.CbCats.Size = new System.Drawing.Size(121, 23);
            this.CbCats.TabIndex = 3;
            this.CbCats.SelectedIndexChanged += new System.EventHandler(this.CbCats_SelectedIndexChanged);
            // 
            // LbDiscover
            // 
            this.LbDiscover.AutoSize = true;
            this.LbDiscover.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDiscover.Location = new System.Drawing.Point(37, 22);
            this.LbDiscover.Name = "LbDiscover";
            this.LbDiscover.Size = new System.Drawing.Size(118, 37);
            this.LbDiscover.TabIndex = 4;
            this.LbDiscover.Tag = "";
            this.LbDiscover.Text = "Discover";
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbDiscover);
            this.Controls.Add(this.CbCats);
            this.Controls.Add(this.LbSearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.FlpSearch);
            this.Name = "SearchView";
            this.Size = new System.Drawing.Size(797, 466);
            this.Load += new System.EventHandler(this.SearchView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel FlpSearch;
        private TextBox TbSearch;
        private Label LbSearch;
        private ComboBox CbCats;
        private Label LbDiscover;
    }
}
