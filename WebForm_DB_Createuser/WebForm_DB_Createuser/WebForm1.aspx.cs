using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;


namespace WebForm_DB_Createuser
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string lineData;
        public string barData;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                LoadDataofLineChart();
                gvBarChart.Visible = false;

            }
            if (DropDownList1.SelectedIndex == 1)
            {
                LoadDataofBarChart();
                gvLineChart.Visible = false;

            }

        }

        public void LoadDataofLineChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Date, Temp From Temperature Where EventType='HighLimit'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvLineChart.DataSource = dt;
            gvLineChart.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            lineData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string month = Convert.ToString(dr["Date"]);
                string TempMonth = month.Substring(0, 2);
                Debug.WriteLine(TempMonth);
                Debug.WriteLine(month);

                lineData += "[" + TempMonth + "," + dr["Temp"] + "],";
            }
            lineData = lineData.Remove(lineData.Length - 1) + ']';
        }

        public void LoadDataofBarChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Date, Temp From Temperature Where EventType='HighLimit'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());

            gvBarChart.DataSource = dt;
            gvBarChart.DataBind();

            //data format is [  [x1,y1], [x2,y2], ...]
            barData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string month = Convert.ToString(dr["Date"]);
                string TempMonth = month.Substring(0, 2);
                Debug.WriteLine(TempMonth);
                Debug.WriteLine(month);

                barData += "[" + dr["Temp"] + "," + TempMonth + "],";
            }
            barData = barData.Remove(barData.Length - 1) + ']';
        }
    }
}