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
            this.lbDataComms = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbtemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Dash = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.panelSensors = new System.Windows.Forms.Panel();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lbLiveStatus = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Humidity = new System.Windows.Forms.TextBox();
            this.lblHum = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.SideBar.SuspendLayout();
            this.panelSensors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Moisture
            // 
            this.tb_Moisture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_Moisture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Moisture.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Moisture.Location = new System.Drawing.Point(473, 66);
            this.tb_Moisture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Moisture.Name = "tb_Moisture";
            this.tb_Moisture.ReadOnly = true;
            this.tb_Moisture.Size = new System.Drawing.Size(137, 38);
            this.tb_Moisture.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LawnGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(475, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Moisture:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_light
            // 
            this.tb_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_light.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_light.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_light.Location = new System.Drawing.Point(247, 66);
            this.tb_light.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_light.Name = "tb_light";
            this.tb_light.ReadOnly = true;
            this.tb_light.Size = new System.Drawing.Size(137, 38);
            this.tb_light.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LawnGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(247, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Light Value:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbDataComms
            // 
            this.lbDataComms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbDataComms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDataComms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataComms.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.ItemHeight = 24;
            this.lbDataComms.Location = new System.Drawing.Point(539, 295);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(330, 122);
            this.lbDataComms.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LawnGreen;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(732, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 43);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbtemp
            // 
            this.tbtemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbtemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtemp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtemp.ForeColor = System.Drawing.SystemColors.Window;
            this.tbtemp.Location = new System.Drawing.Point(38, 66);
            this.tbtemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.ReadOnly = true;
            this.tbtemp.Size = new System.Drawing.Size(137, 38);
            this.tbtemp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temp:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SideBar.Controls.Add(this.btn_logout);
            this.SideBar.Controls.Add(this.label5);
            this.SideBar.Controls.Add(this.btn_Dash);
            this.SideBar.Controls.Add(this.btn_Settings);
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(218, 817);
            this.SideBar.TabIndex = 16;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_logout.FlatAppearance.BorderSize = 2;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(0, 356);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(218, 86);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.TabStop = false;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 141);
            this.label5.TabIndex = 2;
            this.label5.Text = "Smart Greenhouse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Dash
            // 
            this.btn_Dash.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Dash.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Dash.FlatAppearance.BorderSize = 2;
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
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Settings.FlatAppearance.BorderSize = 2;
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
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
            // panelSensors
            // 
            this.panelSensors.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSensors.Controls.Add(this.lbLiveStatus);
            this.panelSensors.Controls.Add(this.label2);
            this.panelSensors.Controls.Add(this.tb_Humidity);
            this.panelSensors.Controls.Add(this.lblHum);
            this.panelSensors.Controls.Add(this.tbtemp);
            this.panelSensors.Controls.Add(this.label1);
            this.panelSensors.Controls.Add(this.label4);
            this.panelSensors.Controls.Add(this.label3);
            this.panelSensors.Controls.Add(this.lbDataComms);
            this.panelSensors.Controls.Add(this.btnClear);
            this.panelSensors.Controls.Add(this.tb_Moisture);
            this.panelSensors.Controls.Add(this.tb_light);
            this.panelSensors.Location = new System.Drawing.Point(214, 144);
            this.panelSensors.Name = "panelSensors";
            this.panelSensors.Size = new System.Drawing.Size(883, 516);
            this.panelSensors.TabIndex = 17;
            // 
            // tbHeight
            // 
            this.tbHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeight.ForeColor = System.Drawing.SystemColors.Window;
            this.tbHeight.Location = new System.Drawing.Point(231, 56);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(137, 38);
            this.tbHeight.TabIndex = 21;
            // 
            // lbLiveStatus
            // 
            this.lbLiveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbLiveStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLiveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLiveStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lbLiveStatus.FormattingEnabled = true;
            this.lbLiveStatus.ItemHeight = 29;
            this.lbLiveStatus.Location = new System.Drawing.Point(17, 293);
            this.lbLiveStatus.Name = "lbLiveStatus";
            this.lbLiveStatus.Size = new System.Drawing.Size(330, 147);
            this.lbLiveStatus.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(17, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tb_Humidity
            // 
            this.tb_Humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_Humidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Humidity.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Humidity.Location = new System.Drawing.Point(705, 66);
            this.tb_Humidity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Humidity.Name = "tb_Humidity";
            this.tb_Humidity.Size = new System.Drawing.Size(137, 38);
            this.tb_Humidity.TabIndex = 18;
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.BackColor = System.Drawing.Color.LawnGreen;
            this.lblHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHum.ForeColor = System.Drawing.Color.Black;
            this.lblHum.Location = new System.Drawing.Point(704, 22);
            this.lblHum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(128, 31);
            this.lblHum.TabIndex = 17;
            this.lblHum.Text = "Humidity:";
            this.lblHum.Click += new System.EventHandler(this.lblHum_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LawnGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "PLANT HEIGHT:";
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.panelSensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SensorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.panelSensors.ResumeLayout(false);
            this.panelSensors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_light;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Moisture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button btn_Dash;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panelSensors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Humidity;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.Button btn_logout;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbLiveStatus;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label7;
    }
}

