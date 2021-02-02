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
        public string idealTempData;
        public string diffTempData;
        public string tempAnalysis;
        public string humidityData;
        public string idealHumidityData;
        public string diffHumidityData;
        public string humidityAnalysis;
        public string moistureData;
        public string idealMoistureData;
        public string diffMoistureData;
        public string moistureAnalysis;
        public string lightData;
        public string idealLightData;
        public string lightAnalysis;
        public string diffLightData;
        public string heightData;
        public string idealHeightData;
        public string diffHeightData;
        public string heightAnalysis;
        public string RFIDData;

        protected void Page_Load(object sender, EventArgs e)
        {                     
            LoadDataofTempChart();
            LoadTempAnalysis();
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
                LoadTempAnalysis();
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
                LoadTempAnalysis();
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);               
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);
                string tempconverted = Convert.ToString(dr["tempStatus"]);
                string temp = tempconverted.Trim();
                temp = temp.Substring(0, 2);            

                tempData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + temp + "],";

            }
            tempData = tempData.Remove(tempData.Length - 1) + ']';
            Debug.WriteLine(tempData);
            //data format is [  [x1,y1], [x2,y2], ...]
            idealTempData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["TimeOccured"]);
                string year = date.Substring(6, 4);
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);


                idealTempData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 26 + ", " + 30 + "],";

            }
            idealTempData = idealTempData.Remove(idealTempData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            diffTempData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["TimeOccured"]);
                string year = date.Substring(6, 4);
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);
                string tempconverted = Convert.ToString(dr["tempStatus"]);
                string temp = tempconverted.Trim();
                temp = temp.Substring(0, 2);

                diffTempData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 26 + ", " + temp + "],";
            }
            diffTempData = diffTempData.Remove(diffTempData.Length - 1) + ']';
            
        }

        public void LoadTempAnalysis()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select AVG(tempValue) as tempValue From tempSensor Where TimeOccured BETWEEN DATEADD(Hour, -1, GETDATE()) AND GETDATE()";


            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();


            //data format is [  {x1,y1}, {x2,y2}, ...]
            //date format: Date.UTC(2010, 1, 1, 12, 0, 0)
            int avgTemp = 0;            
            foreach (DataRow dr in dt.Rows)
            {
                string tempconverted = Convert.ToString(dr["tempValue"]);
                string temp = tempconverted.Trim();
                temp = temp.Substring(0, 2);
                avgTemp = Convert.ToInt32(temp);              

            }

            if (avgTemp > 30)
            {                
                tempAnalysis = "Past Hour Average Temperature: " + avgTemp + "°C <br>" +
                    "The Past Hour Average Temperature is higher than the ideal temperature by " + (avgTemp - 30) + "°C, PLEASE LOWER THE TEMPERATURE!";
            }
            else if (avgTemp < 26)
            {
                tempAnalysis = "Past Hour Average Temperature: " + avgTemp + "°C <br>" +
                    "The Past Hour Average Temperature is higher than the ideal temperature by " + (26 - avgTemp) + "°C, PLEASE INCREASE THE TEMPERATURE!";
            }
            else
            {
                tempAnalysis = "Past Hour Average Temperature: " + avgTemp + "°C <br>" +
                    "The Past Hour Average Temperature is ideal!";
            }
       
        }
        

        public void LoadDataofHumidityChart()
        {
           string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select FORMAT(TimeOccured,'dd/MM/yyyy HH:mm:ss') as TimeOccured, HumValue From HumiditySensor";
          

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();
            
            dt.Load(comm.ExecuteReader());
            
            gvhumidity.DataSource = dt;
            gvhumidity.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            humidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["TimeOccured"]);
                string year = date.Substring(6, 4);
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);
                string humconverted = Convert.ToString(dr["HumValue"]);
                string hum = humconverted.Trim();

                humidityData += "{" + "x: Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), y: " + hum + "},";
                
            }
            humidityData = humidityData.Remove(humidityData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealHumidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["TimeOccured"]);
                string year = date.Substring(6, 4);
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);

                idealHumidityData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 50 + "," + 70 + "],";

            }
            idealHumidityData = idealHumidityData.Remove(idealHumidityData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            diffHumidityData = "[";
            foreach (DataRow dr in dt.Rows)
            {
                string date = Convert.ToString(dr["TimeOccured"]);
                string year = date.Substring(6, 4);
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
                string day = date.Substring(0, 2);
                string time = Convert.ToString(dr["TimeOccured"]);
                string hour = time.Substring(11, 2);
                string min = time.Substring(14, 2);
                string sec = time.Substring(17, 2);
                string humconverted = Convert.ToString(dr["HumValue"]);
                string hum = humconverted.Trim();

                diffHumidityData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 50 + ", " + hum + "],";
            }
            diffHumidityData = diffHumidityData.Remove(diffHumidityData.Length - 1) + ']';
            

        }

        public void LoadDataofMoistureChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select FORMAT(TimeOccured,'dd/MM/yyyy HH:mm:ss') as TimeOccured, moistureLevel From moistureSensor";


            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            moistureData = "[";
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
                string moistureconverted = Convert.ToString(dr["moistureLevel"]);
                string moisture = moistureconverted.Trim();
                int moisturepercent = Convert.ToInt32(moisture);
                moisturepercent = (moisturepercent / 2) / 10;

                


                moistureData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + moisturepercent + "],";

            }
            moistureData = moistureData.Remove(moistureData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealMoistureData = "[";
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


                idealMoistureData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 10 + "," + 45 + "],";

            }
            idealMoistureData = idealMoistureData.Remove(idealMoistureData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            diffMoistureData = "[";
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
                string moistureconverted = Convert.ToString(dr["moistureLevel"]);
                string moisture = moistureconverted.Trim();
                int moisturepercent = Convert.ToInt32(moisture);
                moisturepercent = (moisturepercent / 2) / 10;


                diffMoistureData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 10 + ", " + moisturepercent + "],";
            }
            diffMoistureData = diffMoistureData.Remove(diffMoistureData.Length - 1) + ']';
            

        }

        public void LoadDataofLightChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select FORMAT(TimeOccured,'dd/MM/yyyy HH:mm:ss') as TimeOccured, lightValue From lightSensor";


            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            lightData = "[";
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
                string lightconverted = Convert.ToString(dr["lightValue"]);
                string light = lightconverted.Trim();


                lightData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + light + "],";

            }
            lightData = lightData.Remove(lightData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealLightData = "[";
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


                idealLightData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 3500 + "," + 4500 + "],";

            }
            idealLightData = idealLightData.Remove(idealLightData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            diffLightData = "[";
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
                string lightconverted = Convert.ToString(dr["lightValue"]);
                string light = lightconverted.Trim();


                diffLightData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 3500 + ", " + light + "],";
            }
            diffLightData = diffLightData.Remove(diffLightData.Length - 1) + ']';

        }

        public void LoadDataofHeightChart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select FORMAT(TimeOccured,'dd/MM/yyyy HH:mm:ss') as TimeOccured, plantHeight From PlantHeight";


            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();


            //data format is [  [x1,y1], [x2,y2], ...]
            heightData = "[";
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
                string heightconverted = Convert.ToString(dr["plantHeight"]);
                string height = heightconverted.Trim();


                heightData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + height + "],";

            }
            heightData = heightData.Remove(heightData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            idealHeightData = "[";
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


                idealHeightData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 120 + "," + 150 + "],";

            }
            idealHeightData = idealHeightData.Remove(idealHeightData.Length - 1) + ']';

            //data format is [  [x1,y1], [x2,y2], ...]
            diffHeightData = "[";
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
                string heightconverted = Convert.ToString(dr["plantHeight"]);
                string height = heightconverted.Trim();


                diffHeightData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + 120 + ", " + height + "],";
            }
            diffHeightData = diffHeightData.Remove(diffHeightData.Length - 1) + ']';

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