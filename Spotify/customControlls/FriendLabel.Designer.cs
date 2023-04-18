namespace Spotify.customControlls {
    partial class FriendLabel {
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
            LbFriendName = new Label();
            SuspendLayout();
            // 
            // LbFriendName
            // 
            LbFriendName.AutoEllipsis = true;
            LbFriendName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbFriendName.Location = new Point(0, 0);
            LbFriendName.Name = "LbFriendName";
            LbFriendName.Size = new Size(139, 26);
            LbFriendName.TabIndex = 0;
            LbFriendName.Text = "FriendName";
            LbFriendName.Click += LbFriendName_Click;
            LbFriendName.MouseEnter += LbFriendName_MouseEnter;
            LbFriendName.MouseLeave += LbFriendName_MouseLeave;
            // 
            // FriendLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbFriendName);
            Name = "FriendLabel";
            Size = new Size(139, 26);
            ResumeLayout(false);
        }

        #endregion

        private Label LbFriendName;
    }
}
