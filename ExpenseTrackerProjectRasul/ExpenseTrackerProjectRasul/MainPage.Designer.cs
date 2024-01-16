namespace ExpenseTrackerProjectRasul
{
    partial class MainPage
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
            this.YesterdaysExpenseLabel = new System.Windows.Forms.Label();
            this.PrevMonthExpenseLabel = new System.Windows.Forms.Label();
            this.TodaysLabel = new System.Windows.Forms.Label();
            this.CurrentMonthLabel = new System.Windows.Forms.Label();
            this.AddExpenseButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.YesterdaysExpenseCountLabel = new System.Windows.Forms.Label();
            this.PrevMonthlExpenseCountLabel = new System.Windows.Forms.Label();
            this.TodayExpenseCountLabel = new System.Windows.Forms.Label();
            this.CurrentMonthCountLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ChangePassWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YesterdaysExpenseLabel
            // 
            this.YesterdaysExpenseLabel.AutoSize = true;
            this.YesterdaysExpenseLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesterdaysExpenseLabel.Location = new System.Drawing.Point(38, 166);
            this.YesterdaysExpenseLabel.Name = "YesterdaysExpenseLabel";
            this.YesterdaysExpenseLabel.Size = new System.Drawing.Size(210, 24);
            this.YesterdaysExpenseLabel.TabIndex = 0;
            this.YesterdaysExpenseLabel.Text = "Yesterday\'s Expense :";
            // 
            // PrevMonthExpenseLabel
            // 
            this.PrevMonthExpenseLabel.AutoSize = true;
            this.PrevMonthExpenseLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevMonthExpenseLabel.Location = new System.Drawing.Point(38, 225);
            this.PrevMonthExpenseLabel.Name = "PrevMonthExpenseLabel";
            this.PrevMonthExpenseLabel.Size = new System.Drawing.Size(255, 24);
            this.PrevMonthExpenseLabel.TabIndex = 1;
            this.PrevMonthExpenseLabel.Text = "Previous Month Expense :";
            // 
            // TodaysLabel
            // 
            this.TodaysLabel.AutoSize = true;
            this.TodaysLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysLabel.Location = new System.Drawing.Point(455, 167);
            this.TodaysLabel.Name = "TodaysLabel";
            this.TodaysLabel.Size = new System.Drawing.Size(93, 24);
            this.TodaysLabel.TabIndex = 2;
            this.TodaysLabel.Text = "Today\'s :";
            // 
            // CurrentMonthLabel
            // 
            this.CurrentMonthLabel.AutoSize = true;
            this.CurrentMonthLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMonthLabel.Location = new System.Drawing.Point(455, 225);
            this.CurrentMonthLabel.Name = "CurrentMonthLabel";
            this.CurrentMonthLabel.Size = new System.Drawing.Size(161, 24);
            this.CurrentMonthLabel.TabIndex = 3;
            this.CurrentMonthLabel.Text = "Current Month :";
            // 
            // AddExpenseButton
            // 
            this.AddExpenseButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpenseButton.Location = new System.Drawing.Point(401, 383);
            this.AddExpenseButton.Name = "AddExpenseButton";
            this.AddExpenseButton.Size = new System.Drawing.Size(114, 30);
            this.AddExpenseButton.TabIndex = 4;
            this.AddExpenseButton.Text = "Add Expense";
            this.AddExpenseButton.UseVisualStyleBackColor = true;
            this.AddExpenseButton.Click += new System.EventHandler(this.AddExpenseButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(539, 383);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(110, 30);
            this.DetailsButton.TabIndex = 5;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(673, 27);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(100, 30);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // YesterdaysExpenseCountLabel
            // 
            this.YesterdaysExpenseCountLabel.AutoSize = true;
            this.YesterdaysExpenseCountLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesterdaysExpenseCountLabel.Location = new System.Drawing.Point(309, 169);
            this.YesterdaysExpenseCountLabel.Name = "YesterdaysExpenseCountLabel";
            this.YesterdaysExpenseCountLabel.Size = new System.Drawing.Size(61, 21);
            this.YesterdaysExpenseCountLabel.TabIndex = 7;
            this.YesterdaysExpenseCountLabel.Text = "--.-- $";
            // 
            // PrevMonthlExpenseCountLabel
            // 
            this.PrevMonthlExpenseCountLabel.AutoSize = true;
            this.PrevMonthlExpenseCountLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevMonthlExpenseCountLabel.Location = new System.Drawing.Point(309, 228);
            this.PrevMonthlExpenseCountLabel.Name = "PrevMonthlExpenseCountLabel";
            this.PrevMonthlExpenseCountLabel.Size = new System.Drawing.Size(61, 21);
            this.PrevMonthlExpenseCountLabel.TabIndex = 8;
            this.PrevMonthlExpenseCountLabel.Text = "--.-- $";
            // 
            // TodayExpenseCountLabel
            // 
            this.TodayExpenseCountLabel.AutoSize = true;
            this.TodayExpenseCountLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayExpenseCountLabel.Location = new System.Drawing.Point(649, 166);
            this.TodayExpenseCountLabel.Name = "TodayExpenseCountLabel";
            this.TodayExpenseCountLabel.Size = new System.Drawing.Size(61, 21);
            this.TodayExpenseCountLabel.TabIndex = 9;
            this.TodayExpenseCountLabel.Text = "--.-- $";
            // 
            // CurrentMonthCountLabel
            // 
            this.CurrentMonthCountLabel.AutoSize = true;
            this.CurrentMonthCountLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMonthCountLabel.Location = new System.Drawing.Point(649, 227);
            this.CurrentMonthCountLabel.Name = "CurrentMonthCountLabel";
            this.CurrentMonthCountLabel.Size = new System.Drawing.Size(61, 21);
            this.CurrentMonthCountLabel.TabIndex = 10;
            this.CurrentMonthCountLabel.Text = "--.-- $";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(673, 383);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(100, 30);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(52, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(109, 21);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Welcome ...";
            // 
            // ChangePassWordButton
            // 
            this.ChangePassWordButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassWordButton.Location = new System.Drawing.Point(29, 383);
            this.ChangePassWordButton.Name = "ChangePassWordButton";
            this.ChangePassWordButton.Size = new System.Drawing.Size(174, 30);
            this.ChangePassWordButton.TabIndex = 14;
            this.ChangePassWordButton.Text = "Change PassWord";
            this.ChangePassWordButton.UseVisualStyleBackColor = true;
            this.ChangePassWordButton.Click += new System.EventHandler(this.ChangePassWordButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangePassWordButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CurrentMonthCountLabel);
            this.Controls.Add(this.TodayExpenseCountLabel);
            this.Controls.Add(this.PrevMonthlExpenseCountLabel);
            this.Controls.Add(this.YesterdaysExpenseCountLabel);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.AddExpenseButton);
            this.Controls.Add(this.CurrentMonthLabel);
            this.Controls.Add(this.TodaysLabel);
            this.Controls.Add(this.PrevMonthExpenseLabel);
            this.Controls.Add(this.YesterdaysExpenseLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPageLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YesterdaysExpenseLabel;
        private System.Windows.Forms.Label PrevMonthExpenseLabel;
        private System.Windows.Forms.Label TodaysLabel;
        private System.Windows.Forms.Label CurrentMonthLabel;
        private System.Windows.Forms.Button AddExpenseButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label YesterdaysExpenseCountLabel;
        private System.Windows.Forms.Label PrevMonthlExpenseCountLabel;
        private System.Windows.Forms.Label TodayExpenseCountLabel;
        private System.Windows.Forms.Label CurrentMonthCountLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ChangePassWordButton;
    }
}