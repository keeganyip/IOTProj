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
    public partial class updateRFID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindRepeater();
            }
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

        private void BindRepeater()
        {
            DataSet users = GetUser();
            Repeater1.DataSource = users;
            Repeater1.DataBind();
        }

        protected void onEdit(object sender, EventArgs e)
        {
            RepeaterItem edit = (sender as LinkButton).Parent as RepeaterItem;
            this.ToggleElements(edit, true);
        }

        protected void ToggleElements(RepeaterItem edit, bool isEdit)
        {
            //Toggle Buttons
            edit.FindControl("lnkEdit").Visible = !isEdit;
            edit.FindControl("lnkSave").Visible = isEdit;
            edit.FindControl("lnkCancel").Visible = isEdit;

            //Toggle Label
            edit.FindControl("lblUserName").Visible = !isEdit;
            edit.FindControl("lblUserID").Visible = !isEdit;
            edit.FindControl("lblEmail").Visible = !isEdit;
            edit.FindControl("lblRFID").Visible = !isEdit;

            //Togle TextBox
            edit.FindControl("txtUserName").Visible = isEdit;
            edit.FindControl("txtRFID").Visible = isEdit;
        }

        protected void saveRFID(object sender, EventArgs e)
        {
            string userdb = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;
            int userId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("lblUserID") as Label).Text);

            string rfid = ((sender as LinkButton).NamingContainer.FindControl("txtRFID") as TextBox).Text;
            if (string.IsNullOrEmpty(rfid) || string.IsNullOrWhiteSpace(rfid))
            {
                rfid = "-";
            }

            string username = ((sender as LinkButton).NamingContainer.FindControl("txtUserName") as TextBox).Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                username = ((sender as LinkButton).NamingContainer.FindControl("lblUserName") as Label).Text;
            }

            using (SqlConnection conn = new SqlConnection(userdb))
            {
                SqlCommand cmd = new SqlCommand("UPDATE USERTABLE SET UNIQUERFID = @RFID, NAME = @NAME WHERE UNIQUEUSERID = @ID", conn);
                cmd.Parameters.AddWithValue("@RFID", rfid);
                cmd.Parameters.AddWithValue("@NAME", username);
                cmd.Parameters.AddWithValue("@ID", userId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            this.BindRepeater();
        }

        protected void OnCancel(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            this.ToggleElements(item, false);
        }

        protected void deleteUser(object sender, EventArgs e)
        {
            string userdb = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;
            int userId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("lblUserID") as Label).Text);

            using (SqlConnection conn = new SqlConnection(userdb))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM USERTABLE WHERE UNIQUEUSERID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("userList.aspx");
            }
        }
    }
}