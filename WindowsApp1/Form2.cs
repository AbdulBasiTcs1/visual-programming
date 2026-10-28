using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 _parentForm;
        public Form2()
        {
            InitializeComponent();
        }

        // optional constructor to receive the parent Form1 instance
        public Form2(Form1 parent) : this()
        {
            _parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If this Form2 was created by Form1 and the parent was passed in, show that instance.
            if (_parentForm != null)
            {
                _parentForm.Show();
            }
            else if (this.Owner is Form1 ownerForm)
            {
                ownerForm.Show();
            }
            else
            {
                // fallback: try to find an open Form1 or create a new one
                Form1 existing = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f is Form1 fi)
                    {
                        existing = fi;
                        break;
                    }
                }
                if (existing != null)
                    existing.Show();
                else
                    new Form1().Show();
            }

            // Close this form to return to Form1
            this.Close();

        }
    }
}
