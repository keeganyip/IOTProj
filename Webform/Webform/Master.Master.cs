using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Webform
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                string sessionCheck = Session["id"].ToString();
                Debug.WriteLine(sessionCheck + "abc");
            }
            else
            {
                Response.Redirect("sessionTimeout.aspx");
            }
        }
        protected void signOutClick(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}