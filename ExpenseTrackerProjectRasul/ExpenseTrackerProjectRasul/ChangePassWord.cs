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
    public partial class ChangePassWord : Form
    {
        public ChangePassWord()
        {
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            var sqlcon = new SqlConnection(Item_Types.connectionstring);

            try
            {
                await sqlcon.OpenAsync();

                var sqlcommand = new SqlCommand("select PassWord from users where ID = @ID", sqlcon);

                sqlcommand.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);

                var datareader = await sqlcommand.ExecuteReaderAsync();




                //Checking for server errors
                if (!datareader.Read())
                {
                    ErrorLabel.Text = "User Not Found";
                    datareader.Close();

                }
                //Check if PassWord is Correct
                else if (datareader["PassWord"].ToString() != EncryptPassWord.GeneratePassWord(CurrentPassWordTextBox.Text))
                {
                    ErrorLabel.Text = "PassWord is wrong";
                    datareader.Close();
                }
                //if password is corrrect then we will update password here
                else
                {
                    datareader.Close();

                    var sqlcommand2 = new SqlCommand("Update users set PassWord = @PassWord where ID = @ID", sqlcon);

                    sqlcommand2.Parameters.AddWithValue("@ID", Properties.Settings.Default.User_ID);
                    sqlcommand2.Parameters.AddWithValue("@PassWord", EncryptPassWord.GeneratePassWord(NewPassWordTextBox.Text));

                    await sqlcommand2.ExecuteNonQueryAsync();

                    ErrorLabel.Text = "PassWord is Changed";
                }

            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "Internal Server Error Occured";

                //log
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
