using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q5_SplashApp
{
    public class LoginForm : Form
    {
        TextBox txtUsername;
        TextBox txtPassword;

        public LoginForm()
        {
            Text = "Login Form";
            Width = 400;
            Height = 260;
            StartPosition = FormStartPosition.CenterScreen;

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(40, 40);
            lblUsername.AutoSize = true;

            txtUsername = new TextBox();
            txtUsername.Location = new Point(130, 37);
            txtUsername.Width = 200;

            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new Point(40, 85);
            lblPassword.AutoSize = true;

            txtPassword = new TextBox();
            txtPassword.Location = new Point(130, 82);
            txtPassword.Width = 200;
            txtPassword.PasswordChar = '*';

            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(130, 130);
            btnLogin.Click += btnLogin_Click;

            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Enter username and password.");
            else
                MessageBox.Show("Login form opened successfully.");
        }
    }
}
