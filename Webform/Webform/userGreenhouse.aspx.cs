using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.UI;

namespace Webform
{
    public partial class userGreenhouse : BasePage
    {
        private string constr = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

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

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDataofTempChart();
            LoadTempAnalysis();

            humidityTable.Visible = false;
            tempTable.Visible = true;
            moistureTable.Visible = false;
            lightTable.Visible = false;
            heightTable.Visible = false;
            //LoadDataofHumidityChart();
            //LoadHumAnalysis();
            //LoadDataofMoistureChart();
            //LoadMoistureAnalysis();
            //LoadDataofLightChart();
            //LoadLightAnalysis();
            //LoadDataofHeightChart();
            //LoadHeightAnalysis();

            int userId = Convert.ToInt32(Session["id"].ToString());
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string gidCmdStr = "SELECT GREENHOUSE_ENTRY_AMOUNT FROM USERTABLE WHERE UNIQUEUSERID = '" + userId + "'";
                SqlCommand gidCmd = new SqlCommand(gidCmdStr, conn);
                conn.Open();
                string gidentries = gidCmd.ExecuteScalar().ToString();
                lblGid.Text = gidentries;
                conn.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                LoadDataofTempChart();
                LoadTempAnalysis();
                humidityTable.Visible = false;
                tempTable.Visible = true;
                moistureTable.Visible = false;
                lightTable.Visible = false;

                heightTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 1)
            {
                LoadDataofHumidityChart();
                LoadHumAnalysis();
                moistureTable.Visible = false;
                humidityTable.Visible = true;
                tempTable.Visible = false;
                lightTable.Visible = false;

                heightTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 2)
            {
                LoadDataofMoistureChart();
                LoadMoistureAnalysis();
                lightTable.Visible = false;
                moistureTable.Visible = true;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                heightTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 3)
            {
                LoadDataofLightChart();
                LoadLightAnalysis();
                lightTable.Visible = true;
                moistureTable.Visible = false;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                heightTable.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 4)
            {
                LoadDataofHeightChart();
                LoadHeightAnalysis();
                lightTable.Visible = false;
                moistureTable.Visible = false;
                humidityTable.Visible = false;
                tempTable.Visible = false;
                heightTable.Visible = true;
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

                tempData += "[" + "Date.UTC(" + year + "," + month + "," + day + "," + hour + "," + min + "," + sec + "), " + temp + "],";
            }
            tempData = tempData.Remove(tempData.Length - 1) + ']';

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
            double avgTemp = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string tempconverted = Convert.ToString(dr["tempValue"]);
                    string temp = tempconverted.Trim();

