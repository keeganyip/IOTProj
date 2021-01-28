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
    public partial class WaterSettings : Form
    {
        string strConnectionString =
         ConfigurationManager.ConnectionStrings["Winform.Properties.Settings.UserdbConnectionString"].ConnectionString;
        public WaterSettings()
        {
            InitializeComponent();
        }

        public string retrieveSetting()
        {
            string current = "";
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
                current = reader["Threshold"].ToString().Trim();
            }
            return current;

        }

        private void saveSettingsToDB(string thresh)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "UPDATE WaterSettings SET Threshold = @thresh" +
                " WHERE ID = 1";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@thresh", thresh);

            //Step 3: Open Connection
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close Connection
            myConnect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSettingsToDB(tbActivation.Text);
        }

        private void WaterSettings_Load(object sender, EventArgs e)
        {
            tbActivation.Text = retrieveSetting();
        }
    }
}
