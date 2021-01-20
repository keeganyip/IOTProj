using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

using System.Configuration;
using System.Data.SqlClient;

namespace WebForm_DB_Createuser.Account
{
    public partial class ManageUser : System.Web.UI.Page
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
                
       

            }
            catch (Exception)
            {

                Response.Redirect("Login");

            }

            conn.Close();

        }

        protected void gvUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int result = 0;
            User deleteuser = new User();
            Debug.WriteLine(gvUsers.DataKeys[0]);
            
            string UserID = gvUsers.DataKeys[e.RowIndex].Value.ToString();
            
            result = deleteuser.UserDelete(UserID);

            if (result > 0)
            {
                Response.Write("<script>alert('User Removed successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('User Removal NOT successful');</script>");
            }

            Response.Redirect("ManageUser.aspx");

        }

       
    }
}