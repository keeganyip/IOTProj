using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;

namespace Webform
{
    public partial class userGreenhouse : BasePage
    {
        string constr = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["id"].ToString());
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string gidCmdStr = "SELECT GREENHOUSE_ENTRY_AMOUNT FROM USERTABLE WHERE UNIQUEUSERID = '" + userId + "'";
                SqlCommand gidCmd = new SqlCommand(gidCmdStr, conn);
                conn.Open();
                string gidentries = gidCmd.ExecuteScalar().ToString();
                conn.Close();
                lblGid.Text = gidentries;
            }
        }
    }
}