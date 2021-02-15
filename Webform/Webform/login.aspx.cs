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
                Debug.WriteLine(checkpw);
                if (checkpw != null)
                {

                    string pass = Password.Text;
                    bool flag = Hash.VerifyHash(pass, "SHA512", checkpw);
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
                                Session["session"] = "adminlogged";
                                Response.Redirect("greenhouses.aspx");
                            }
                            else
                            {
                                Session["id"] = id_collected;
                                Session["session"] = "logged";
                                Response.Redirect("userGreenhouse.aspx");
                            }

                            //string getUserType = "select type from UserTable where Email='" + Email.Text + "'";
                            //SqlCommand cmdType = new SqlCommand(getUserType, conn);
                            //string userType = cmdType.ExecuteScalar().ToString().Trim();
                            //Debug.WriteLine(userType);
                            //conn.Close();

                            //if (userType == "User")
                            //{
                            //    conn.Open();
                            //    string id = "select UniqueUserID from UserTable where Email='" + Email.Text + "'";
                            //    SqlCommand cmdid = new SqlCommand(id, conn);
                            //    string id_collected = cmdid.ExecuteScalar().ToString().Trim();
                            //    conn.Close();

                            //    Response.Write("password check");
                            //    Response.Write(id_collected);
                            //    Session["id"] = id_collected;
                            //    Session["session"] = "logged";
                            //    Response.Redirect("userGreenhouse.aspx");
                            //}

                            //else if (userType == "Admin")
                            //{
                            //    conn.Open();
                            //    string id = "select UniqueUserID from UserTable where Email='" + Email.Text + "'";
                            //    SqlCommand cmdid = new SqlCommand(id, conn);
                            //    string id_collected = cmdid.ExecuteScalar().ToString().Trim();
                            //    conn.Close();

                            //    Response.Write("password check");
                            //    Response.Write(id_collected);
                            //    Session["id"] = id_collected;
                            //    Session["session"] = "adminlogged";
                            //    Response.Redirect("greenhouses.aspx");
                            //}
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