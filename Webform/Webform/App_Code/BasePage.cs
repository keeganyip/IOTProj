using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BasePage
/// </summary>
/// 
public class BasePage : System.Web.UI.Page
{
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