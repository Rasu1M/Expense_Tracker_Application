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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private bool CanSignUp = true;

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Login().Show();
        }

        private async void SingUpButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text)
                || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text))
            {
                ErrorLabel.Text = "All Fields must be filled!";
            }
                

            else
            {

                var sqlcon = new SqlConnection(Item_Types.connectionstring);

                try
                {
                    await sqlcon.OpenAsync();

                    var sqlcommand1 = new SqlCommand("select Email from users where Email = @Email", sqlcon);

                    sqlcommand1.Parameters.AddWithValue("@Email", EmailTextBox.Text);

                    var datareader = await sqlcommand1.ExecuteReaderAsync();

                    //first we control if there is a user with this email
                    if (datareader.Read())
                    {
                        ErrorLabel.Text = "This Email is already used";

                        CanSignUp = false;
                        datareader.Close();
                    }

                    //if not then we add new user
                    else
                    {
                        datareader.Close();

                        string password = EncryptPassWord.GeneratePassWord(PassWordTextBox.Text);

                        var sqlcommand2 = new SqlCommand("Insert Into Users Values (@ID, @Name, @SurName, @Email, @PassWord, @Birth_Date, @Created_Date)", sqlcon);

                        sqlcommand2.Parameters.AddWithValue("@ID", Guid.NewGuid());
                        sqlcommand2.Parameters.AddWithValue("@Name", NameTextBox.Text);
                        sqlcommand2.Parameters.AddWithValue("@SurName", SurNameTextBox.Text);
                        sqlcommand2.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        sqlcommand2.Parameters.AddWithValue("@PassWord", password);
                        sqlcommand2.Parameters.AddWithValue("@Birth_Date", BirthDatePicker.Value.Date);
                        sqlcommand2.Parameters.AddWithValue("@Created_Date", DateTime.UtcNow.Date);

                        await sqlcommand2.ExecuteNonQueryAsync();
                    }


                }

                catch (Exception ex)
                {
                    CanSignUp = false;

                    ErrorLabel.Text = "Internal Server Error Occured";
                }

                finally
                {
                    sqlcon.Close();

                    if (CanSignUp)
                    {
                        this.Hide();
                        new Login().Show();
                    }
                }
            }


        }
    }
}
