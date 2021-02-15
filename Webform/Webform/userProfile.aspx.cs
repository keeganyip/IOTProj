using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace Webform
{
    public partial class userProfile : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string logged = Session["id"] as string;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
                try
                {
                    conn.Open();
                    string getdetails = "select * from UserTable where UniqueUserID ='" + logged + "'";


                    SqlCommand cmd = new SqlCommand(getdetails, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Debug.WriteLine(reader);

                    while (reader.Read())
                    {
                        TbName.Text = reader["Name"].ToString().Trim();
                        TbEmail.Text = reader["Email"].ToString().Trim();
                        TbContact.Text = reader["Contact"].ToString().Trim();
                        TBPassword.Text = reader["Password"].ToString().Trim();
                    }
                }
                catch (Exception E)
                {

                    // Response.Redirect("useraccount");
                    Response.Write(E);


                }

                conn.Close();
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string logged = Session["id"] as string;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from UserTable where Email='" + TbEmail.Text + "'";
            SqlCommand cmdemail = new SqlCommand(checkuser, conn);
            string useremail = "select Email from UserTable where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
            SqlCommand cmdcurrentemail = new SqlCommand(useremail, conn);
            string email = cmdcurrentemail.ExecuteScalar().ToString().Trim();
            Debug.WriteLine("email from db", email);
            Debug.WriteLine("email from txt", TbEmail.Text);

            int temp = Convert.ToInt32(cmdemail.ExecuteScalar().ToString());
            if (email == TbEmail.Text)  //email is current user's email
            {
                string correctpw = "select Password from UserTable where  UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                SqlCommand cmdpw = new SqlCommand(correctpw, conn);
                if (TBPassword.Text.Length == 0)
                {
                    string sql = "UPDATE UserTable SET Email = @Email ,Name = @Name,Contact = @Contact where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
                    cmd.Parameters.AddWithValue("@Name", TbName.Text);
                    cmd.Parameters.AddWithValue("@Contact", TbContact.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("userList.aspx");
                }
                else
                {
                    string checkpw = cmdpw.ExecuteScalar().ToString().Trim();
                    string pass = TBPassword.Text;
                    if (pass == checkpw)
                    {
                        if (TbNewPw.Text.Length >= 8)
                        {
                            string sql = "UPDATE UserTable SET Email = @Email ,Name = @Name,Contact = @Contact , Password = @Password where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
                            cmd.Parameters.AddWithValue("@Name", TbName.Text);
                            cmd.Parameters.AddWithValue("@Contact", TbContact.Text);
                            cmd.Parameters.AddWithValue("@Password", TbNewPw.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Response.Redirect("userList.aspx");
                        }
                    }
                }
            }
            else if (temp == 0) //email is nt in database 
            {
                string correctpw1 = "select Password from UserTable where  UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                SqlCommand cmdpw1 = new SqlCommand(correctpw1, conn);
                if (TBPassword.Text.Length == 0)
                {
                    string sql = "UPDATE UserTable SET Email = @Email ,Name = @Name,Contact = @Contact where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
                    cmd.Parameters.AddWithValue("@Name", TbName.Text);
                    cmd.Parameters.AddWithValue("@Contact", TbContact.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("userList.aspx");
                }
                else
                {
                    string checkpw1 = cmdpw1.ExecuteScalar().ToString().Trim();
                    string pass1 = TBPassword.Text;
                    if (pass1 == checkpw1)
                    {
                        string sql = "UPDATE UserTable SET Email = @Email ,Name = @Name,Contact = @Contact , Password = @Password where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", TbName.Text);
                        cmd.Parameters.AddWithValue("@Contact", TbContact.Text);
                        cmd.Parameters.AddWithValue("@Password", TbNewPw.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Response.Redirect("userList.aspx");
                    }


                }
            }
        }

       
    }
}