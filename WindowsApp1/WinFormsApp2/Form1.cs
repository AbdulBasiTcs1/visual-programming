namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "This is first label by text";
            lbl.Location = new Point(130, 55);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            TextBox tbx = new TextBox();
            tbx.Text = "Enter your name: ";
            tbx.Location = new Point(130, 100);
            this.Controls.Add(tbx);

            Button btn = new Button();
            btn.Text = "Done?";
            btn.Location = new Point(130, 130);
            this.Controls.Add(btn);

            CheckBox cbox1 = new CheckBox();
            cbox1.Text = "Check me 1";
            cbox1.Location = new Point(130, 160);
            this.Controls.Add(cbox1);

            CheckBox cbox2 = new CheckBox();
            cbox2.Text = "Check me 2";
            cbox2.Location = new Point(130, 190);
            this.Controls.Add(cbox2);

            CheckBox cbox3 = new CheckBox();
            cbox3.Text = "Check me 3";
            cbox3.Location = new Point(130, 220);
            this.Controls.Add(cbox3);

            // if clicked on checkbox, show message box
            cbox1.CheckedChanged += (sender, e) =>
            {
                if (cbox1.Checked)
                    MessageBox.Show(cbox1.Text);
            };

            cbox2.CheckedChanged += (sender, e) =>
            {
                if (cbox2.Checked)
                    MessageBox.Show(cbox2.Text);
            };

            cbox3.CheckedChanged += (sender, e) =>
            {
                if (cbox3.Checked)
                    MessageBox.Show(cbox3.Text);
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            TextBox tbx = new TextBox();
            tbx.Text = "9";
            tbx.Location = new Point(130, 250);
            this.Controls.Add(tbx);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TextBox tbx = new TextBox();
            tbx.Text = "4";
            tbx.Location = new Point(130, 250);
            this.Controls.Add(tbx);
        }
    }
}
