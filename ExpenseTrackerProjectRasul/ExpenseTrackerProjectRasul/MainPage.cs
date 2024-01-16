using ExpenseTrackerProjectRasul.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerProjectRasul
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            sqlcon = new SqlConnection(Item_Types.connectionstring);
        }

        private SqlConnection sqlcon;

        private void MainPageLoad(object sender, EventArgs e)
        {
            GetData();

            NameLabel.Text = Properties.Settings.Default.Name + ' ' + Properties.Settings.Default.SurName;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();

        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddExpense().Show();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DetailsFilterPage().Show();
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private async void GetData()
        {
            await sqlcon.OpenAsync();

            try
            {
                await GetMonthsData();

                await GetDaysData();
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

        private async Task GetMonthsData()
        {
            //Current's month expense
            var sqlcommand = new SqlCommand("select SUM(Prize) as total from Expenses \r\n" +
            "where User_ID = @ID " +
            "and datepart(year, Created_Date) = @year and datepart(month, Created_Date) = @month \r\ngroup by datepart(month, Created_Date)", sqlcon);

            sqlcommand.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);
            sqlcommand.Parameters.AddWithValue("@year", DateTime.Now.Year);
            sqlcommand.Parameters.AddWithValue("@month", DateTime.Now.Month);

            var datareader = await sqlcommand.ExecuteReaderAsync();

            if(datareader.Read())
                CurrentMonthCountLabel.Text = datareader["total"].ToString() + " $";

            datareader.Close();


            // prevmonth's expense
            var sqlcommand2 = new SqlCommand("select SUM(Prize) as total from Expenses where User_ID = @ID " +
                "and datepart(year, Created_Date) = @year " +
                "and datepart(month, Created_Date) = @month group by datepart(month, Created_Date);", sqlcon);

            sqlcommand2.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);
            sqlcommand2.Parameters.AddWithValue("@year", DateTime.Now.AddMonths(-1).Year);
            sqlcommand2.Parameters.AddWithValue("@month", DateTime.Now.AddMonths(-1).Month);


            datareader = await sqlcommand2.ExecuteReaderAsync();

            if (datareader.Read())
                PrevMonthlExpenseCountLabel.Text = datareader["total"].ToString() + " $";

            datareader.Close();

        }

        private async Task GetDaysData()
        {
            //today's expense
            var sqlcommand = new SqlCommand("select SUM(Prize) as total from Expenses \r\n" +
            "where User_ID = @ID " +
            "and datediff(day, getdate(), Created_Date) = 0 \r\ngroup by datepart(day, Created_Date)", sqlcon);

            sqlcommand.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);

            var datareader = await sqlcommand.ExecuteReaderAsync();

            if (datareader.Read())
                TodayExpenseCountLabel.Text = datareader["total"].ToString() + " $";

            datareader.Close();


            //yesterday's expense
            var sqlcommand2 = new SqlCommand("select SUM(Prize) as total from Expenses \r\n" +
            "where User_ID = @ID " +
            "and datediff(day, getdate(), Created_Date) = -1 \r\ngroup by datepart(day, Created_Date)", sqlcon);

            sqlcommand2.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);

            datareader = await sqlcommand2.ExecuteReaderAsync();

            if (datareader.Read())
                YesterdaysExpenseCountLabel.Text = datareader["total"].ToString() + " $";

            datareader.Close();

        }

        private void ChangePassWordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassWord().Show();
        }
    }
}
