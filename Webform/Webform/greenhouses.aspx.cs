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
    public partial class greenhouses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet greenhouse = GetGreenhouse();
            Repeater1.DataSource = greenhouse;
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
            }
            else
            {
                Response.Redirect("sessionTimeout.aspx");
            }
        }

        private DataSet GetGreenhouse()
        {
            string userdb = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(userdb))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM GREENHOUSESTABLE", conn);
                DataSet greenhouse = new DataSet();
                cmd.Fill(greenhouse);
                return greenhouse;
            }
        }
    }
}