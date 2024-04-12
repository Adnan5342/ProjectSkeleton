namespace Registration
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSignIn = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            username = new TextBox();
            email = new TextBox();
            password = new TextBox();
            lnkLblRegister = new LinkLabel();
            btnSignIn = new Button();
            chkRemember = new CheckBox();
            SuspendLayout();
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Location = new Point(361, 88);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(43, 15);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign In";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(265, 122);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(467, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(347, 188);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // username
            // 
            username.Location = new Point(226, 140);
            username.Name = "username";
            username.Size = new Size(145, 23);
            username.TabIndex = 4;
            // 
            // email
            // 
            email.Location = new Point(418, 140);
            email.Name = "email";
            email.Size = new Size(145, 23);
            email.TabIndex = 5;
            // 
            // password
            // 
            password.Location = new Point(306, 206);
            password.Name = "password";
            password.Size = new Size(145, 23);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            // 
            // lnkLblRegister
            // 
            lnkLblRegister.AutoSize = true;
            lnkLblRegister.Location = new Point(329, 272);
            lnkLblRegister.Name = "lnkLblRegister";
            lnkLblRegister.Size = new Size(95, 15);
            lnkLblRegister.TabIndex = 12;
            lnkLblRegister.TabStop = true;
            lnkLblRegister.Text = "Register account";
            lnkLblRegister.LinkClicked += lnkLblRegister_LinkClicked;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(318, 246);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(115, 23);
            btnSignIn.TabIndex = 11;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(467, 310);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(104, 19);
            chkRemember.TabIndex = 13;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = true;
            chkRemember.CheckedChanged += chkRemember_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkRemember);
            Controls.Add(lnkLblRegister);
            Controls.Add(btnSignIn);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(username);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblSignIn);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignIn;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox username;
        private TextBox email;
        private TextBox password;
        private LinkLabel lnkLblRegister;
        private Button btnSignIn;
        private CheckBox chkRemember;
    }
}