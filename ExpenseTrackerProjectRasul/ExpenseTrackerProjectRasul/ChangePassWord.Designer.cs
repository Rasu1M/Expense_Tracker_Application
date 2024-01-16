namespace ExpenseTrackerProjectRasul
{
    partial class ChangePassWord
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
            this.CurrentPassWordTextBox = new System.Windows.Forms.TextBox();
            this.NewPassWordTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPasswordLabel = new System.Windows.Forms.Label();
            this.NewPassWordLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.BackToMain = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentPassWordTextBox
            // 
            this.CurrentPassWordTextBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPassWordTextBox.Location = new System.Drawing.Point(400, 139);
            this.CurrentPassWordTextBox.Name = "CurrentPassWordTextBox";
            this.CurrentPassWordTextBox.Size = new System.Drawing.Size(136, 28);
            this.CurrentPassWordTextBox.TabIndex = 0;
            // 
            // NewPassWordTextBox
            // 
            this.NewPassWordTextBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassWordTextBox.Location = new System.Drawing.Point(400, 231);
            this.NewPassWordTextBox.Name = "NewPassWordTextBox";
            this.NewPassWordTextBox.Size = new System.Drawing.Size(136, 28);
            this.NewPassWordTextBox.TabIndex = 1;
            // 
            // CurrentPasswordLabel
            // 
            this.CurrentPasswordLabel.AutoSize = true;
            this.CurrentPasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentPasswordLabel.Location = new System.Drawing.Point(190, 139);
            this.CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            this.CurrentPasswordLabel.Size = new System.Drawing.Size(161, 21);
            this.CurrentPasswordLabel.TabIndex = 2;
            this.CurrentPasswordLabel.Text = "Current Password";
            // 
            // NewPassWordLabel
            // 
            this.NewPassWordLabel.AutoSize = true;
            this.NewPassWordLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassWordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewPassWordLabel.Location = new System.Drawing.Point(213, 231);
            this.NewPassWordLabel.Name = "NewPassWordLabel";
            this.NewPassWordLabel.Size = new System.Drawing.Size(138, 21);
            this.NewPassWordLabel.TabIndex = 3;
            this.NewPassWordLabel.Text = "New PassWord";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeButton.Location = new System.Drawing.Point(211, 333);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(108, 30);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToMain.Location = new System.Drawing.Point(415, 333);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(170, 30);
            this.BackToMain.TabIndex = 5;
            this.BackToMain.Text = "Back To Main";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(295, 291);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 21);
            this.ErrorLabel.TabIndex = 6;
            // 
            // ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NewPassWordLabel);
            this.Controls.Add(this.CurrentPasswordLabel);
            this.Controls.Add(this.NewPassWordTextBox);
            this.Controls.Add(this.CurrentPassWordTextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ChangePassWord";
            this.Text = "ChangePassWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentPassWordTextBox;
        private System.Windows.Forms.TextBox NewPassWordTextBox;
        private System.Windows.Forms.Label CurrentPasswordLabel;
        private System.Windows.Forms.Label NewPassWordLabel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.Label ErrorLabel;
    }
}