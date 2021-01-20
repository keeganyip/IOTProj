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
        public string idealHumidityData;
        public string diffHumidityData;
        public string moistureData;
        public string idealMoistureData;
        public string lightData;
        public string idealLightData;
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
                LoadDataofHumidityChart();
                LoadDataofMoistureChart();
                LoadDataofLightChart();
                LoadDataofRFIDChart();
                tempTable.Visible = true;
                humidityTable.Visible = true;
                moistureTable.Visible = true;
                lightTable.Visible = true;
                RFIDTable.Visible = true;
            }
            if (DropDownList1.SelectedIndex == 1)
            {
                LoadDataofTempChart();
                humidityTable.Visible = false;
                tempTable.Visible = true;
                moistureTable.Visible = false;
                lightTable.Visible = false;
                RFIDTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 2)
            {
                LoadDataofHumidityChart();
                moistureTable.Visible = false;
                humidityTable.Visible = true;
                tempTable.Visible = false;
                lightTable.Visible = false;
                RFIDTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 3)
            {
                LoadDataofMoistureChart();
                lightTable.Visible = false;
                moistureTable.Visible = true;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                RFIDTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 4)
            {
                LoadDataofLightChart();
                lightTable.Visible = true;
                moistureTable.Visible = false;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                RFIDTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 5)
            {
                LoadDataofRFIDChart();
                lightTable.Visible = false;
                moistureTable.Visible = false;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                RFIDTable.Visible = true;
            }

        }

        public void LoadDataofTempChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select FORMAT(TimeOccured,'dd/MM/yyyy HH:mm:ss') as TimeOccured, tempStatus From tempSensor";
          

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            
            dt.Load(comm.ExecuteReader());
            
            gvtemp.DataSource = dt;
            gvtemp.DataBind();


            //data format is [  {x1,y1}, {x2,y2}, ...]
            //date format: Date.UTC(2010, 1, 1, 12, 0, 0)
            tempData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["TimeOccured"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);               
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);
                string tempconverted = Convert.ToString(dr["tempStatus"]);
                string temp = tempconverted.Trim();
                temp = temp.Substring(0, 2);
                


                tempData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), y: " + temp + "},";
            }
            tempData = tempData.Remove(tempData.Length - 1) + ']';
            Debug.WriteLine("TEMPERATURE");
            Debug.WriteLine(tempData);
        }

        public void LoadDataofHumidityChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Date, Time, Humidity From Humidity Where EventType='HighHumidity'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvhumidity.DataSource = dt;
            gvhumidity.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            humidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);
                

                humidityData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "), y: " + dr["Humidity"] + "},";
                
            }
            humidityData = humidityData.Remove(humidityData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealHumidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);


                idealHumidityData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "), y: " + 60 + "},";

            }
            idealHumidityData = idealHumidityData.Remove(idealHumidityData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            diffHumidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);

                diffHumidityData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "), " + 60 + ", " + dr["Humidity"] + "],";
            }
            diffHumidityData = diffHumidityData.Remove(diffHumidityData.Length - 1) + ']';
            Debug.WriteLine("DiffHUMID");
            Debug.WriteLine(diffHumidityData);

        }

        public void LoadDataofMoistureChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Date, Time, Moisture From Moisture Where EventType='HighMoisture'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvmoisture.DataSource = dt;
            gvmoisture.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            moistureData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);


                moistureData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "), y: " + dr["Moisture"] + "},";

            }
            moistureData = moistureData.Remove(moistureData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealMoistureData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);


                idealMoistureData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "), y: " + 16 + "},";

            }
            idealMoistureData = idealMoistureData.Remove(idealMoistureData.Length - 1) + ']';

        }

        public void LoadDataofLightChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select Date, Time, Light From Light Where EventType='HighIntensity'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvlight.DataSource = dt;
            gvlight.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            lightData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);


                lightData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "), y: " + dr["Light"] + "},";

            }
            lightData = lightData.Remove(lightData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealLightData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["Date"]);
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["Time"]);
                string hour = time.Substring(0, 2);


                idealLightData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "), y: " + 4500 + "},";

            }
            idealLightData = idealLightData.Remove(idealLightData.Length - 1) + ']';

        }

        public void LoadDataofRFIDChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectStr"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            //string strCommandText = "Select UserID, Date, Time From RFID Where EventType='NormalUser' ORDER BY 'UserID'";

            string strCommandText = "Select UserID, CONVERT(VARCHAR(10), Date, 111) AS Date, Time From RFID Where EventType='NormalUser' ORDER BY 'UserID'";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            gvRFID.DataSource = dt;
            gvRFID.DataBind();

            Debug.WriteLine("gvRFID DATAAAAA");
            string datadata = Convert.ToString(dt.Rows[1]["Date"]);
            Debug.WriteLine(datadata);

            for (int i = 0; i < dt.Rows.Count - 1; )
            {
                DataRow row = dt.Rows[i];
                DataRow nextRow = dt.Rows[i + 1];
                string datemin = Convert.ToString(row["Date"]);
                string yearmin = datemin.Substring(6, 4);
                string monthmin = datemin.Substring(3, 2);
                string daymin = datemin.Substring(0, 2);
                string timemin = Convert.ToString(row["Time"]);
                string hourmin = timemin.Substring(0, 2);

                string datemax = Convert.ToString(nextRow["Date"]);
                string yearmax = datemax.Substring(6, 4);
                string monthmax = datemax.Substring(3, 2);
                string daymax = datemax.Substring(0, 2);
                string timemax = Convert.ToString(nextRow["Time"]);
                string hourmax = timemax.Substring(0, 2);
                int userID = Convert.ToInt32(row["UserID"]);


                RFIDData += "{" + "x: Date.UTC(" + yearmin + "," + monthmin + "," + daymin + "," + hourmin + "), x2: Date.UTC(" + yearmax + "," + monthmax + "," + daymax + "," + hourmax + "), y:" + (userID - 1) + "},";

                i = i + 2;

            }
            RFIDData = RFIDData.Remove(RFIDData.Length - 1);
            Debug.WriteLine(RFIDData);       

        }

    }
}