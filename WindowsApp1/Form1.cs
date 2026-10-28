using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // no-op load handler
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + txtName.Text +
                            "\nPassword: " + txtPassword.Text);

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
