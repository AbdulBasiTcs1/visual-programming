using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q5_SplashApp
{
    public class SplashForm : Form
    {
        ProgressBar progressBar;
        Label lblProgress;
        Timer timer;

        public SplashForm()
        {
            Text = "Starting";
            Width = 500;
            Height = 300;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            PictureBox picture = new PictureBox();
            picture.Image = SystemIcons.Application.ToBitmap();
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Size = new Size(80, 80);
            picture.Location = new Point(210, 35);

            Label lblName = new Label();
            lblName.Text = "Student Login Application";
            lblName.Font = new Font("Arial", 18, FontStyle.Bold);
            lblName.AutoSize = true;
            lblName.Location = new Point(90, 130);

            progressBar = new ProgressBar();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Size = new Size(360, 25);
            progressBar.Location = new Point(55, 190);

            lblProgress = new Label();
            lblProgress.Text = "0%";
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(235, 225);

            Controls.Add(picture);
            Controls.Add(lblName);
            Controls.Add(progressBar);
            Controls.Add(lblProgress);

            timer = new Timer();
            timer.Interval = 40;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value++;
                lblProgress.Text = progressBar.Value + "%";
            }

            if (progressBar.Value == 100)
            {
                timer.Stop();

                LoginForm login = new LoginForm();
                login.FormClosed += (s, args) => this.Close();

                login.Show();
                this.Hide();
            }
        }
    }
}
