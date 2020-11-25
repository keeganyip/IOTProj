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

namespace Winform
{
    public partial class Form1 : Form
    {

        //string strConnectionString =
        //   ConfigurationManager.ConnectionStrings["DataCommsDBConnection"].ConnectionString;

        DataComms dataComms;

        public delegate void myprocessDataDelegate(String strData);

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
            string strtempValue = extractStringValue(strData, ID);
            string temp = strtempValue.Substring(0,5) + "°C";
            //update GUI component in any tabs
            tbtemp.Text = temp;

           /* float fLightValue = extractFlotValue(strData, ID);
            string status = "";
            if (fLightValue <= 500)
                status = "Dark";
            else
                status = "Bright";
            tbRoomStatus.Text = status; */

            //update database
            //saveLightSensorDataToDB(strTime, strlightValue, status);
        }
        private void handleLightSensorData(string strData, string strTime, string ID)
        {
            string strlightValue = extractStringValue(strData, ID);
            //update GUI component in any tabs
            //tb_light.Text = strlightValue;

            float fLightValue = extractFlotValue(strData, ID);
            string status = "";
            if (fLightValue <= 500)
                 status = "Dark";
            else
                 status = "Bright";
             tb_light.Text = status;

            //update database
            //saveLightSensorDataToDB(strTime, strlightValue, status);
        }
        private void handleRfidData(string strData, string strTime, string ID)
        {
            string strRFID = extractStringValue(strData, ID);
            //update GUI component in any tabs
            tbRFID.Text = strRFID;

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
            else if (strData.IndexOf("RFID=") != -1)
                handleRfidData(strData, strTime, "RFID=");

            //else if (strData.IndexOf("BUTTON=") != -1) //check button status
            //    handleButtonData(strData, strTime, "BUTTON=");
        }

        //Raw data received from Hardware comes here
        public void handleSensorData(String strData)
        {
            string dt = DateTime.Now.ToString("s"); //get current time
            extractSensorData(strData, dt); //get sensor values out
            Console.WriteLine(strData);
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitComms();
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
    }
}
