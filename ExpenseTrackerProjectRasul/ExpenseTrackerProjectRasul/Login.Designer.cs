namespace ExpenseTrackerProjectRasul
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PassWordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextbox = new System.Windows.Forms.TextBox();
            this.SingUpButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExpenseTrackerLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EmailLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailLabel.Location = new System.Drawing.Point(228, 176);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 21);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.AutoSize = true;
            this.PassWordLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWordLabel.Location = new System.Drawing.Point(208, 228);
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(96, 21);
            this.PassWordLabel.TabIndex = 2;
            this.PassWordLabel.Text = "PassWord";
            this.PassWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(322, 176);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(192, 23);
            this.EmailTextBox.TabIndex = 3;
            // 
            // PassWordTextbox
            // 
            this.PassWordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassWordTextbox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTextbox.Location = new System.Drawing.Point(322, 227);
            this.PassWordTextbox.Multiline = true;
            this.PassWordTextbox.Name = "PassWordTextbox";
            this.PassWordTextbox.Size = new System.Drawing.Size(192, 21);
            this.PassWordTextbox.TabIndex = 4;
            // 
            // SingUpButton
            // 
            this.SingUpButton.BackColor = System.Drawing.Color.White;
            this.SingUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingUpButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingUpButton.Location = new System.Drawing.Point(294, 300);
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.Size = new System.Drawing.Size(75, 30);
            this.SingUpButton.TabIndex = 5;
            this.SingUpButton.Text = "Sing Up";
            this.SingUpButton.UseVisualStyleBackColor = false;
            this.SingUpButton.Click += new System.EventHandler(this.SingUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.Location = new System.Drawing.Point(439, 300);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 30);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExpenseTrackerLabel
            // 
            this.ExpenseTrackerLabel.AutoSize = true;
            this.ExpenseTrackerLabel.Font = new System.Drawing.Font("Modern No. 20", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseTrackerLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ExpenseTrackerLabel.Location = new System.Drawing.Point(205, 92);
            this.ExpenseTrackerLabel.Name = "ExpenseTrackerLabel";
            this.ExpenseTrackerLabel.Size = new System.Drawing.Size(334, 41);
            this.ExpenseTrackerLabel.TabIndex = 7;
            this.ExpenseTrackerLabel.Text = "Expense Tracker...";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(304, 269);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.ErrorLabel.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ExpenseTrackerLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SingUpButton);
            this.Controls.Add(this.PassWordTextbox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PassWordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PassWordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PassWordTextbox;
        private System.Windows.Forms.Button SingUpButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ExpenseTrackerLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}