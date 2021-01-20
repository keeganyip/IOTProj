namespace Winform
{
    partial class liveChartTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTest1 = new System.Windows.Forms.DataGridView();
            this.chartTest2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTest3 = new System.Windows.Forms.DataGridView();
            this.chartTest4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTest1
            // 
            this.chartTest1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartTest1.Location = new System.Drawing.Point(48, 13);
            this.chartTest1.Name = "chartTest1";
            this.chartTest1.Size = new System.Drawing.Size(240, 150);
            this.chartTest1.TabIndex = 0;
            // 
            // chartTest2
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTest2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTest2.Legends.Add(legend1);
            this.chartTest2.Location = new System.Drawing.Point(357, 13);
            this.chartTest2.Name = "chartTest2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTest2.Series.Add(series1);
            this.chartTest2.Size = new System.Drawing.Size(346, 300);
            this.chartTest2.TabIndex = 1;
            this.chartTest2.Text = "chart1";
            // 
            // chartTest3
            // 
            this.chartTest3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartTest3.Location = new System.Drawing.Point(48, 366);
            this.chartTest3.Name = "chartTest3";
            this.chartTest3.Size = new System.Drawing.Size(240, 150);
            this.chartTest3.TabIndex = 2;
            // 
            // chartTest4
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTest4.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTest4.Legends.Add(legend2);
            this.chartTest4.Location = new System.Drawing.Point(357, 366);
            this.chartTest4.Name = "chartTest4";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTest4.Series.Add(series2);
            this.chartTest4.Size = new System.Drawing.Size(346, 300);
            this.chartTest4.TabIndex = 3;
            this.chartTest4.Text = "chart1";
            // 
            // liveChartTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 623);
            this.Controls.Add(this.chartTest4);
            this.Controls.Add(this.chartTest3);
            this.Controls.Add(this.chartTest2);
            this.Controls.Add(this.chartTest1);
            this.Name = "liveChartTest";
            this.Text = "liveChartTest";
            this.Load += new System.EventHandler(this.liveChartTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chartTest1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest2;
        private System.Windows.Forms.DataGridView chartTest3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest4;
    }
}