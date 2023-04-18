namespace Spotify.customControlls {
    partial class FriendsView {
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
            LbFriends = new Label();
            BtnAddFriend = new Button();
            TbFriendName = new TextBox();
            FlpFriends = new FlowLayoutPanel();
            GbFriendMainSection = new GroupBox();
            SuspendLayout();
            // 
            // LbFriends
            // 
            LbFriends.AutoSize = true;
            LbFriends.Font = new Font("Corbel", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbFriends.Location = new Point(24, 13);
            LbFriends.Name = "LbFriends";
            LbFriends.Size = new Size(104, 36);
            LbFriends.TabIndex = 0;
            LbFriends.Text = "Friends";
            // 
            // BtnAddFriend
            // 
            BtnAddFriend.Location = new Point(706, 13);
            BtnAddFriend.Name = "BtnAddFriend";
            BtnAddFriend.Size = new Size(75, 23);
            BtnAddFriend.TabIndex = 2;
            BtnAddFriend.Text = "Add Friend";
            BtnAddFriend.UseVisualStyleBackColor = true;
            BtnAddFriend.Click += BtnAddFriend_Click;
            // 
            // TbFriendName
            // 
            TbFriendName.Location = new Point(600, 13);
            TbFriendName.Name = "TbFriendName";
            TbFriendName.Size = new Size(100, 23);
            TbFriendName.TabIndex = 3;
            // 
            // FlpFriends
            // 
            FlpFriends.BorderStyle = BorderStyle.FixedSingle;
            FlpFriends.Location = new Point(24, 101);
            FlpFriends.Name = "FlpFriends";
            FlpFriends.Size = new Size(117, 340);
            FlpFriends.TabIndex = 4;
            // 
            // GbFriendMainSection
            // 
            GbFriendMainSection.Location = new Point(159, 93);
            GbFriendMainSection.Name = "GbFriendMainSection";
            GbFriendMainSection.Size = new Size(622, 348);
            GbFriendMainSection.TabIndex = 5;
            GbFriendMainSection.TabStop = false;
            GbFriendMainSection.Text = "FriendInfo";
            // 
            // FriendsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GbFriendMainSection);
            Controls.Add(FlpFriends);
            Controls.Add(TbFriendName);
            Controls.Add(BtnAddFriend);
            Controls.Add(LbFriends);
            Name = "FriendsView";
            Size = new Size(797, 466);
            Load += FriendsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbFriends;
        private Button BtnAddFriend;
        private TextBox TbFriendName;
        private FlowLayoutPanel FlpFriends;
        private GroupBox GbFriendMainSection;
    }
}
