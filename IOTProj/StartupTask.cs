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
        Pin tempPin = Pin.AnalogPin0;

        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);

        double temp = 23;

        double sensorTemp;

        private void Sleep(int MS)
        {
            Task.Delay(MS).Wait();
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
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            // 
            // TODO: Insert code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //

            while (true)
            {
                Sleep(300);
                sensorTemp = getTemp();
                Debug.WriteLine("Temp in degrees Celsisus is " + sensorTemp.ToString("N2"));
            }
        }
    }
}
