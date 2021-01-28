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
            Greenhouse oGHouse = new Greenhouse();

            string gHouseID = Request.QueryString["Gid"].ToString();
            gHouse = oGHouse.getGHouse(gHouseID);

        }


    }
}