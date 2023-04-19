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
            CbCats = new ComboBox();
            LbDiscover = new Label();
            LbCategorie = new Label();
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
            // CbCats
            // 
            CbCats.BackColor = SystemColors.Window;
            CbCats.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCats.FormattingEnabled = true;
            CbCats.Items.AddRange(new Object[] { "Songs", "Album" });
            CbCats.Location = new Point(147, 109);
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
            // LbCategorie
            // 
            LbCategorie.AutoSize = true;
            LbCategorie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCategorie.Location = new Point(67, 109);
            LbCategorie.Name = "LbCategorie";
            LbCategorie.Size = new Size(74, 21);
            LbCategorie.TabIndex = 5;
            LbCategorie.Text = "categorie";
            // 
            // SearchView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbCategorie);
            Controls.Add(LbDiscover);
            Controls.Add(CbCats);
            Controls.Add(FlpSearch);
            Name = "SearchView";
            Size = new Size(797, 466);
            Load += SearchView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FlpSearch;
        private ComboBox CbCats;
        private Label LbDiscover;
        private Label LbCategorie;
    }
}
