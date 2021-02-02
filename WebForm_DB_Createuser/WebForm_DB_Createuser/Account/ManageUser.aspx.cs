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

            if (logged == null)
            {
                Response.Redirect("Login");
            }


            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            try
            {
                 string count1 = null;
                string Id = null;
                conn1.Open();
                string loginamount = "select count(*) as count, UserID from TimeLog where Event ='Login' group by UserID";
                SqlCommand cmd = new SqlCommand(loginamount, conn1);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    count1 = read["count"].ToString();
                    Id = read["UserId"].ToString();
                    SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
                    conn2.Open();
                    string update = "Update UserTable set Greenhouse_Entry_Amount = " + count1+" where UniqueUserID ='"+Id+"'";
                    Debug.WriteLine(update);
                    SqlCommand cmd2 = new SqlCommand(update, conn2);
                    cmd2.ExecuteNonQuery();
                  
                }

                Debug.WriteLine(Id);
                Debug.WriteLine(count1);

            }
            catch (Exception)
            {

            }
            conn1.Close();

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