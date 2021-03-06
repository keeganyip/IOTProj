﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
     
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm fl = new loginForm();
            fl.Show();
        }

        //Temperature Panel Settings
        private void panelTemp_MouseHover(object sender, EventArgs e)
        {
            panelTemp.BackColor = Color.LimeGreen;
        }

        private void panelTemp_MouseLeave(object sender, EventArgs e)
        {
            panelTemp.BackColor = Color.ForestGreen;
        }

        private void panelTemp_DoubleClick(object sender, EventArgs e)
        {
            TemperatureSettings fm = new TemperatureSettings();
            fm.Show();
        }

        //Moisture Panel Settings
        private void panelMoisture_MouseHover(object sender, EventArgs e)
        {
            panelMoisture.BackColor = Color.LimeGreen;
        }

        private void panelMoisture_MouseLeave(object sender, EventArgs e)
        {
            panelMoisture.BackColor = Color.ForestGreen;
        }

        private void panelMoisture_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            WaterSettings fm = new WaterSettings();
            fm.Show();
        }

        //Light Panel Settings
        private void panelLight_MouseHover(object sender, EventArgs e)
        {
            panelLight.BackColor = Color.LimeGreen;
        }

        private void panelLight_MouseLeave(object sender, EventArgs e)
        {
            panelLight.BackColor = Color.ForestGreen;
        }

        private void panelLight_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            LightSettings ls = new LightSettings();
            ls.Show();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelTemp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PnHumSettings_DoubleClick(object sender, EventArgs e)
        {
            HumiditySettings hs = new HumiditySettings();
            hs.Show();
        }

        private void PnHumSettings_MouseHover(object sender, EventArgs e)
        {
            PnHumSettings.BackColor = Color.LimeGreen;
        }

        private void PnHumSettings_MouseLeave(object sender, EventArgs e)
        {
            PnHumSettings.BackColor = Color.ForestGreen;
        }
    }
}