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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {


            this.Hide();

            new SingUp().Show();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(Item_Types.connectionstring);

            try
            {
                await SqlCon.OpenAsync();

                SqlCommand cmd = new SqlCommand("select * from Users where Email = @Email", SqlCon);
                cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);

                SqlDataReader dataReader = await cmd.ExecuteReaderAsync();

                if (dataReader.Read())
                {
                    string password = dataReader["PassWord"].ToString();

                    if (password == EncryptPassWord.GeneratePassWord(PassWordTextbox.Text))
                    {

                        //add needed information for using later
                        Properties.Settings.Default.Name = dataReader["Name"].ToString();
                        Properties.Settings.Default.SurName = dataReader["SurName"].ToString();
                        Properties.Settings.Default.Email = dataReader["Email"].ToString();
                        Properties.Settings.Default.User_ID = Guid.Parse(dataReader["ID"].ToString());


                        SqlCon.Close();
                        this.Hide();
                        new MainPage().Show();
                    }

                    else
                        ErrorLabel.Text = "Email or PassWord is Wrong";
                    
                }

                else
                {
                    ErrorLabel.Text = "Email or PassWord is Wrong";
                }
            }
            catch (Exception ex)
            {

                ErrorLabel.Text = "Internal Server Error Occured";
            }

            finally{

                SqlCon.Close();
            }

        }
    }
}
