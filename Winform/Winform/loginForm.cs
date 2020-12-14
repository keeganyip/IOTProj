using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Winform
{
    public partial class loginForm : Form
    {
        //retrieve connection information from App.Config
        private string strConnectionString =
            ConfigurationManager.ConnectionStrings["LoginDBConnection"].ConnectionString;

        public loginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Step 1: Open Connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            string strCommandText = "SELECT Email, Password FROM UserTable";
            //Add a WHERE clause to SQL Statement
            strCommandText += " WHERE Email=@Email AND Password=@Password";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@Email", tbUserName.Text);
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

            try
            {
                //Step 3: Open Connection and Retrieve Data by calling ExecuteReader
                myConnect.Open();

                //Step 4: Access Data
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    SensorForm fm = new SensorForm();
                    fm.Show();
                }
                else
                    MessageBox.Show("Login Fail");

                //Step 5: Close Connection
                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }

            finally
            {
                //Step 5: Close Connection
                myConnect.Close();
            }
        }
    }
}
