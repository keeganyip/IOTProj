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
    public partial class HumiditySettings : Form
    {

        string strConnectionString =
          ConfigurationManager.ConnectionStrings["Winform.Properties.Settings.UserdbConnectionString"].ConnectionString;

        public HumiditySettings()
        {
            InitializeComponent();
        }

        private void saveSettingsToDB(int Max, int Min)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "UPDATE HumiditySettings SET MaxHumidity = @max, MinHumidity = @min " +
                " WHERE Id = 1";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@max", Max);
            updateCmd.Parameters.AddWithValue("@min", Min);

            //Step 3: Open Connection
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close Connection
            myConnect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(tbMaxHum.Text);
            int min = Convert.ToInt32(tbMinHum.Text);
            if (min > max)
            {
                MessageBox.Show("Invalid Settings");
            }
            else
            {
                saveSettingsToDB(max, min);
                this.Close();
            }
        }

        public string[] retrieveSetting()
        {
            string max = "";
            string min = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "SELECT MaxHumidity,MinHumidity FROM HumiditySettings";

            //Step 3: Open Connection
            myConnect.Open();

            SqlCommand readcmd = new SqlCommand(strCommandText, myConnect);

            SqlDataReader reader = readcmd.ExecuteReader();

            while (reader.Read())
            {
                max = reader["MaxHumidity"].ToString().Trim();
                min = reader["MinHumidity"].ToString().Trim();
            }
            string[] Settings = { max, min };
            return Settings;

        }

        private void HumiditySettings_Load(object sender, EventArgs e)
        {
            tbMaxHum.Text = retrieveSetting()[0];
            tbMinHum.Text = retrieveSetting()[1];
        }
    }
}
