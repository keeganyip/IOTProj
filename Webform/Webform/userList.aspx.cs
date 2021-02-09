using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Webform
{
    public partial class userList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet users = GetUser();
            Repeater1.DataSource = users;
            Repeater1.DataBind();
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["session"] != null)
            {
                if (Session["session"].ToString().Trim() == "logged")
                {
                    this.MasterPageFile = "~/Master.master";
                }
                else if (Session["session"].ToString().Trim() == "adminlogged")
                {
                    this.MasterPageFile = "~/AdminMaster.master";
                }
                else if (Session["session"].ToString().Trim() == "useradminlogged")
                {
                    this.MasterPageFile = "~/UserAdmin.master";
                }
            }
            else
            {
                Response.Redirect("sessionTimeout.aspx");
            }
        }
        private DataSet GetUser()
        {
            string userdb = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(userdb))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM USERTABLE", conn);
                DataSet users = new DataSet();
                cmd.Fill(users);
                return users;
            }
        }

        protected void deleteUser(object sender, EventArgs e)
        {
            string userdb = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;
            int userId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("lblUserID") as Label).Text);

            using (SqlConnection conn = new SqlConnection(userdb))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM USERTABLE WHERE UNIQUEUSERID = @ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", userId);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("userList.aspx");
            }
        }
    }
}