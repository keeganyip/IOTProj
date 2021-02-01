using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Diagnostics;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebForm_DB_Createuser.Account
{
    public partial class UpdateRFID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }
            string logged = Session["id"] as string;
            if (logged == null)
            {
                Response.Redirect("Login");
            }



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
        protected void gvbind()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select UniqueUserID, Name, UniqueRFID  from UserTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "No Records Found";
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Debug.WriteLine(GridView1.DataKeys[0]);
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
           
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
             
            TextBox textName = (TextBox)row.Cells[1].Controls[0];
            TextBox textrfid = (TextBox)row.Cells[2].Controls[0];
            
            
            GridView1.EditIndex = -1;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString);
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
            SqlCommand cmd = new SqlCommand("update UserTable set Name='" + textName.Text + "',UniqueRFID='" + textrfid.Text  + "'where UniqueUserID='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbind();
        }
    }
}