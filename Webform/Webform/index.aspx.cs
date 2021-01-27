using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

    }
}