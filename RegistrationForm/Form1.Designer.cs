namespace RegistrationForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblSignUp = new Label();
            btnRegister = new Button();
            btnSignIn = new Button();
            lblConPassword = new Label();
            txtConPassword = new TextBox();
            chkRememberMe = new CheckBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(243, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(144, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(144, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(407, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(144, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(263, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 15);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Create username:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(444, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Enter email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(263, 211);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Create password:";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 12F);
            lblSignUp.Location = new Point(367, 90);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(65, 21);
            lblSignUp.TabIndex = 8;
            lblSignUp.Text = "Sign Up";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(347, 281);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(106, 23);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Create account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(363, 335);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 10;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lblConPassword
            // 
            lblConPassword.AutoSize = true;
            lblConPassword.Location = new Point(426, 211);
            lblConPassword.Name = "lblConPassword";
            lblConPassword.Size = new Size(110, 15);
            lblConPassword.TabIndex = 11;
            lblConPassword.Text = "Confirm password:";
            // 
            // txtConPassword
            // 
            txtConPassword.Location = new Point(407, 238);
            txtConPassword.Name = "txtConPassword";
            txtConPassword.Size = new Size(144, 23);
            txtConPassword.TabIndex = 12;
            txtConPassword.UseSystemPasswordChar = true;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(347, 310);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(110, 19);
            chkRememberMe.TabIndex = 13;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkRememberMe);
            Controls.Add(txtConPassword);
            Controls.Add(lblConPassword);
            Controls.Add(btnSignIn);
            Controls.Add(btnRegister);
            Controls.Add(lblSignUp);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblSignUp;
        private Button button1;
        private Button btnSignIn;
        private Button btnRegister;
        private Label lblConPassword;
        private TextBox txtConPassword;
        private CheckBox chkRememberMe;
    }
}
