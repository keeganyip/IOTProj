
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForm_DB_Createuser
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void submit(object sender, EventArgs e)
        {
            string username = string.Empty;


            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);

            string changepw = "UPDATE UserTable SET Password = @Password WHERE Email =@Email";
            conn.Open();
            SqlCommand changingpw = new SqlCommand(changepw, conn);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";  // create random 8 character 
            var stringchars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringchars.Length; i++)
            {
                stringchars[i] = chars[random.Next(chars.Length)];
            }
            var randompw = new string(stringchars);
            changingpw.Parameters.AddWithValue("@Password", randompw);
            changingpw.Parameters.AddWithValue("@Email", Email.Text.Trim());

            changingpw.ExecuteNonQuery();

            Debug.WriteLine("pw generated : ", randompw);
            conn.Close();


            SqlCommand cmd = new SqlCommand("SELECT Name FROM UserTable WHERE Email =@Email");
            cmd.Parameters.AddWithValue("@Email", Email.Text.Trim());
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                username = reader["Name"].ToString();
                Debug.WriteLine(username);
            }

            Debug.WriteLine(Email.Text.Trim());
            if (username != "")
            {


                try
                {
                    MailMessage mm = new MailMessage("jovanleunglw@gmail.com", Email.Text.Trim());
                    mm.Subject = "Password Recovery";
                    mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", username, randompw);
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;

                    NetworkCredential NetworkCred = new NetworkCredential();
                    NetworkCred.UserName = "jovanleunglw@gmail.com";
                    NetworkCred.Password = "T0219219a";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "email sent";

                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Email does not have an account yet";
                Debug.WriteLine("email doesnt have an account that exist");
            }

            /*
            try
            {


                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("jovanleunglw@gmail.com");
                msg.To.Add(Email.Text);
                msg.Subject = "Share It: Password Recovery";
                msg.Body = "Hi," + username + " <br />As requested, here is your password <br />";
                msg.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("jovanleunglw@gmail.com", "t0219219a");
                smtp.EnableSsl = true;
              
                smtp.Send(msg);
                Debug.WriteLine("Your Password Details Sent to your mail.");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }*/
        }
    }
}
