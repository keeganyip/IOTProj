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
    public partial class greenhouseDetails : BasePage
    {
        Greenhouse gHouse = null;

        string constr = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet user = GetUser();
            Repeater1.DataSource = user;
            Repeater1.DataBind();

            Greenhouse oGHouse = new Greenhouse();

            string gHouseID = Request.QueryString["Gid"].ToString();
            gHouse = oGHouse.getGHouse(gHouseID);

        }

        private DataSet GetUser()
        {
            string userdb = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(userdb))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UserTable", conn);
                DataSet greenhouse = new DataSet();
                cmd.Fill(greenhouse);
                return greenhouse;
            }
        }
    }
}