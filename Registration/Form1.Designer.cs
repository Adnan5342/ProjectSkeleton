namespace Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSignUp = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            username = new TextBox();
            email = new TextBox();
            lblPass = new Label();
            password = new TextBox();
            lblConPass = new Label();
            conPassword = new TextBox();
            btnRegister = new Button();
            lnkLblSignIn = new LinkLabel();
            chkRemember = new CheckBox();
            SuspendLayout();
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSignUp.Location = new Point(359, 127);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(79, 15);
            lblSignUp.TabIndex = 0;
            lblSignUp.Text = "Sign up form";
            lblSignUp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(291, 164);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(468, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // username
            // 
            username.Location = new Point(246, 182);
            username.Name = "username";
            username.Size = new Size(145, 23);
            username.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(411, 182);
            email.Name = "email";
            email.Size = new Size(145, 23);
            email.TabIndex = 4;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(294, 223);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(246, 241);
            password.Name = "password";
            password.Size = new Size(145, 23);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            // 
            // lblConPass
            // 
            lblConPass.AutoSize = true;
            lblConPass.Location = new Point(430, 223);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(104, 15);
            lblConPass.TabIndex = 7;
            lblConPass.Text = "Confirm password";
            // 
            // conPassword
            // 
            conPassword.Location = new Point(411, 241);
            conPassword.Name = "conPassword";
            conPassword.Size = new Size(145, 23);
            conPassword.TabIndex = 8;
            conPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(339, 279);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 23);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lnkLblSignIn
            // 
            lnkLblSignIn.AutoSize = true;
            lnkLblSignIn.Location = new Point(383, 305);
            lnkLblSignIn.Name = "lnkLblSignIn";
            lnkLblSignIn.Size = new Size(43, 15);
            lnkLblSignIn.TabIndex = 10;
            lnkLblSignIn.TabStop = true;
            lnkLblSignIn.Text = "Sign in";
            lnkLblSignIn.LinkClicked += lnkLblSignIn_LinkClicked;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(458, 330);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(104, 19);
            chkRemember.TabIndex = 11;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = true;
            chkRemember.CheckedChanged += chkRemember_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkRemember);
            Controls.Add(lnkLblSignIn);
            Controls.Add(btnRegister);
            Controls.Add(conPassword);
            Controls.Add(lblConPass);
            Controls.Add(password);
            Controls.Add(lblPass);
            Controls.Add(email);
            Controls.Add(username);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblSignUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUp;
        private Label lblUsername;
        private Label lblEmail;
        private TextBox username;
        private TextBox email;
        private Label lblPass;
        private TextBox password;
        private Label lblConPass;
        private TextBox conPassword;
        private Button btnRegister;
        private LinkLabel lnkLblSignIn;
        private CheckBox chkRemember;
    }
}
