namespace ExpenseTrackerProjectRasul
{
    partial class AddExpense
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
            this.SelectTypeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductCountLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.CreateExpenseButton = new System.Windows.Forms.Button();
            this.PrizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectTypeLabel
            // 
            this.SelectTypeLabel.AutoSize = true;
            this.SelectTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTypeLabel.Location = new System.Drawing.Point(246, 110);
            this.SelectTypeLabel.Name = "SelectTypeLabel";
            this.SelectTypeLabel.Size = new System.Drawing.Size(110, 21);
            this.SelectTypeLabel.TabIndex = 0;
            this.SelectTypeLabel.Text = "Select Type";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(234, 157);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(132, 21);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductCountLabel
            // 
            this.ProductCountLabel.AutoSize = true;
            this.ProductCountLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCountLabel.Location = new System.Drawing.Point(232, 207);
            this.ProductCountLabel.Name = "ProductCountLabel";
            this.ProductCountLabel.Size = new System.Drawing.Size(134, 21);
            this.ProductCountLabel.TabIndex = 2;
            this.ProductCountLabel.Text = "Product Count";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(402, 159);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 21);
            this.NameTextBox.TabIndex = 3;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTextBox.Location = new System.Drawing.Point(402, 210);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(121, 21);
            this.CountTextBox.TabIndex = 4;
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Electronic",
            "Taxes",
            "Education",
            "Insurance",
            "Entartainment",
            "Others"});
            this.TypeBox.Location = new System.Drawing.Point(402, 108);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 23);
            this.TypeBox.TabIndex = 6;
            this.TypeBox.Text = " Types";
            // 
            // CreateExpenseButton
            // 
            this.CreateExpenseButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateExpenseButton.Location = new System.Drawing.Point(301, 339);
            this.CreateExpenseButton.Name = "CreateExpenseButton";
            this.CreateExpenseButton.Size = new System.Drawing.Size(100, 30);
            this.CreateExpenseButton.TabIndex = 7;
            this.CreateExpenseButton.Text = "Create";
            this.CreateExpenseButton.UseVisualStyleBackColor = true;
            this.CreateExpenseButton.Click += new System.EventHandler(this.CreateExpenseButton_Click);
            // 
            // PrizeTextBox
            // 
            this.PrizeTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeTextBox.Location = new System.Drawing.Point(402, 254);
            this.PrizeTextBox.Name = "PrizeTextBox";
            this.PrizeTextBox.Size = new System.Drawing.Size(121, 21);
            this.PrizeTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prize";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(453, 339);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 30);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back to Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PrizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateExpenseButton);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ProductCountLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.SelectTypeLabel);
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectTypeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductCountLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Button CreateExpenseButton;
        private System.Windows.Forms.TextBox PrizeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}