using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblName;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Button btnReset;
        private Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.lblPassword = new Label();
            this.txtName = new TextBox();
            this.txtPassword = new TextBox();
            this.btnSubmit = new Button();
            this.btnReset = new Button();
            this.btnExit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(45, 20);
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(120, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(200, 27);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(30, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(70, 20);
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(120, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(200, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new Point(30, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new Size(90, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new Point(140, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(90, 30);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new Point(250, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(90, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 180);
            Controls.Add(this.lblName);
            Controls.Add(this.txtName);
            Controls.Add(this.lblPassword);
            Controls.Add(this.txtPassword);
            Controls.Add(this.btnSubmit);
            Controls.Add(this.btnReset);
            Controls.Add(this.btnExit);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
