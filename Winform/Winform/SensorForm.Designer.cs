namespace Winform
{
    partial class SensorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorForm));
            this.tb_Moisture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_light = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.lbDataComms = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbtemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Dash = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btnTempSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRFID = new System.Windows.Forms.Button();
            this.panelSensors = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panelSensors.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Moisture
            // 
            this.tb_Moisture.Enabled = false;
            this.tb_Moisture.Location = new System.Drawing.Point(25, 169);
            this.tb_Moisture.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Moisture.Name = "tb_Moisture";
            this.tb_Moisture.ReadOnly = true;
            this.tb_Moisture.Size = new System.Drawing.Size(137, 20);
            this.tb_Moisture.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Moisture:";
            // 
            // tb_light
            // 
            this.tb_light.Enabled = false;
            this.tb_light.Location = new System.Drawing.Point(25, 103);
            this.tb_light.Margin = new System.Windows.Forms.Padding(2);
            this.tb_light.Name = "tb_light";
            this.tb_light.ReadOnly = true;
            this.tb_light.Size = new System.Drawing.Size(137, 20);
            this.tb_light.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Light Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "RFID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(551, 82);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.ReadOnly = true;
            this.tbRFID.Size = new System.Drawing.Size(137, 20);
            this.tbRFID.TabIndex = 11;
            // 
            // lbDataComms
            // 
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.Location = new System.Drawing.Point(25, 417);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(493, 212);
            this.lbDataComms.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(382, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 43);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbtemp
            // 
            this.tbtemp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtemp.Enabled = false;
            this.tbtemp.Location = new System.Drawing.Point(25, 36);
            this.tbtemp.Margin = new System.Windows.Forms.Padding(2);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.ReadOnly = true;
            this.tbtemp.Size = new System.Drawing.Size(137, 20);
            this.tbtemp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temp:";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.YellowGreen;
            this.SideBar.Controls.Add(this.label5);
            this.SideBar.Controls.Add(this.btn_Dash);
            this.SideBar.Controls.Add(this.btn_Settings);
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(218, 817);
            this.SideBar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 141);
            this.label5.TabIndex = 2;
            this.label5.Text = "Smart Greenhouse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Dash
            // 
            this.btn_Dash.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Dash.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dash.Location = new System.Drawing.Point(0, 144);
            this.btn_Dash.Name = "btn_Dash";
            this.btn_Dash.Size = new System.Drawing.Size(218, 86);
            this.btn_Dash.TabIndex = 1;
            this.btn_Dash.TabStop = false;
            this.btn_Dash.Text = "Dashboard";
            this.btn_Dash.UseVisualStyleBackColor = false;
            this.btn_Dash.Click += new System.EventHandler(this.btn_Dash_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Location = new System.Drawing.Point(0, 247);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(218, 86);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.TabStop = false;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btnTempSettings
            // 
            this.btnTempSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempSettings.Location = new System.Drawing.Point(37, 9);
            this.btnTempSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnTempSettings.Name = "btnTempSettings";
            this.btnTempSettings.Size = new System.Drawing.Size(350, 206);
            this.btnTempSettings.TabIndex = 5;
            this.btnTempSettings.Text = "Temp Settings";
            this.btnTempSettings.UseVisualStyleBackColor = true;
            this.btnTempSettings.Click += new System.EventHandler(this.btnTempSettings_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "buZZ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRFID
            // 
            this.btnRFID.Location = new System.Drawing.Point(462, 16);
            this.btnRFID.Margin = new System.Windows.Forms.Padding(2);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(56, 19);
            this.btnRFID.TabIndex = 3;
            this.btnRFID.Text = "RFID";
            this.btnRFID.UseVisualStyleBackColor = true;
            // 
            // panelSensors
            // 
            this.panelSensors.BackColor = System.Drawing.Color.White;
            this.panelSensors.Controls.Add(this.tbtemp);
            this.panelSensors.Controls.Add(this.label1);
            this.panelSensors.Controls.Add(this.label4);
            this.panelSensors.Controls.Add(this.label3);
            this.panelSensors.Controls.Add(this.lbDataComms);
            this.panelSensors.Controls.Add(this.btnClear);
            this.panelSensors.Controls.Add(this.tb_Moisture);
            this.panelSensors.Controls.Add(this.tb_light);
            this.panelSensors.Location = new System.Drawing.Point(216, 144);
            this.panelSensors.Name = "panelSensors";
            this.panelSensors.Size = new System.Drawing.Size(838, 670);
            this.panelSensors.TabIndex = 17;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.White;
            this.panelSettings.Controls.Add(this.btnTempSettings);
            this.panelSettings.Controls.Add(this.btnRFID);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.button1);
            this.panelSettings.Controls.Add(this.tbRFID);
            this.panelSettings.Location = new System.Drawing.Point(204, 144);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(850, 734);
            this.panelSettings.TabIndex = 2;
            this.panelSettings.Visible = false;
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 815);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelSensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SensorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.panelSensors.ResumeLayout(false);
            this.panelSensors.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_light;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Moisture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button btn_Dash;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btnTempSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRFID;
        private System.Windows.Forms.Panel panelSensors;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label label5;
    }
}

