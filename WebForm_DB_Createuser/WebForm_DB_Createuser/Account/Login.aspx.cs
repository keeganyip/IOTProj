using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebForm_DB_Createuser.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using Salt_Password_Sample;

namespace WebForm_DB_Createuser.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            forgetpassword.NavigateUrl = "ForgotPassword";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            //var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
           // if (!String.IsNullOrEmpty(returnUrl))
           // {
            //    RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
               
           // }
            Session.Clear();
        }

        protected void LogIn(object sender, EventArgs e)
        {
            /*
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(Email.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                        break;
                    case SignInStatus.LockedOut:
                        Response.Redirect("/Account/Lockout");
                        break;
                    case SignInStatus.RequiresVerification:
                        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}", 
                                                        Request.QueryString["ReturnUrl"],
                                                        RememberMe.Checked),
                                          true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        FailureText.Text = "Invalid login attempt";
                        ErrorMessage.Visible = true;
                        break;
                  
                }

            }*/
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from UserTable where Email='" + Email.Text + "'";
            SqlCommand cmd = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

           
            if (temp == 1)
            {
                Debug.WriteLine("user");
                string correctpw = "select Password from UserTable where Email='" + Email.Text + "'";
              
                SqlCommand cmds = new SqlCommand(correctpw, conn);
            
                string checkpw = cmds.ExecuteScalar().ToString().Trim();
                if (checkpw != null)
                {

                    string pass = Password.Text;
                    bool flag = Hash.VerifyHash(pass, "SHA512", checkpw);
                    Response.Write(checkpw + Password.Text);
                    Response.Write(pass == checkpw);
                    Debug.WriteLine(pass, "pass");
                    Debug.WriteLine(checkpw, "checkpw");

                    try
                    {


                        if (flag == true)
                        {

                            string id = "select UniqueUserID from UserTable where Email='" + Email.Text + "'";
                            SqlCommand cmdid = new SqlCommand(id, conn);
                            string id_collected = cmdid.ExecuteScalar().ToString().Trim();
                            string type = "select Type from UserTable where Email ='" + Email.Text + "'";
                            SqlCommand cmdtype = new SqlCommand(type, conn);
                            string type_collected = cmdtype.ExecuteScalar().ToString().Trim();
                            
                            conn.Close();

                           
                        
                            if (type_collected == "Admin")
                            {
                                Session["id"] = id_collected;
                                Response.Redirect("Adminaccount");
                            }

                            else
                            {
                                Session["id"] = id_collected;
                                Response.Redirect("Useraccount");
                            }
                        }
                    }
                    catch (Exception s)
                    {
                        Debug.WriteLine(s);
                    }

                }

        

                
            }
            

                }
            
        

        protected void Email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void customValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            string correctpw = "select Password from UserTable where Email='" + Email.Text + "'";
            SqlCommand cmds = new SqlCommand(correctpw, conn);

            



            try
                {
                    string checkpw = cmds.ExecuteScalar().ToString().Trim();


                    string pass = Password.Text;
                    bool flag = Hash.VerifyHash(pass, "SHA512", checkpw);
                    if (flag == false)
                    {
                        customValidator1.ErrorMessage = " Wrong login Credentials";
                        args.IsValid = false;
                    }



                }
                catch (Exception s)
                {
                    Debug.WriteLine(s);
                    customValidator1.ErrorMessage = "Email does not exist ";
                    args.IsValid = false;
                }

           
        }
            
        }
           
    
    
}