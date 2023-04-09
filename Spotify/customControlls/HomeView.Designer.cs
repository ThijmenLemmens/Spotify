namespace Spotify.customControlls {
    partial class HomeView {
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
            this.Lbwelkom = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbwelkom
            // 
            this.Lbwelkom.AutoSize = true;
            this.Lbwelkom.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbwelkom.Location = new System.Drawing.Point(34, 40);
            this.Lbwelkom.Name = "Lbwelkom";
            this.Lbwelkom.Size = new System.Drawing.Size(113, 36);
            this.Lbwelkom.TabIndex = 0;
            this.Lbwelkom.Text = "Welkom";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbName.Location = new System.Drawing.Point(153, 40);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(0, 36);
            this.LbName.TabIndex = 1;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.Lbwelkom);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(797, 466);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbwelkom;
        private Label LbName;
    }
}
