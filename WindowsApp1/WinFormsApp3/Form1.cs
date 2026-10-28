using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        private bool isModified;

        public Form1()
        {
            InitializeComponent();
            currentFilePath = null;
            isModified = false;
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStatus();
            // start timer to update current time in status bar
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            isModified = true;
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            string name = currentFilePath == null ? "Untitled" : Path.GetFileName(currentFilePath);
            this.Text = name + " - Notepad" + (isModified ? "*" : "");
            toolStripStatusLabel1.Text = currentFilePath ?? "Untitled";
            // set initial time as well
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private bool PromptSaveIfNeeded()
        {
            if (!isModified) return true;
            var result = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return false;
            if (result == DialogResult.Yes) return SaveFile();
            return true;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded()) return;
            textBox1.Clear();
            currentFilePath = null;
            isModified = false;
            UpdateStatus();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded()) return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = openFileDialog1.FileName;
                    textBox1.Text = File.ReadAllText(currentFilePath);
                    isModified = false;
                    UpdateStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveFile()
        {
            try
            {
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    return SaveAsFile();
                }
                File.WriteAllText(currentFilePath, textBox1.Text);
                isModified = false;
                UpdateStatus();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SaveAsFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = saveFileDialog1.FileName;
                    File.WriteAllText(currentFilePath, textBox1.Text);
                    isModified = false;
                    UpdateStatus();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PromptSaveIfNeeded())
            {
                e.Cancel = true;
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = sender as ToolStripMenuItem;
            if (menu == null) return;
            textBox1.WordWrap = menu.Checked;
            textBox1.ScrollBars = menu.Checked ? ScrollBars.Vertical : ScrollBars.Both;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Notepad\nBuilt with WinForms.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
