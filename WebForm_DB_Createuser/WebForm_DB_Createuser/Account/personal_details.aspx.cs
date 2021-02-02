using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using Salt_Password_Sample;

namespace WebForm_DB_Createuser.Account
{
    public partial class personal_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                string logged = Session["id"] as string;
                if(logged == null)
                {
                    Response.Redirect("Login");
                }
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
                try
                {
                    string count1 = null;
                    string Id = null;
                    conn1.Open();
                    string loginamount = "select count(*) as count, UserID from TimeLog where Event ='Login' group by UserID";
                    SqlCommand cmd = new SqlCommand(loginamount, conn1);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        count1 = read["count"].ToString();
                        Id = read["UserId"].ToString();
                        SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
                        conn2.Open();
                        string update = "Update UserTable set Greenhouse_Entry_Amount = " + count1 + " where UniqueUserID ='" + Id + "'";
                        Debug.WriteLine(update);
                        SqlCommand cmd2 = new SqlCommand(update, conn2);
                        cmd2.ExecuteNonQuery();

                    }

                    Debug.WriteLine(Id);
                    Debug.WriteLine(count1);

                }
                catch (Exception)
                {

                }
                conn1.Close();


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
                        lblName.Text = "Name: ";
                        lblEmail.Text = "Email: ";
                        lblContact.Text = "Contact ";
                        lblpw.Text = "Password";
                        lblnewpw.Text = "New Password";
                        

                        TbName.Text = reader["Name"].ToString().Trim();
                        TbEmail.Text = reader["Email"].ToString().Trim();
                        TbContact.Text = reader["Contact"].ToString().Trim();
                        lblrfid.Text = "RFID: " + reader["UniqueRFID"].ToString();
                        lblentry.Text = "Amount of times you entered Greenhouse:" + reader["Greenhouse_Entry_Amount"].ToString();


                    }
                }
                catch (Exception E)
                {

                    Response.Redirect("useraccount");
                    //Response.Write(E);


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
            Debug.WriteLine("email from db",email);
            Debug.WriteLine("email from txt",TbEmail.Text);

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
                    Response.Redirect("useraccount");
                }
                else
                {
                    string checkpw = cmdpw.ExecuteScalar().ToString().Trim();
                    string pass = TBPassword.Text;
                    bool flag = Hash.VerifyHash(pass, "SHA512", checkpw);
                    if (flag == true)
                    {
                        if (TbNewPw.Text.Length >= 8)
                        {
                            string sql = "UPDATE UserTable SET Email = @Email ,Name = @Name,Contact = @Contact , Password = @Password where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            string epass = Hash.ComputeHash(TbNewPw.Text, "SHA512", null);
                            cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
                            cmd.Parameters.AddWithValue("@Name", TbName.Text);
                            cmd.Parameters.AddWithValue("@Contact", TbContact.Text);
                            cmd.Parameters.AddWithValue("@Password", epass);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Response.Redirect("useraccount");
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
                    Response.Redirect("useraccount");
                }
                else
                {
                    string checkpw1 = cmdpw1.ExecuteScalar().ToString().Trim();
                    string pass1 = TBPassword.Text;
                    bool flag = Hash.VerifyHash(pass1, "SHA512", checkpw1);
                    if (flag == true)
                    {
                        string sql = "UPDATE UserTable SET Email = @Email ,Name = @Name,Contact = @Contact , Password = @Password where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        string epass = Hash.ComputeHash(TbNewPw.Text, "SHA512", null);
                        cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", TbName.Text);
                        cmd.Parameters.AddWithValue("@Contact", TbContact.Text);
                        cmd.Parameters.AddWithValue("@Password", epass);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Response.Redirect("useraccount");
                    }


                }
            }
        }

            
                
            
        

           
           
            
        

        protected void customValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string logged = Session["id"] as string;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            string correctpw = "select Password from UserTable where  UniqueUserID ='" + Convert.ToInt32(logged) + "'";
            SqlCommand cmds = new SqlCommand(correctpw, conn);
            string checkpw = cmds.ExecuteScalar().ToString().Trim();
            string pass = TBPassword.Text;
            bool flag = Hash.VerifyHash(pass, "SHA512", checkpw);
 

            string checkuser = "select count(*) from UserTable where Email='" + TbEmail.Text + "'";
            SqlCommand cmdemail = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmdemail.ExecuteScalar().ToString());
            string useremail = "select Email from UserTable where UniqueUserID ='" + Convert.ToInt32(logged) + "'";
            SqlCommand cmdcurrentemail = new SqlCommand(useremail, conn);
            string email = cmdcurrentemail.ExecuteScalar().ToString().Trim();
            

            if (temp == 1 && email != TbEmail.Text) 
             
            {
                 
            customValidator1.ErrorMessage = "Email exist";
            args.IsValid = false;
                               

            }
            else if (flag == false)
                
                {
                    customValidator1.ErrorMessage = " Wrong current Password";
                    args.IsValid = false;
                }

            else if ( TbNewPw.Text.Length < 8)
            {
                customValidator1.ErrorMessage = "Password must be minimum 8 characters";
                args.IsValid = false;
            }

            }
     
           
            }

        }
    
