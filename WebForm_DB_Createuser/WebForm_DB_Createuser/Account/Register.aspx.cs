using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebForm_DB_Createuser.Models;
using System.Data.SqlClient;
using System.Configuration;


namespace WebForm_DB_Createuser.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {/*
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
            */
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from UserTable where Email='" + Email.Text + "'";
            SqlCommand cmds = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmds.ExecuteScalar().ToString());

            if (temp == 1)
            {

                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email already exist');", true);
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Alert", ";alert('email already exit ');", true);
            }
            else
            {

                if (Password.Text.Length >= 8)
                {



                    string insertQuery = "insert into UserTable(Email,Password,Name,Contact,Type,UniqueRFID)values(@Email,@password,@Name,@Contact,@Type,@UniqueRFID)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@password", Password.Text);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                    cmd.Parameters.AddWithValue("@Type", "User");
                    cmd.Parameters.AddWithValue("@UniqueRFID", "-");
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "notification", ";alert('account created');", true);
                    Response.Redirect("Login.aspx");

                }








            }

            conn.Close();
        }

        protected void SqlDataSource1_Selecting(object sender, System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Name_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Contact_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void customValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (Password.Text.Length < 8)
            {
                customValidator1.ErrorMessage = "Password must be minimum 8 characters";
                args.IsValid = false;
            }
        }
    }
}