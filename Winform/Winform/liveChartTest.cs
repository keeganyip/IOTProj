using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace Winform
{
    public partial class liveChartTest : Form
    {
        string strConnectionString = ConfigurationManager.ConnectionStrings["LoginDBConnection"].ConnectionString;

        public liveChartTest()
        {
            InitializeComponent();
        }

        private void liveChartTest_Load(object sender, EventArgs e)
        {
            DisplayColumnAndCharts();
            DisplayPiewChartAndData();
        }

        private void DisplayColumnAndCharts()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandtext = "*INSERT SQL COMMAND HERE";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandtext, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                //use DataTable to store gridview <-- Change chartTest1
                DataTable dtTable = new DataTable();
                adapter.Fill(dtTable);
                //if there are records, then show in gridView
                if (dtTable.Rows.Count > 0) {
                    chartTest1.DataSource = dtTable;
                    //use dataset to store data for charts
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    chartTest2.DataSource = ds;
                    //Chart Title <-- Change chartTest2
                    chartTest2.Titles.Add("ChartTest2");
                    chartTest2.Series[0].ChartType = SeriesChartType.Column;
                    chartTest2.Series[0].XValueMember = "ChartTest2 x-axis";
                    chartTest2.Series[0].YValueMembers = "ChartTest2 y-axis";
                    //to show value on top bar graph
                    chartTest2.Series[0].IsValueShownAsLabel = true;
                    //no grid for column
                    chartTest2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    chartTest2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                    //disable legends
                    chartTest2.Legends[0].Enabled = false;
                }
                else
                {
                    MessageBox.Show("There are no records in database");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }
        }

        private void DisplayPiewChartAndData()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT SQL COMMAND HERE";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataTable dtTable = new DataTable();
                adapter.Fill(dtTable);
                if (dtTable.Rows.Count > 0)
                {
                    chartTest3.DataSource = dtTable;
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    chartTest4.DataSource = ds;
                    //Chart title
                    chartTest4.Titles.Add("chartTest4");
                    //Chart to appear in pie form (chartTable4)
                    chartTest4.Series[0].ChartType = SeriesChartType.Pie;
                    chartTest4.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chartTest4.Series[0].XValueMember = "chartTest4 x-axis"; //<-- Change x-avis value
                    chartTest4.Series[0].YValueMembers = "chartTest4 y-axis"; //<-- Change y-value axis
                    chartTest4.Series[0].IsValueShownAsLabel = true;
                    //To show percentage
                    chartTest4.Series[0].Label = "#PERCENT\n#VALY";
                    //Enable legend based on data in x-axis
                    chartTest4.Series[0].LegendText = "#VALX";
                }
                else
                {
                    MessageBox.Show("There are no records in the databse");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }
        }

    }
}