                    avgTemp = Convert.ToDouble(temp);
                }

                if (avgTemp > 30)
                {
                    tempAnalysis = "Past Hour Average Temperature: " + avgTemp + "°C <br>" +
                        "The Past Hour Average Temperature is higher than the ideal temperature by " + (avgTemp - 30) + "°C <br>" +
                        "Action Taken: Temperature is currently being lowered!";
                }
                else if (avgTemp < 26)
                {
                    tempAnalysis = "Past Hour Average Temperature: " + avgTemp + "°C <br>" +
                        "The Past Hour Average Temperature is lower than the ideal temperature by " + (26 - avgTemp) + "°C <br>" +
                        "Action Taken: Temperature is currently being increased!";
                }
                else
                {
                    tempAnalysis = "Past Hour Average Temperature: " + avgTemp + "°C <br>" +
                        "The Past Hour Average Temperature is ideal!";
                }
            }
            catch (Exception)
            {
                tempAnalysis = "No data captured in the past hour!";
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

        public void LoadHumAnalysis()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select AVG(HumValue) as HumValue From HumiditySensor Where TimeOccured BETWEEN DATEADD(Hour, -1, GETDATE()) AND GETDATE()";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();

            //data format is [  {x1,y1}, {x2,y2}, ...]
            //date format: Date.UTC(2010, 1, 1, 12, 0, 0)
            double avgHum = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string humconverted = Convert.ToString(dr["HumValue"]);
                    string hum = humconverted.Trim();

                    avgHum = Convert.ToDouble(hum);
                }

                if (avgHum > 70)
                {
                    humidityAnalysis = "Past Hour Average Humidity: " + avgHum + "% <br>" +
                        "The Past Hour Average Humidity is higher than the ideal Humidity by " + (avgHum - 70) + "% <br>" +
                        "Action Taken: Humidity is currently being lowered!";
                }
                else if (avgHum < 50)
                {
                    humidityAnalysis = "Past Hour Average Humidity: " + avgHum + "% <br>" +
                        "The Past Hour Average Humidity is lower than the ideal Humidity by " + (50 - avgHum) + "% <br>" +
                        "Action Taken: Humidity is currently being increased!";
                }
                else
                {
                    humidityAnalysis = "Past Hour Average Humidity: " + avgHum + "% <br>" +
                        "The Past Hour Average Humidity is ideal!";
                }
            }
            catch (Exception)
            {
                humidityAnalysis = "No data captured in the past hour!";
            }
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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

        public void LoadMoistureAnalysis()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select AVG(moistureLevel) as moistureLevel From moistureSensor Where TimeOccured BETWEEN DATEADD(Hour, -1, GETDATE()) AND GETDATE()";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();

            //data format is [  {x1,y1}, {x2,y2}, ...]
            //date format: Date.UTC(2010, 1, 1, 12, 0, 0)
            double avgMoisture = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string moistconverted = Convert.ToString(dr["moistureLevel"]);
                    string moist = moistconverted.Trim();

                    int moisturepercent = Convert.ToInt32(moist);
                    moisturepercent = (moisturepercent / 2) / 10;

                    avgMoisture = Convert.ToDouble(moisturepercent);
                }

                if (avgMoisture > 45)
                {
                    moistureAnalysis = "Past Hour Average Soil Moisture Level: " + avgMoisture + "% <br>" +
                        "The Past Hour Average Moisture is higher than the ideal Level by " + (avgMoisture - 45) + "% <br>" +
                        "Action Taken: Soil Moisture Level is currently being lowered!";
                }
                else if (avgMoisture < 10)
                {
                    moistureAnalysis = "Past Hour Average Soil Moisture Level: " + avgMoisture + "% <br>" +
                        "The Past Hour Average Soil Moisture Level is lower than the ideal Level by " + (10 - avgMoisture) + "% <br>" +
                        "Action Taken: Soil Moisture Level is currently being increased!";
                }
                else
                {
                    moistureAnalysis = "Past Hour Average Soil Moisture Level: " + avgMoisture + "% <br>" +
                        "The Past Hour Average Soil Moisture Level is ideal!";
                }
            }
            catch (Exception)
            {
                moistureAnalysis = "No data captured in the past hour!";
            }
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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

        public void LoadLightAnalysis()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select AVG(lightValue) as lightValue From lightSensor Where TimeOccured BETWEEN DATEADD(Hour, -1, GETDATE()) AND GETDATE()";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();

            //data format is [  {x1,y1}, {x2,y2}, ...]
            //date format: Date.UTC(2010, 1, 1, 12, 0, 0)
            double avgLight = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string lightconverted = Convert.ToString(dr["lightValue"]);
                    string light = lightconverted.Trim();

                    avgLight = Convert.ToDouble(light);
                }

                if (avgLight > 70)
                {
                    lightAnalysis = "Past Hour Average Light Intensity: " + avgLight + "lux <br>" +
                        "The Past Hour Average Light Intensity is higher than the ideal by " + (avgLight - 70) + "lux <br>" +
                        "Action Taken: Light Intensity is currently being lowered!";
                }
                else if (avgLight < 50)
                {
                    lightAnalysis = "Past Hour Average Light Intensity: " + avgLight + "lux <br>" +
                        "The Past Hour Average Light Intensity is lower than the ideal by " + (50 - avgLight) + "lux <br>" +
                        "Action Taken: Light Intensity is currently being increased!";
                }
                else
                {
                    lightAnalysis = "Past Hour Average Light Intensity: " + avgLight + "lux <br>" +
                        "The Past Hour Average Light Intensity is ideal!";
                }
            }
            catch (Exception)
            {
                lightAnalysis = "No data captured in the past hour!";
            }
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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
                string monthbefore = date.Substring(3, 2);
                int month = Convert.ToInt32(monthbefore);
                month = month - 1;
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

        public void LoadHeightAnalysis()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "Select MAX(plantHeight) AS MaxPlantHeight, MIN(plantHeight) AS MinPlantHeight From PlantHeight Where TimeOccured BETWEEN DATEADD(DAY, -5, GETDATE()) AND GETDATE()";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);
            DataTable dt = new DataTable();

            dt.Load(comm.ExecuteReader());

            gvtemp.DataSource = dt;
            gvtemp.DataBind();

            //data format is [  {x1,y1}, {x2,y2}, ...]
            //date format: Date.UTC(2010, 1, 1, 12, 0, 0)
            double avgHeight = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string maxheightconverted = Convert.ToString(dr["MaxPlantHeight"]);
                    string smaxheight = maxheightconverted.Trim();
                    double maxheight = Convert.ToDouble(smaxheight);

                    string minheightconverted = Convert.ToString(dr["MinPlantHeight"]);
                    string sminheight = minheightconverted.Trim();
                    double minheight = Convert.ToDouble(sminheight);

                    avgHeight = ((maxheight - minheight) / 5);
                }

                //avg rate of growth of tomatoes in cm is 15cm

                if (avgHeight > 10)
                {
                    heightAnalysis = "Past 5 Days Average Growth: " + avgHeight + "cm <br>" +
                        "The Past 5 Days Average Growth is faster than the ideal growth rate by " + (avgHeight - 10) + "cm <br>" +
                        "Advice: Keep it up and maintain!";
                }
                else if (avgHeight < 4)
                {
                    heightAnalysis = "Past 5 Days Average Growth: " + avgHeight + "cm <br>" +
                        "The Past 5 Days Average Growth is slower than the ideal growth rate by " + (5 - avgHeight) + "cm <br>" +
                        "Advice: Please check on the plant and the other conditions!";
                }
                else
                {
                    heightAnalysis = "Past 5 Days Average Growth: " + avgHeight + "cm <br>" +
                        "The Past 5 Days Average Growth is ideal!";
                }
            }
            catch (Exception)
            {
                heightAnalysis = "No data captured in the past hour!";
            }
        }

        public void RepeatLoadingData(object sender, EventArgs e)
        {
            Debug.WriteLine("REPEATEDDDD START");
            LoadDataofTempChart();
            LoadTempAnalysis();
            LoadDataofHumidityChart();
            LoadHumAnalysis();
            LoadDataofMoistureChart();
            LoadMoistureAnalysis();
            LoadDataofLightChart();
            LoadLightAnalysis();
            LoadDataofHeightChart();
            LoadHeightAnalysis();

            ScriptManager.RegisterStartupScript(this,
                                                        this.GetType(),
                                                        "Funct",
                                                        "temdata = " + tempData + ";" +
                                                        "idealtempdata = " + idealTempData + ";" +
                                                        "difftempdata = " + diffTempData + ";" +
                                                        "tempanalysis = " + "'" + tempAnalysis + "'" + ";" +
                                                        "humdata = " + humidityData + ";" +
                                                        "idealhumdata = " + idealHumidityData + ";" +
                                                        "diffhumdata = " + diffHumidityData + ";" +
                                                        "humidityAnalysis = " + "'" + humidityAnalysis + "'" + ";" +
                                                        "moistdata = " + moistureData + ";" +
                                                        "idealmoistdata = " + idealMoistureData + ";" +
                                                        "diffmoistdata = " + diffMoistureData + ";" +
                                                        "moistureAnalysis = " + "'" + moistureAnalysis + "'" + ";" +
                                                        "lightdata = " + lightData + ";" +
                                                        "ideallightdata = " + idealLightData + ";" +
                                                        "difflightdata = " + diffLightData + ";" +
                                                        "lightAnalysis = " + "'" + lightAnalysis + "'" + ";" +
                                                        "heightdata = " + heightData + ";" +
                                                        "idealheightdata = " + idealHeightData + ";" +
                                                        "diffheightdata = " + diffHeightData + ";" +
                                                        "heightanalysis = " + "'" + heightAnalysis + "'" + ";",
                                                        true);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("NEW");
            LoadDataofTempChart();
            LoadTempAnalysis();
            LoadDataofHumidityChart();
            LoadHumAnalysis();
            LoadDataofMoistureChart();
            LoadMoistureAnalysis();
            LoadDataofLightChart();
            LoadLightAnalysis();
            LoadDataofHeightChart();
            LoadHeightAnalysis();

            Debug.WriteLine("NEWSUCCESS");
        }
    }
}