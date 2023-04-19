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
            this.LbLoginSignUp = new System.Windows.Forms.Label();
            this.RbLogin = new System.Windows.Forms.RadioButton();
            this.RbSignUp = new System.Windows.Forms.RadioButton();
            this.TbAccountName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnLoginSignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbLoginSignUp
            // 
            this.LbLoginSignUp.AutoSize = true;
            this.LbLoginSignUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbLoginSignUp.Location = new System.Drawing.Point(113, 3);
            this.LbLoginSignUp.Name = "LbLoginSignUp";
            this.LbLoginSignUp.Size = new System.Drawing.Size(157, 30);
            this.LbLoginSignUp.TabIndex = 0;
            this.LbLoginSignUp.Text = "Login / SignUp";
            // 
            // RbLogin
            // 
            this.RbLogin.AutoSize = true;
            this.RbLogin.Checked = true;
            this.RbLogin.Location = new System.Drawing.Point(15, 3);
            this.RbLogin.Name = "RbLogin";
            this.RbLogin.Size = new System.Drawing.Size(55, 19);
            this.RbLogin.TabIndex = 1;
            this.RbLogin.TabStop = true;
            this.RbLogin.Text = "Login";
            this.RbLogin.UseVisualStyleBackColor = true;
            this.RbLogin.CheckedChanged += new System.EventHandler(this.RbLogin_CheckedChanged);
            // 
            // RbSignUp
            // 
            this.RbSignUp.AutoSize = true;
            this.RbSignUp.Location = new System.Drawing.Point(76, 3);
            this.RbSignUp.Name = "RbSignUp";
            this.RbSignUp.Size = new System.Drawing.Size(63, 19);
            this.RbSignUp.TabIndex = 2;
            this.RbSignUp.Text = "SignUp";
            this.RbSignUp.UseVisualStyleBackColor = true;
            this.RbSignUp.CheckedChanged += new System.EventHandler(this.RbSignUp_CheckedChanged);
            // 
            // TbAccountName
            // 
            this.TbAccountName.Location = new System.Drawing.Point(113, 61);
            this.TbAccountName.Name = "TbAccountName";
            this.TbAccountName.PlaceholderText = "Account Name";
            this.TbAccountName.Size = new System.Drawing.Size(157, 23);
            this.TbAccountName.TabIndex = 3;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(113, 90);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PlaceholderText = "Password";
            this.TbPassword.Size = new System.Drawing.Size(157, 23);
            this.TbPassword.TabIndex = 4;
            // 
            // BtnLoginSignUp
            // 
            this.BtnLoginSignUp.Location = new System.Drawing.Point(113, 119);
            this.BtnLoginSignUp.Name = "BtnLoginSignUp";
            this.BtnLoginSignUp.Size = new System.Drawing.Size(157, 23);
            this.BtnLoginSignUp.TabIndex = 5;
            this.BtnLoginSignUp.Text = "Login";
            this.BtnLoginSignUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbLogin);
            this.panel1.Controls.Add(this.RbSignUp);
            this.panel1.Location = new System.Drawing.Point(113, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 25);
            this.panel1.TabIndex = 6;
            // 
            // LoginSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 160);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLoginSignUp);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbAccountName);
            this.Controls.Add(this.LbLoginSignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(401, 199);
            this.MinimumSize = new System.Drawing.Size(401, 199);
            this.Name = "LoginSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login / SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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