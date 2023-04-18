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
            FlpSearch = new FlowLayoutPanel();
            TbSearch = new TextBox();
            LbSearch = new Label();
            CbCats = new ComboBox();
            LbDiscover = new Label();
            SuspendLayout();
            // 
            // FlpSearch
            // 
            FlpSearch.AutoScroll = true;
            FlpSearch.Location = new Point(67, 133);
            FlpSearch.Name = "FlpSearch";
            FlpSearch.Size = new Size(655, 311);
            FlpSearch.TabIndex = 0;
            // 
            // TbSearch
            // 
            TbSearch.Location = new Point(139, 104);
            TbSearch.Name = "TbSearch";
            TbSearch.Size = new Size(161, 23);
            TbSearch.TabIndex = 1;
            // 
            // LbSearch
            // 
            LbSearch.AutoSize = true;
            LbSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LbSearch.Location = new Point(83, 105);
            LbSearch.Name = "LbSearch";
            LbSearch.Size = new Size(53, 20);
            LbSearch.TabIndex = 2;
            LbSearch.Text = "Search";
            // 
            // CbCats
            // 
            CbCats.BackColor = SystemColors.Window;
            CbCats.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCats.FormattingEnabled = true;
            CbCats.Items.AddRange(new Object[] { "Songs", "Album" });
            CbCats.Location = new Point(306, 104);
            CbCats.Name = "CbCats";
            CbCats.Size = new Size(121, 23);
            CbCats.TabIndex = 3;
            CbCats.SelectedIndexChanged += CbCats_SelectedIndexChanged;
            // 
            // LbDiscover
            // 
            LbDiscover.AutoSize = true;
            LbDiscover.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LbDiscover.Location = new Point(18, 12);
            LbDiscover.Name = "LbDiscover";
            LbDiscover.Size = new Size(118, 37);
            LbDiscover.TabIndex = 4;
            LbDiscover.Tag = "";
            LbDiscover.Text = "Discover";
            // 
            // SearchView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbDiscover);
            Controls.Add(CbCats);
            Controls.Add(LbSearch);
            Controls.Add(TbSearch);
            Controls.Add(FlpSearch);
            Name = "SearchView";
            Size = new Size(797, 466);
            Load += SearchView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FlpSearch;
        private TextBox TbSearch;
        private Label LbSearch;
        private ComboBox CbCats;
        private Label LbDiscover;
    }
}
