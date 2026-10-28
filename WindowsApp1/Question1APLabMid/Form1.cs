using Question1APLabMid;
using System;
using System.Windows.Forms;
2
namespace Question1APLabMid
{
    public partial class Form1 : Form
    {
        int attemptsRemaining = 3;

        string correctUsername = "student";
        string correctPassword = "1234";

        public Form1()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
            lblAttempts.Text = "3 attempts remaining";
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter both username and password.");
                return;
            }

            if (txtUsername.Text == correctUsername &&
                txtPassword.Text == correctPassword)
            {
                DashboardForm dashboard =
                    new DashboardForm(txtUsername.Text, this);

                this.Hide();
                dashboard.Show();
            }
            else
            {
                attemptsRemaining--;
                lblAttempts.Text = attemptsRemaining + " attempts remaining";

                if (attemptsRemaining == 0)
                {
                    btnLogin.Enabled = false;
                    MessageBox.Show("Login is locked.");
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
        }
    }
}