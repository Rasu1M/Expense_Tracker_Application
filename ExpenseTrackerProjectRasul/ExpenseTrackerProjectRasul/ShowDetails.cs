using ExpenseTrackerProjectRasul.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerProjectRasul
{
    public partial class ShowDetails : Form
    {
        public ShowDetails(List<ExpensesResponse> expenses)
        {
            InitializeComponent();

            Expenses = expenses;
        }

        private List<ExpensesResponse> Expenses;

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainPage().Show();
        }

        private void ShowDetailsLoad(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Expenses;
        }
    }
}
