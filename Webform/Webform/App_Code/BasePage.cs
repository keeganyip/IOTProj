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
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["session"].ToString().Trim() == "logged")
        {
            this.MasterPageFile = "~/Master.master";
        }
        else if (Session["session"].ToString().Trim() == "adminlogged")
        {
            this.MasterPageFile = "~/AdminMaster.master";
        }
        else
        {
            Response.Redirect("sessionTimeout.aspx");
        }
        //if (Session["CHANGE_MASTERPAGE"] != null && Session["CHANGE_MASTERPAGE2"] == null)
        //{
        //    this.MasterPageFile = Session["CHANGE_MASTERPAGE"].ToString();
        //}

        //if (Session["CHANGE_MASTERPAGE2"] != null && Session["CHANGE_MASTERPAGE"] == null)
        //{
        //    this.MasterPageFile = Session["CHANGE_MASTERPAGE2"].ToString();
        //}
    }
}