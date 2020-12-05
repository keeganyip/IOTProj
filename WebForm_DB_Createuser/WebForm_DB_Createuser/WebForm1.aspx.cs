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
        public string tempData;
        public string humidityData;
        public string moistureData;
        public string lightData;
        public string RFIDData;

        protected void Page_Load(object sender, EventArgs e)
        {                     
            LoadDataofTempChart();
            LoadDataofHumidityChart();
            LoadDataofMoistureChart();
            LoadDataofLightChart();
            LoadDataofRFIDChart();
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                LoadDataofTempChart();               
                tempTable.Visible = true;
                humidityTable.Visible = false;
                moistureTable.Visible = false;
                lightTable.Visible = false;



            }
            if (DropDownList1.SelectedIndex == 1)
            {

                LoadDataofHumidityChart();
                humidityTable.Visible = true;
                tempTable.Visible = false;
                moistureTable.Visible = false;
                lightTable.Visible = false;



            }
            if (DropDownList1.SelectedIndex == 2)
            {

                LoadDataofMoistureChart();
                moistureTable.Visible = true;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                lightTable.Visible = false;


            }
            if (DropDownList1.SelectedIndex == 3)
            {

                LoadDataofLightChart();
                lightTable.Visible = true;
                moistureTable.Visible = false;
                humidityTable.Visible = false;
                tempTable.Visible = false;


            }

        }

        public void LoadDataofTempChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Time, Temp From Temperature Where EventType='HighLimit'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvtemp.DataSource = dt;
            gvtemp.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            tempData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string time = Convert.ToString(dr["Time"]);               
                string Temptime = time.Substring(0, 2) + time.Substring(3, 2);
                

                tempData += "[" + Temptime + "," + dr["Temp"] + "],";
            }
            tempData = tempData.Remove(tempData.Length - 1) + ']';
        }

        public void LoadDataofHumidityChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Time, Humidity From Humidity Where EventType='HighHumidity'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvhumidity.DataSource = dt;
            gvhumidity.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            humidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string time = Convert.ToString(dr["Time"]);
                string Temptime = time.Substring(0, 2) + time.Substring(3, 2);
                

                humidityData += "[" + Temptime + "," + dr["Humidity"] + "],";
                
            }
            humidityData = humidityData.Remove(humidityData.Length - 1) + ']';
            
        }

        public void LoadDataofMoistureChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Time, Moisture From Moisture Where EventType='HighMoisture'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvmoisture.DataSource = dt;
            gvmoisture.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            moistureData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string time = Convert.ToString(dr["Time"]);
                string Temptime = time.Substring(0, 2) + time.Substring(3, 2);
                

                moistureData += "[" + Temptime + "," + dr["Moisture"] + "],";

            }
            moistureData = moistureData.Remove(moistureData.Length - 1) + ']';
           
        }

        public void LoadDataofLightChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Time, Light From Light Where EventType='HighIntensity'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvlight.DataSource = dt;
            gvlight.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            lightData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string time = Convert.ToString(dr["Time"]);
                string Temptime = time.Substring(0, 2) + time.Substring(3, 2);
                

                lightData += "[" + Temptime + "," + dr["Light"] + "],";

            }
            lightData = lightData.Remove(lightData.Length - 1) + ']';

        }

        public void LoadDataofRFIDChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Time, UserID From RFID Where EventType='NormalUser' ORDER BY 'UserID'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvRFID.DataSource = dt;
            gvRFID.DataBind();

            for (int i = 0; i < dt.Rows.Count - 1; )
            {
                DataRow row = dt.Rows[i];
                DataRow nextRow = dt.Rows[i + 1];
                string time = Convert.ToString(row["Time"]);
                string Temptime1 = time.Substring(0, 2) + time.Substring(3, 2);

                string time2 = Convert.ToString(nextRow["Time"]);
                string Temptime2 = time2.Substring(0, 2) + time2.Substring(3, 2);
                int userID = Convert.ToInt32(row["UserID"]);


                RFIDData += "{x:" + Temptime1 + "," + "x2:" + Temptime2 + "," + "y:" + (userID - 1) + "},";

                i = i + 2;

            }
            RFIDData = RFIDData.Remove(RFIDData.Length - 1);
            Debug.WriteLine(RFIDData);       

        }

    }
}