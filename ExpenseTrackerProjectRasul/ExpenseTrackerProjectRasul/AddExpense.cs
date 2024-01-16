using ExpenseTrackerProjectRasul.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerProjectRasul
{
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainPage().Show();
        }

        private async void CreateExpenseButton_Click(object sender, EventArgs e)
        {
            if (TypeBox.SelectedIndex == -1 || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(CountTextBox.Text) || string.IsNullOrEmpty(PrizeTextBox.Text))
                return;

            var sqlcon = new SqlConnection(Item_Types.connectionstring);

            try
            {
                await sqlcon.OpenAsync();

                var sqlcommand = new SqlCommand("Insert into Expenses Values(@ID, @User_ID, @Type, @Name, @Count, @Prize, @Created_Date)", sqlcon);

                sqlcommand.Parameters.AddWithValue("@ID", Guid.NewGuid());
                sqlcommand.Parameters.AddWithValue("@User_ID", Properties.Settings.Default.User_ID);
                sqlcommand.Parameters.AddWithValue("@Type", TypeBox.SelectedItem);
                sqlcommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@Count", Convert.ToInt16(CountTextBox.Text));
                sqlcommand.Parameters.AddWithValue("@Prize", float.Parse(PrizeTextBox.Text));
                sqlcommand.Parameters.AddWithValue("@Created_Date", DateTime.UtcNow.Date);

                await sqlcommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                //log
            }
            finally 
            {
                sqlcon.Close();
            }

        }
    }
}
