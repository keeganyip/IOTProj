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
    public partial class LightSettings : Form
    {

        string strConnectionString =
          ConfigurationManager.ConnectionStrings["Winform.Properties.Settings.UserdbConnectionString"].ConnectionString;

        public LightSettings()
        {
            InitializeComponent();
        }

        private void saveSettingsToDB(int Min)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "UPDATE LightSettings SET MinLight = @min " +
                " WHERE Id = 1";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@min", Min);

            //Step 3: Open Connection
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close Connection
            myConnect.Close();
        }

        public string retrieveSetting()
        {
            string min = "";
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create Command
            String strCommandText =
                "SELECT MinLight FROM LightSettings";

            //Step 3: Open Connection
            myConnect.Open();

            SqlCommand readcmd = new SqlCommand(strCommandText, myConnect);

            SqlDataReader reader = readcmd.ExecuteReader();

            while (reader.Read())
            {
                min = reader["MinLight"].ToString().Trim();
            }
            return min;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(txtLightReq.Text);
            saveSettingsToDB(min);
            this.Close();
        }

        private void LightSettings_Load(object sender, EventArgs e)
        {
            txtLightReq.Text = retrieveSetting();
        }
    }
}
