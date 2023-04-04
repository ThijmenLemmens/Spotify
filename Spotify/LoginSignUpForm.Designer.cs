namespace Spotify {
    partial class LoginSignUpForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSignUpForm));
            LbLoginSignUp = new Label();
            RbLogin = new RadioButton();
            RbSignUp = new RadioButton();
            TbAccountName = new TextBox();
            TbPassword = new TextBox();
            BtnLoginSignUp = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LbLoginSignUp
            // 
            LbLoginSignUp.AutoSize = true;
            LbLoginSignUp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LbLoginSignUp.Location = new Point(113, 3);
            LbLoginSignUp.Name = "LbLoginSignUp";
            LbLoginSignUp.Size = new Size(157, 30);
            LbLoginSignUp.TabIndex = 0;
            LbLoginSignUp.Text = "Login / SignUp";
            // 
            // RbLogin
            // 
            RbLogin.AutoSize = true;
            RbLogin.Checked = true;
            RbLogin.Location = new Point(15, 3);
            RbLogin.Name = "RbLogin";
            RbLogin.Size = new Size(55, 19);
            RbLogin.TabIndex = 1;
            RbLogin.TabStop = true;
            RbLogin.Text = "Login";
            RbLogin.UseVisualStyleBackColor = true;
            RbLogin.CheckedChanged += RbLogin_CheckedChanged;
            // 
            // RbSignUp
            // 
            RbSignUp.AutoSize = true;
            RbSignUp.Location = new Point(76, 3);
            RbSignUp.Name = "RbSignUp";
            RbSignUp.Size = new Size(63, 19);
            RbSignUp.TabIndex = 2;
            RbSignUp.Text = "SignUp";
            RbSignUp.UseVisualStyleBackColor = true;
            RbSignUp.CheckedChanged += RbSignUp_CheckedChanged;
            // 
            // TbAccountName
            // 
            TbAccountName.Location = new Point(113, 61);
            TbAccountName.Name = "TbAccountName";
            TbAccountName.PlaceholderText = "Account Name";
            TbAccountName.Size = new Size(157, 23);
            TbAccountName.TabIndex = 3;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(113, 90);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(157, 23);
            TbPassword.TabIndex = 4;
            // 
            // BtnLoginSignUp
            // 
            BtnLoginSignUp.Location = new Point(113, 119);
            BtnLoginSignUp.Name = "BtnLoginSignUp";
            BtnLoginSignUp.Size = new Size(157, 23);
            BtnLoginSignUp.TabIndex = 5;
            BtnLoginSignUp.Text = "Login";
            BtnLoginSignUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(RbLogin);
            panel1.Controls.Add(RbSignUp);
            panel1.Location = new Point(113, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 25);
            panel1.TabIndex = 6;
            // 
            // LoginSignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 160);
            Controls.Add(panel1);
            Controls.Add(BtnLoginSignUp);
            Controls.Add(TbPassword);
            Controls.Add(TbAccountName);
            Controls.Add(LbLoginSignUp);
            Icon = (Icon) resources.GetObject("$this.Icon");
            MaximumSize = new Size(401, 199);
            MinimumSize = new Size(401, 199);
            Name = "LoginSignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login / SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbLoginSignUp;
        private RadioButton RbLogin;
        private RadioButton RbSignUp;
        private TextBox TbAccountName;
        private TextBox TbPassword;
        private Button BtnLoginSignUp;
        private Panel panel1;
    }
}