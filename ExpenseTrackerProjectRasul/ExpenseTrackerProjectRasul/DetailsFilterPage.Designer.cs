namespace ExpenseTrackerProjectRasul
{
    partial class DetailsFilterPage
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
            this.ProductTypeLabel = new System.Windows.Forms.Label();
            this.SinceTimeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.UntilTimeLabel = new System.Windows.Forms.Label();
            this.OrderingLabel = new System.Windows.Forms.Label();
            this.SinceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UntilTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SeeDataButton = new System.Windows.Forms.Button();
            this.Orderbutton = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TypesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTypeLabel.Location = new System.Drawing.Point(104, 73);
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(126, 21);
            this.ProductTypeLabel.TabIndex = 0;
            this.ProductTypeLabel.Text = "Product Type";
            // 
            // SinceTimeLabel
            // 
            this.SinceTimeLabel.AutoSize = true;
            this.SinceTimeLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinceTimeLabel.Location = new System.Drawing.Point(443, 73);
            this.SinceTimeLabel.Name = "SinceTimeLabel";
            this.SinceTimeLabel.Size = new System.Drawing.Size(57, 21);
            this.SinceTimeLabel.TabIndex = 1;
            this.SinceTimeLabel.Text = "Since";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(104, 236);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(132, 21);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // UntilTimeLabel
            // 
            this.UntilTimeLabel.AutoSize = true;
            this.UntilTimeLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UntilTimeLabel.Location = new System.Drawing.Point(443, 236);
            this.UntilTimeLabel.Name = "UntilTimeLabel";
            this.UntilTimeLabel.Size = new System.Drawing.Size(56, 21);
            this.UntilTimeLabel.TabIndex = 3;
            this.UntilTimeLabel.Text = "Until";
            // 
            // OrderingLabel
            // 
            this.OrderingLabel.AutoSize = true;
            this.OrderingLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderingLabel.Location = new System.Drawing.Point(160, 365);
            this.OrderingLabel.Name = "OrderingLabel";
            this.OrderingLabel.Size = new System.Drawing.Size(126, 21);
            this.OrderingLabel.TabIndex = 4;
            this.OrderingLabel.Text = "Order by Cost";
            // 
            // SinceTimePicker
            // 
            this.SinceTimePicker.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SinceTimePicker.Location = new System.Drawing.Point(447, 114);
            this.SinceTimePicker.Name = "SinceTimePicker";
            this.SinceTimePicker.Size = new System.Drawing.Size(167, 30);
            this.SinceTimePicker.TabIndex = 5;
            this.SinceTimePicker.Value = new System.DateTime(2023, 11, 16, 18, 6, 48, 834);
            // 
            // UntilTimePicker
            // 
            this.UntilTimePicker.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UntilTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UntilTimePicker.Location = new System.Drawing.Point(447, 274);
            this.UntilTimePicker.Name = "UntilTimePicker";
            this.UntilTimePicker.Size = new System.Drawing.Size(167, 30);
            this.UntilTimePicker.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(108, 277);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(167, 28);
            this.NameBox.TabIndex = 8;
            // 
            // SeeDataButton
            // 
            this.SeeDataButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeDataButton.Location = new System.Drawing.Point(480, 340);
            this.SeeDataButton.Name = "SeeDataButton";
            this.SeeDataButton.Size = new System.Drawing.Size(150, 30);
            this.SeeDataButton.TabIndex = 10;
            this.SeeDataButton.Text = "See Data";
            this.SeeDataButton.UseVisualStyleBackColor = true;
            this.SeeDataButton.Click += new System.EventHandler(this.SeeDataButton_Click);
            // 
            // Orderbutton
            // 
            this.Orderbutton.AutoSize = true;
            this.Orderbutton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbutton.Location = new System.Drawing.Point(308, 371);
            this.Orderbutton.Name = "Orderbutton";
            this.Orderbutton.Size = new System.Drawing.Size(15, 14);
            this.Orderbutton.TabIndex = 12;
            this.Orderbutton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(480, 388);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 30);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back to Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TypesBox
            // 
            this.TypesBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypesBox.FormattingEnabled = true;
            this.TypesBox.Items.AddRange(new object[] {
            "All",
            "Electronic",
            "Taxes",
            "Education",
            "Insurance",
            "Entartainment",
            "Others"});
            this.TypesBox.Location = new System.Drawing.Point(108, 114);
            this.TypesBox.Name = "TypesBox";
            this.TypesBox.Size = new System.Drawing.Size(167, 29);
            this.TypesBox.TabIndex = 14;
            this.TypesBox.Text = " Types";
            // 
            // DetailsFilterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypesBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Orderbutton);
            this.Controls.Add(this.SeeDataButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UntilTimePicker);
            this.Controls.Add(this.SinceTimePicker);
            this.Controls.Add(this.OrderingLabel);
            this.Controls.Add(this.UntilTimeLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.SinceTimeLabel);
            this.Controls.Add(this.ProductTypeLabel);
            this.Name = "DetailsFilterPage";
            this.Text = "DetailsFilterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductTypeLabel;
        private System.Windows.Forms.Label SinceTimeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label UntilTimeLabel;
        private System.Windows.Forms.Label OrderingLabel;
        private System.Windows.Forms.DateTimePicker SinceTimePicker;
        private System.Windows.Forms.DateTimePicker UntilTimePicker;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button SeeDataButton;
        private System.Windows.Forms.CheckBox Orderbutton;
        private System.Windows.Forms.Button BackButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox TypesBox;
    }
}