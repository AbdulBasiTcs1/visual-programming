using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public class SplashForm : Form
    {
        private Label labelTitle;
        private Label labelTime;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer closeTimer;

        public int DurationMilliseconds { get; set; } = 3000;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTitle = new Label();
            this.labelTime = new Label();
            this.updateTimer = new System.Windows.Forms.Timer();
            this.closeTimer = new System.Windows.Forms.Timer();

            // Form
            this.ClientSize = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // labelTitle
            this.labelTitle.AutoSize = false;
            this.labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitle.Dock = DockStyle.Top;
            this.labelTitle.Height = 120;
            this.labelTitle.Text = "Notepad";

            // labelTime
            this.labelTime.AutoSize = false;
            this.labelTime.TextAlign = ContentAlignment.MiddleCenter;
            this.labelTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.labelTime.Dock = DockStyle.Bottom;
            this.labelTime.Height = 40;

            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTime);

            // updateTimer
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += UpdateTimer_Tick;

            // closeTimer
            this.closeTimer.Interval = this.DurationMilliseconds;
            this.closeTimer.Tick += CloseTimer_Tick;

            this.Shown += SplashForm_Shown;
        }

        private void SplashForm_Shown(object? sender, EventArgs e)
        {
            UpdateTimer_Tick(this, EventArgs.Empty);
            updateTimer.Start();
            closeTimer.Interval = DurationMilliseconds;
            closeTimer.Start();
        }

        private void UpdateTimer_Tick(object? sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CloseTimer_Tick(object? sender, EventArgs e)
        {
            updateTimer.Stop();
            closeTimer.Stop();
            this.Close();
        }
    }
}
