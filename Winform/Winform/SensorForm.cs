using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Winform
{
    public partial class SensorForm : Form
    {
        loginForm fl = new loginForm();
        waitRFID wr = new waitRFID();
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static bool exitFlag = false;
        string TempStatus = "";
        string WaterStatus = "";
        public bool loggedin = false;
        public string rfid = "";
        public string loginrfid = "";
        string strConnectionString =
           ConfigurationManager.ConnectionStrings["Winform.Properties.Settings.UserdbConnectionString"].ConnectionString;

        DataComms dataComms;

        public delegate void myprocessDataDelegate(String strData);

        //To save sensor data to DB, you need to change to suite your project needs
        private void saveLightSensorDataToDB(string strTime, string strlightValue, string strStatus)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "INSERT lightSensor (TimeOccured, lightValue, lightStatus) " +
                " VALUES (@time, @value, @status)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strlightValue);
            updateCmd.Parameters.AddWithValue("@status", strStatus);

            //Step 3: Open Connection
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close Connection
            myConnect.Close();
        } //End saveLightSensorDataToDB

        private void saveTempSensorDataToDB(string strTime, string strTempValue, string strTempStatus)
        {
            string prev = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "INSERT tempSensor (TimeOccured, tempValue, tempStatus) " +
                " VALUES (@time, @value, @status)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strTempValue);
            updateCmd.Parameters.AddWithValue("@status", strTempStatus);

            //Step 3: Open Connection
            myConnect.Open();
            string checkCmdText = "SELECT TOP 1 * FROM tempSensor ORDER BY ID DESC";

            SqlCommand readcmd = new SqlCommand(checkCmdText, myConnect);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                prev = reader["tempValue"].ToString().Trim();
            }
            reader.Close();
            if(prev != strTempValue)
            { 
            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();
            }

            //Step 5: Close Connection
            myConnect.Close();
        } //End saveTempSensorDataToDB

        private void saveMoistureSensorDataToDB(string strTime, string strMoistureValue, string strMoistureStatus)
        {
            string prev = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "INSERT moistureSensor (TimeOccured, moistureLevel, status) " +
                " VALUES (@time, @value, @status)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strMoistureValue);
            updateCmd.Parameters.AddWithValue("@status", strMoistureStatus);

            //Step 3: Open Connection
            myConnect.Open();

            string checkCmdText = "SELECT TOP 1 * FROM moistureSensor ORDER BY ID DESC";

            SqlCommand readcmd = new SqlCommand(checkCmdText, myConnect);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                prev = reader["moistureLevel"].ToString().Trim();
            }
            reader.Close();
            if (prev != strMoistureValue)
            {
                //Step 4: ExecuteCommand
                int result = updateCmd.ExecuteNonQuery();
            }

            //Step 5: Close Connection
            myConnect.Close();
        } //End saveMoistureSensorDataToDB

        private void saveHumSensorDataToDB(string strTime, string strHumValue)
        {
            string prev = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "INSERT HumiditySensor (TimeOccured, HumValue) " +
                " VALUES (@time, @value)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strHumValue);

            //Step 3: Open Connection
            myConnect.Open();

            string checkCmdText = "SELECT TOP 1 * FROM HumiditySensor ORDER BY ID DESC";

            SqlCommand readcmd = new SqlCommand(checkCmdText, myConnect);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                prev = reader["HumValue"].ToString().Trim();
            }
            reader.Close();
            if (prev != strHumValue)
            {
                //Step 4: ExecuteCommand
                int result = updateCmd.ExecuteNonQuery();
            }

            //Step 5: Close Connection
            myConnect.Close();
        } //End saveLightSensorDataToDB
        private void savePlantHeightToDB(string strTime, string plantHeight)
        {
            string prev = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "INSERT PlantHeight (timeOccured, plantHeight) " +
                " VALUES (@time, @height)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@height", plantHeight);

            //Step 3: Open Connection
            myConnect.Open();

            string checkCmdText = "SELECT TOP 1 * FROM PlantHeight ORDER BY ID DESC";

            SqlCommand readcmd = new SqlCommand(checkCmdText, myConnect);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                prev = reader["plantHeight"].ToString().Trim();
            }
            reader.Close();
            if (prev != plantHeight)
            {
                //Step 4: ExecuteCommand
                int result = updateCmd.ExecuteNonQuery();
            }

            //Step 5: Close Connection
            myConnect.Close();
        }

        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;  
        }

        //utility method, you should not need to edit this
        private float extractFlotValue(string strData, string ID)
        {
            return (float.Parse(extractStringValue(strData, ID)));
        }



        //create your own data handler for your project needs
        private void handleTempSensorData(string strData, string strTime, string ID)
        {
            int max = Convert.ToInt32(retrieveTempSetting()[0]);
            int warn = Convert.ToInt32(retrieveTempSetting()[1]);

            //update GUI component in any tabs
            string strtempValue = extractStringValue(strData, ID);
            float ftempValue = extractFlotValue(strData, ID);

            if (ftempValue > max)
            {
                tbtemp.BackColor = Color.Red;
                tbtemp.ForeColor = Color.White;
                TempStatus = "OVER MAX! Activating Reduction now";
                if (!lbLiveStatus.Items.Contains(TempStatus))
                {
                    lbLiveStatus.Items.Insert(0, TempStatus);
                }
                dataComms.sendData("BUZZ");
                Console.WriteLine("BUZZING");
            }
            else if (ftempValue > warn)
            {
                TempStatus = "warning!!";
                
                dataComms.sendData("WARN");
            }
            else
            {
                tbtemp.BackColor = Color.Gray;
                tbtemp.ForeColor = Color.Black;
                if(lbLiveStatus.Items.Contains(TempStatus))
                {
                    lbLiveStatus.Items.Remove(TempStatus);
                }
                dataComms.sendData("Normal");
            }
            //string temp = strtempValue.Substring(0, 5) + "°C";
            tbtemp.Text = strtempValue + "°C";
            retrieveTempSetting();

            saveTempSensorDataToDB(strTime, strtempValue, strtempValue);

        }
        public string[] retrieveTempSetting()
        {
            string max = "";
            string warn = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "SELECT MaxTemp, WarningTemp FROM TempSettings";

            //Step 3: Open Connection
            myConnect.Open();

            SqlCommand readcmd = new SqlCommand(strCommandText, myConnect);

            SqlDataReader reader = readcmd.ExecuteReader();

            while (reader.Read())
            {
                max = reader["MaxTemp"].ToString().Trim();
                warn = reader["WarningTemp"].ToString().Trim();
            }
            myConnect.Close();
            string[] Settings = { max, warn };
            return Settings;

        }
        private void handleLightSensorData(string strData, string strTime, string ID)
        {
            //update GUI component in any tabs
            string strlightValue = extractStringValue(strData, ID);
            
            //tb_light.Text = strlightValue;

            float fLightValue = extractFlotValue(strData, ID);
            string status = "";
            if (fLightValue <= 500)
                 status = "Dark";
            else
                 status = "Bright";
             tb_light.Text = status;

            //update database
            saveLightSensorDataToDB(strTime, strlightValue, status);
        }
        private void handleRfidData(string strData, string strTime, string ID)
        {
            string strRFID = extractStringValue(strData, ID);
            rfid = strRFID;
            Debug.WriteLine("SEND RFID" + rfid);
            //update GUI component in any tabs

        }
        public string retrieveWaterSetting()
        {
            string threshold = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "SELECT Threshold FROM WaterSettings";

            //Step 3: Open Connection
            myConnect.Open();

            SqlCommand readcmd = new SqlCommand(strCommandText, myConnect);

            SqlDataReader reader = readcmd.ExecuteReader();

            while (reader.Read())
            {
                threshold = reader["Threshold"].ToString().Trim();
            }
            myConnect.Close();
            return threshold;

        }

        // This is the method to run when the timer is raised.
        private static void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();

            // Stops the timer.
            exitFlag = true;
        }

        private void handleMoisture(string strData, string strTime, string ID)
        {
            string strMoistureValue = extractStringValue(strData, ID);
            float fMoistureValue = extractFlotValue(strData, ID);
            string status = "";
            int threshold = Convert.ToInt32(retrieveWaterSetting());
            if (fMoistureValue > threshold)
            {
                tb_Moisture.BackColor = Color.Red;
                tb_Moisture.ForeColor = Color.White;
                WaterStatus = "Water Turning On";
                if((lbLiveStatus.Items.Contains(WaterStatus) == false))
                {
                    lbLiveStatus.Items.Insert(0, WaterStatus);
                }
                status = "Dry";
            }
            else if (fMoistureValue < 100)
                status = "There is water pending";
            else
            { 
                status = "Moderately Wet";
                tb_Moisture.BackColor = Color.Gray;
                tb_Moisture.ForeColor = Color.Black;
                if (lbLiveStatus.Items.Contains(WaterStatus))
                {
                    lbLiveStatus.Items.Remove(WaterStatus);
                }
            }
            tb_Moisture.Text = status;

            saveMoistureSensorDataToDB(strTime, strMoistureValue, status);
        }
        private void handleHumidity(string strData, string strTime, string ID)
        {
            float fHumiditiy = extractFlotValue(strData, ID);
            string strHum = extractStringValue(strData, ID);
            string status = "";
            if (fHumiditiy > 50)
                status = "Humid";
            else
                status = "Not Humid";
            Console.WriteLine(status);
            tb_Humidity.Text = status;

            saveHumSensorDataToDB(strTime, strHum);

        }
        private void handleDistance(string strData, string strTime, string ID)
        {
            int distFromPlant = Convert.ToInt32(extractFlotValue(strData, ID));
            int plantHeight = 300 - distFromPlant;
            string strplantHeight = plantHeight + " cm";
            tbHeight.Text = strplantHeight;
            Console.WriteLine(plantHeight);

            savePlantHeightToDB(strTime, strplantHeight);
        }
        private void extractSensorData(string strData, string strTime)
        {
            //Any type of data may be sent over by hardware
            //so you need to always check what data is received
            //before extracting the information

            //check whether temperature is sent
            if (strData.IndexOf("TEMP=") != -1)
                handleTempSensorData(strData, strTime, "TEMP=");
            if (strData.IndexOf("LIGHT=") != -1)
                handleLightSensorData(strData, strTime, "LIGHT=");
            if (strData.IndexOf("RFID=") != -1)
                handleRfidData(strData, strTime, "RFID=");
            if (strData.IndexOf("MOISTURE=") != -1)
                handleMoisture(strData, strTime, "MOISTURE=");
            if (strData.IndexOf("HUMIDITY=") != -1)
                handleHumidity(strData, strTime, "HUMIDITY=");
            if (strData.IndexOf("DISTANCE=") != -1)
                handleDistance(strData, strTime, "DISTANCE=");

            //else if (strData.IndexOf("BUTTON=") != -1) //check button status
            //    handleButtonData(strData, strTime, "BUTTON=");
        }

        //Raw data received from Hardware comes here
        public void handleSensorData(String strData)
        {
            string dt = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"); //get current time
            extractSensorData(strData, dt); //get sensor values out
            //update raw data received to listbox
            string strMessage = dt + ":" + strData;
            lbDataComms.Items.Insert(0, strMessage);
        }

        //This method is automatically called when data is received
        public void processDataReceive(String strData)
        {
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            lbDataComms.Invoke(d, new object[] { strData });
        }

        //This method is automatically called when data is received
        public void commsDataReceive(string dataReceived)
        {
            processDataReceive(dataReceived);
        }

        //This method is automatically called when there is error
        public void commsSendError(string errMsg)
        {
            MessageBox.Show(errMsg);
            processDataReceive(errMsg);
        }

        //This method must be called right at the start for data communications
        private void InitComms()
        {
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
            Console.WriteLine("Connected");
        }
        public SensorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitComms();
            //if (loggedin == false)
            //{
                
            //    fl.TopMost = true;
            //    fl.Show();    
            //}
          // backgroundWorker1.RunWorkerAsync();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void btnRFID_Click(object sender, EventArgs e)
        {
            dataComms.sendData("RFIDMODE");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbDataComms.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataComms.sendData("BUZZ");
        }

       

        private void btn_Dash_Click(object sender, EventArgs e)
        {
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            mainForm fm = new mainForm();
            fm.Show();

        }

        private void btnTempSettings_Click_1(object sender, EventArgs e)
        {
            TemperatureSettings settings = new TemperatureSettings();
            settings.Show();
          
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            fl.Show();
        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            bool rfidcheck = false;
            wr.Show();
            while (rfidcheck==false)
            { 
                if(rfid!="")
                {
                    Console.WriteLine(rfid);
                    Console.WriteLine("LOGIN FORM" + loginrfid);
                    if(rfid == loginrfid.Trim())
                    {
                        
                        rfidcheck = true;
                        wr.Close();

                    }
                }
            }
           
            Console.WriteLine("RESULTS"+rfidcheck);
            e.Result = rfidcheck;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        
    }
}
