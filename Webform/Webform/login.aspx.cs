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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["id"] = null;
        }

        protected void logInClick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from UserTable where Email='" + Email.Text + "'";
            SqlCommand cmd = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (temp == 1)
            {

                string correctpw = "select Password from UserTable where Email='" + Email.Text + "'";

                SqlCommand cmds = new SqlCommand(correctpw, conn);

                string checkpw = cmds.ExecuteScalar().ToString().Trim();
                if (checkpw != null)
                {

                    string pass = Password.Text;
                    Response.Write(checkpw + Password.Text);
                    Response.Write(pass == checkpw);
                    Debug.WriteLine(pass, "pass");
                    Debug.WriteLine(checkpw, "checkpw");

                    try
                    {


                        if (pass == checkpw)
                        {

                            string id = "select UniqueUserID from UserTable where Email='" + Email.Text + "'";
                            SqlCommand cmdid = new SqlCommand(id, conn);
                            string id_collected = cmdid.ExecuteScalar().ToString().Trim();
                            conn.Close();

                            Response.Write("password check");
                            Response.Write(id_collected);
                            Session["id"] = id_collected;
                            Session["session"] = "logged";



                            Response.Write(Session["id"]);

                            Response.Redirect("index.aspx");

                        }
                    }
                    catch (Exception s)
                    {
                        Debug.WriteLine(s);
                    }

                }
            }
        }
    }
}