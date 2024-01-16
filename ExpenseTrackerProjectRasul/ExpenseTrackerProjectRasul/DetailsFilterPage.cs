using ExpenseTrackerProjectRasul.Domain;
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
    public partial class DetailsFilterPage : Form
    {
        public DetailsFilterPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainPage().Show();
        }

        private async void SeeDataButton_Click(object sender, EventArgs e)
        {
            var sqlcon = new SqlConnection(Item_Types.connectionstring);

            List<ExpensesResponse> expenses = new List<ExpensesResponse>();

            try
            {
                await sqlcon.OpenAsync();

                string typecondition = "";
                string namecondition = "";
                string isorderedstring = "";


                if (TypesBox.SelectedIndex != -1 && TypesBox.SelectedItem != "All")
                    typecondition = " and Type = '" + TypesBox.SelectedItem + "'";

                if(!string.IsNullOrEmpty(NameBox.Text))
                    namecondition = "and Name = '" + NameBox.Text + "' ";

                if (Orderbutton.Checked)
                    isorderedstring = " order by Prize";

                var sqlcommand = new SqlCommand("select * from expenses where User_ID = @ID" +
                    " and datediff(day, @BeginDate, Created_Date) >= 0" +
                    " and datediff(day, @EndDate, Created_Date) <= 0" +
                    typecondition + namecondition + isorderedstring, sqlcon);


                sqlcommand.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);
                sqlcommand.Parameters.AddWithValue("@BeginDate", SinceTimePicker.Value.Date);
                sqlcommand.Parameters.AddWithValue("@EndDate", UntilTimePicker.Value.Date);

               var datareader = await sqlcommand.ExecuteReaderAsync();

                while (datareader.Read())
                {
                    var expense = new ExpensesResponse();

                    expense.Type = datareader["Type"].ToString();
                    expense.Name = datareader["Name"].ToString();
                    expense.Count = Convert.ToInt16(datareader["Count"].ToString());
                    expense.Prize = float.Parse(datareader["Prize"].ToString());
                    expense.DateofAdding = DateTime.Parse(datareader["Created_Date"].ToString());

                    expenses.Add(expense);
                }

                this.Hide();

                new ShowDetails(expenses).Show();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally 
            {
                sqlcon.Close();
            }
        }
    }
}
