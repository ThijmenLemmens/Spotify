﻿namespace Spotify.customControlls {
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
            Lbwelkom = new Label();
            LbName = new Label();
            SuspendLayout();
            // 
            // Lbwelkom
            // 
            Lbwelkom.AutoSize = true;
            Lbwelkom.Font = new Font("Corbel", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Lbwelkom.Location = new Point(21, 14);
            Lbwelkom.Name = "Lbwelkom";
            Lbwelkom.Size = new Size(113, 36);
            Lbwelkom.TabIndex = 0;
            Lbwelkom.Text = "Welkom";
            // 
            // LbName
            // 
            LbName.AutoSize = true;
            LbName.Font = new Font("Corbel", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbName.Location = new Point(153, 40);
            LbName.Name = "LbName";
            LbName.Size = new Size(0, 36);
            LbName.TabIndex = 1;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbName);
            Controls.Add(Lbwelkom);
            Name = "HomeView";
            Size = new Size(797, 466);
            Load += HomeView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbwelkom;
        private Label LbName;
    }
}
