﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace WebForm_DB_Createuser
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userid = Convert.ToString(Session["id"]);
            Debug.WriteLine(userid);
            
        }
    }
}