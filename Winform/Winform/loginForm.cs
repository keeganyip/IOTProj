﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace Winform
{
    public partial class loginForm : Form
    {
        public string rfid = "";
        //retrieve connection information from App.Config
        private string strConnectionString =
            ConfigurationManager.ConnectionStrings["Winform.Properties.Settings.UserdbConnectionString"].ConnectionString;
        DataComms dataComms;
        public delegate void myprocessDataDelegate(String strData);
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }

        private void extractSensorData(string strData, string strTime)
        {
            if (strData.IndexOf("RFID=") != -1)
                handleRFIDData(strData, "RFID=");
        }
        private string handleRFIDData(string strData, string ID)
        {
            string strRFID = extractStringValue(strData,ID);
            return strRFID;
        }
        //public void handleSensorData(String strData)
        //{
        //    string dt = DateTime.Now.ToString("s"); //get current time
        //    //extractSensorData(strData, dt); //get sensor values out
        //    rfid = handleRFIDData(strData, "RFID=");
        //    Debug.WriteLine(rfid);
        //    string strMessage = dt + ":" + strData;
        //    //lbDataComms.Items.Insert(0, strMessage);
        //}

        ////This method is automatically called when data is received
        //public void processDataReceive(String strData)
        //{
        //    myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
        //    //lbDataComms.Invoke(d, new object[] { strData });
        //}
        ////This method is automatically called when data is received
        //public void commsDataReceive(string dataReceived)
        //{
        //    processDataReceive(dataReceived);
        //}

        ////This method is automatically called when there is error
        //public void commsSendError(string errMsg)
        //{
        //    MessageBox.Show(errMsg);
        //    processDataReceive(errMsg);
        //}

        //private void InitComms()
        //{
        //    dataComms = new DataComms();
        //    dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
        //    dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        //    Console.WriteLine();
        //}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Step 1: Open Connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            string strCommandText = "SELECT Email, Password, UniqueRFID FROM UserTable";
            //Add a WHERE clause to SQL Statement
            strCommandText += " WHERE Email=@Email AND Password=@Password";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@Email", tbUserName.Text);
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

            try
            {
                //Step 3: Open Connection and Retrieve Data by calling ExecuteReader
                myConnect.Open();

                //Step 4: Access Data
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SensorForm fm = new SensorForm();
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    
                    fm.loginrfid = reader.GetString(2);
                    Console.WriteLine(rfid);
                    fm.Show();
                    fm.backgroundWorker1.RunWorkerAsync();

                }
                else
                    MessageBox.Show("Login Fail");

                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }

            finally
            {
                //Step 5: Close Connection
                myConnect.Close();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}