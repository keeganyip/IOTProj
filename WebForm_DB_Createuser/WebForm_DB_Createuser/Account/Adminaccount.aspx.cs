using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace WebForm_DB_Createuser.Account
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string logged = Session["id"] as string;
            
            

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString); 
            try
            {
                conn.Open();
                string getname = "select Name from UserTable where UniqueUserID ='" + logged + "'";
                SqlCommand cmd = new SqlCommand(getname, conn);
                string name = cmd.ExecuteScalar().ToString().Trim();
                lbladminname.Text = name;
                /*
                Label lblUserVal = (Label)Page.Master.FindControl("accoutname");
                lblUserVal.Text = name;
                */

            }
            catch (Exception s)
            {
                Debug.WriteLine(s);
                //Response.Redirect("Login");

            }

            conn.Close();
     

            

        }
    }

}