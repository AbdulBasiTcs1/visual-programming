namespace question2
{
    public sealed class NotesForm : Form
    {
        private readonly TextBox notesTextBox = new();
        private readonly Label fileNameLabel = new();

        public NotesForm()
        {
            Text = "Notes Application";
            ClientSize = new Size(800, 520);
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(600, 400);

            var titleLabel = new Label
            {
                Text = "My Notes",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(25, 20)
            };

            var openButton = new Button
            {
                Text = "Open",
                Width = 100,
                Height = 35,
                Location = new Point(25, 65)
            };
            openButton.Click += OpenButton_Click;

            var saveButton = new Button
            {
                Text = "Save",
                Width = 100,
                Height = 35,
                Location = new Point(135, 65)
            };
            saveButton.Click += SaveButton_Click;

            fileNameLabel.Text = "No file selected";
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(255, 75);
            fileNameLabel.ForeColor = Color.DarkBlue;

            notesTextBox.Multiline = true;
            notesTextBox.ScrollBars = ScrollBars.Both;
            notesTextBox.AcceptsTab = true;
            notesTextBox.WordWrap = false;
            notesTextBox.Font = new Font("Consolas", 11);
            notesTextBox.Location = new Point(25, 120);
            notesTextBox.Size = new Size(750, 365);
            notesTextBox.Anchor = AnchorStyles.Top |
                                  AnchorStyles.Bottom |
                                  AnchorStyles.Left |
                                  AnchorStyles.Right;

            Controls.Add(titleLabel);
            Controls.Add(openButton);
            Controls.Add(saveButton);
            Controls.Add(fileNameLabel);
            Controls.Add(notesTextBox);
        }

        private void OpenButton_Click(object? sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Open Notes File",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                CheckFileExists = true,
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                notesTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                fileNameLabel.Text = openFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to open the file.\n{ex.Message}",
                    "Open Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog
            {
                Title = "Save Notes File",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                AddExtension = true,
                FileName = "MyNotes.txt",
                OverwritePrompt = true
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                File.WriteAllText(saveFileDialog.FileName, notesTextBox.Text);
                fileNameLabel.Text = saveFileDialog.FileName;

                MessageBox.Show(
                    "Notes saved successfully.",
                    "Save Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to save the file.\n{ex.Message}",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
