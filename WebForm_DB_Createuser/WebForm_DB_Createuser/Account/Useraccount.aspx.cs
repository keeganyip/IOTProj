using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace WebForm_DB_Createuser.Account
{
    public partial class user : System.Web.UI.Page
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
                lblname.Text = name;
                /*
                Label lblUserVal = (Label)Page.Master.FindControl("accoutname");
                lblUserVal.Text = name;
                */

            }
            catch (Exception)
            {

                Response.Redirect("Login");

            }

            conn.Close();
     

            

        }
    }

}