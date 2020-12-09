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
    public partial class TemperatureSettings : Form
    {

        string strConnectionString =
          ConfigurationManager.ConnectionStrings["Winform.Properties.Settings.UserdbConnectionString"].ConnectionString;

        public TemperatureSettings()
        {
            InitializeComponent();
            this.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string[] retrieveSetting()
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

            while(reader.Read())
            {
                max = reader["MaxTemp"].ToString().Trim();
                warn = reader["WarningTemp"].ToString().Trim();
            }
            string[] Settings = { max, warn };
            return Settings;

        }
        private void saveSettingsToDB(string Max, string Warning)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "UPDATE TEMPSETTINGS SET MaxTemp = @max, WarningTemp = @warn " +
                " WHERE Id = 1";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            //updateCmd.Parameters.AddWithValue("@time", strTime);
            //updateCmd.Parameters.AddWithValue("@value", strlightValue);
            //updateCmd.Parameters.AddWithValue("@status", strStatus);
            updateCmd.Parameters.AddWithValue("@max", Max);
            updateCmd.Parameters.AddWithValue("@warn", Warning);

            //Step 3: Open Connection
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close Connection
            myConnect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = 0;
            int warn = 0;
            max = Convert.ToInt32(tbMax.Text);
            warn = Convert.ToInt32(tbWarn.Text);
            if (max < warn)
                MessageBox.Show("Maxmium is higher than warning" + "\n Invalid Setting");
            else
            { 
                saveSettingsToDB(tbMax.Text, tbWarn.Text);
                this.Close();
            }
        }

        private void TemperatureSettings_Load(object sender, EventArgs e)
        {
            tbMax.Text = retrieveSetting()[0];
            tbWarn.Text = retrieveSetting()[1];
        }
    }
}
