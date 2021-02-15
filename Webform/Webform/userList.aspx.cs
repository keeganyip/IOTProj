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

namespace Webform
{
    public partial class userList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);

            string count1 = null;
            string Id = null;
            conn1.Open();
            string loginamount = "select count(*) as count, UserID from TimeLog where Event ='Login' group by UserID";
            SqlCommand cmd1 = new SqlCommand(loginamount, conn1);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                count1 = read["count"].ToString();
                Id = read["UserId"].ToString();
                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
                conn2.Open();
                string update = "Update UserTable set Greenhouse_Entry_Amount = " + count1 + " where UniqueUserID ='" + Id + "'";
                Debug.WriteLine(update);
                SqlCommand cmd2 = new SqlCommand(update, conn2);
                cmd2.ExecuteNonQuery();

            }

            DataSet users = GetUser();
            Repeater1.DataSource = users;
            Repeater1.DataBind();
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