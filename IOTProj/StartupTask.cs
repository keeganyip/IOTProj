using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;

using System.Diagnostics;
using System.Threading.Tasks;
using GrovePi;
using GrovePi.Sensors;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace IOTProj
{
    public sealed class StartupTask : IBackgroundTask
    {
        const int MODE_SENDTEMP = 1;
        const int MODE_RFID = 2;
        static int curMode;

        Pin tempPin = Pin.AnalogPin0;
        Pin lightPin = Pin.AnalogPin1;
        Pin waterPin = Pin.AnalogPin2;

        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);

        double temp = 23;
        double sensorTemp;
        //used by sensor for internal processing
        // 1023 : completely dry , more water : value will drop
        int moistureAdcValue = 1023;

        //This is or main logic controller to check for water moisture
        private int sensorMoistureAdcValue;


        DataComms datacomms;
        string strDataReceived = "";
        private static SerialComms uartComms;
        private static string strRfidDetected = ""; // check for RFID
        private void Sleep(int MS)
        {
            Task.Delay(MS).Wait();
        }
        static void uartDataHandler(object sender, SerialComms.UartEventArgs e)
        {
            strRfidDetected = e.data;
            //Debug.WriteLine("Card detected : " + strRfidDetected);
        }

        private void StartUart()
        {
            uartComms = new SerialComms();
            uartComms.UartEvent += new SerialComms.UartEventDelegate(uartDataHandler);
        }

        private int ReadTempADC(Pin pin)
        {
            sm.WaitOne();
            int val = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return val;
        }

        private double getTemp()
        {
            int adcValue; double tempCalculated = 0, R;

            adcValue = ReadTempADC(tempPin);

            int B = 4250, R0 = 100000;
            R = 100000 * (1023.0 - adcValue) / adcValue;
            tempCalculated = 1 / (Math.Log(R / R0) / B + 1 / 298.15) - 273.15;
            if (!Double.IsNaN(tempCalculated) && tempCalculated > 15 && tempCalculated < 40)
                temp = tempCalculated;

            return temp;
        }

        private int getMoisture()
        {
            int adcValue;

            sm.WaitOne();
            adcValue = DeviceFactory.Build.GrovePi().AnalogRead(waterPin);
            sm.Release();
            if (adcValue <= 1023)
                moistureAdcValue = adcValue;
            return moistureAdcValue;
        }//End of getMoisture()
        private void handleModeSendTemp()
        {
            int adcValue = 0;
            adcValue = GetLightValue(lightPin);
            Debug.WriteLine("Light ADC = " + adcValue);
            sendDataToWindows("TEMP=" + getTemp());
            sendDataToWindows("LIGHT=" + GetLightValue(lightPin));



            if (strDataReceived.Equals("RFIDMODE"))
            {
                curMode = MODE_RFID;
            }
            strDataReceived = "";
        }
        private void handleRFID()
        {
            if (!strRfidDetected.Equals(""))
            {
                if (strRfidDetected.Equals("6A003E7CF2DA"))
                {
                    Debug.WriteLine("Hi Emran :)");
                    sendDataToWindows("RFID=" + strRfidDetected);
                }
            }
        }
        private int GetLightValue(Pin pin)
        {
            sm.WaitOne();
            int value = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return value;
        }
        public void commsDataReceive(string dataReceived)
        {
            strDataReceived = dataReceived;
            Debug.WriteLine("Data Received : " + strDataReceived);
        }

        private void sendDataToWindows(string strDataOut)
        {
            try
            {
                datacomms.sendData(strDataOut);
                Debug.WriteLine("Sending Msg : " + strDataOut);
            }
            catch (Exception)
            {
                Debug.WriteLine("ERROR. DId u forget to initcomms()?");
            }
        }

        private void initcomms()
        {
            datacomms = new DataComms();
            datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
        }
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            // 
            // TODO: Insert code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //
            initcomms();
            StartUart();
            curMode = MODE_SENDTEMP;
           

            while (true)
            {
                Sleep(300);
                sensorTemp = getTemp();

                if (curMode == MODE_SENDTEMP)
                    handleModeSendTemp();
                else if (curMode == MODE_RFID)
                    handleRFID();

                sensorMoistureAdcValue = getMoisture(); //get moisture from sensor
                Debug.WriteLine("Moisture = " + sensorMoistureAdcValue);
                if (sensorMoistureAdcValue > 1000)
                    Debug.WriteLine("Dry");
                else if (sensorMoistureAdcValue < 100)
                    Debug.WriteLine("There is water pnding");
                else
                    Debug.WriteLine("Moderately Wet");

            }
        }
    }
}
