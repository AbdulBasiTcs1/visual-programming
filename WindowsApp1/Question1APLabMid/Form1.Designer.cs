namespace Question1APLabMid
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
            Username = new TextBox();
            Password = new TextBox();
            checkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnClear = new Button();
            lblAttempts = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(152, 36);
            Username.Name = "Username";
            Username.Size = new Size(125, 27);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(152, 85);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(125, 27);
            Password.TabIndex = 1;
            // 
            // checkShowPassword
            // 
            checkShowPassword.AutoSize = true;
            checkShowPassword.Location = new Point(343, 81);
            checkShowPassword.Name = "checkShowPassword";
            checkShowPassword.Size = new Size(132, 24);
            checkShowPassword.TabIndex = 2;
            checkShowPassword.Text = "Show Password";
            checkShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(192, 191);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(363, 191);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(273, 304);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(139, 20);
            lblAttempts.TabIndex = 5;
            lblAttempts.Text = "3 attempts remaing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAttempts);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(checkShowPassword);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private CheckBox checkShowPassword;
        private Button btnLogin;
        private Button btnClear;
        private Label lblAttempts;
    }
}
