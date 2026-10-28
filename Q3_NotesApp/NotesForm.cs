using System;
using System.IO;
using System.Windows.Forms;

namespace Q3_NotesApp
{
    public class NotesForm : Form
    {
        TextBox txtNotes;
        Button btnOpen;
        Button btnSave;

        public NotesForm()
        {
            Text = "Simple Notes";
            Width = 700;
            Height = 500;
            StartPosition = FormStartPosition.CenterScreen;

            FlowLayoutPanel buttons = new FlowLayoutPanel();
            buttons.Dock = DockStyle.Top;
            buttons.Height = 45;

            btnOpen = new Button();
            btnOpen.Text = "Open";
            btnOpen.Width = 90;
            btnOpen.Click += btnOpen_Click;

            btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Width = 90;
            btnSave.Click += btnSave_Click;

            buttons.Controls.Add(btnOpen);
            buttons.Controls.Add(btnSave);

            txtNotes = new TextBox();
            txtNotes.Multiline = true;
            txtNotes.ScrollBars = ScrollBars.Both;
            txtNotes.AcceptsReturn = true;
            txtNotes.AcceptsTab = true;
            txtNotes.Dock = DockStyle.Fill;

            Controls.Add(txtNotes);
            Controls.Add(buttons);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
                txtNotes.Text = File.ReadAllText(dialog.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.DefaultExt = "txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, txtNotes.Text);
                MessageBox.Show("Notes saved.");
            }
        }
    }
}
