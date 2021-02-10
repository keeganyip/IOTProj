using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;

namespace Webform
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                string sessionCheck = Session["id"].ToString();
                Debug.WriteLine(sessionCheck + "abc");

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select name from UserTable where UniqueUserID='" + sessionCheck + "'";
                SqlCommand cmds = new SqlCommand(checkuser, conn);
                string userName = cmds.ExecuteScalar().ToString();
                Name.Text = userName;
            }
            else
            {
                Response.Redirect("sessionTimeout.aspx");
            }
        }

        protected void signOutClick(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}