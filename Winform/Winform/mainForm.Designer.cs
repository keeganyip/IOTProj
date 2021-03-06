﻿namespace Winform
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.panelMoisture = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMoisture = new System.Windows.Forms.Label();
            this.panelLight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLight = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.PnHumSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureboxhum = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMoisture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PnHumSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxhum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(902, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 45);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelTemp
            // 
            this.panelTemp.BackColor = System.Drawing.Color.LimeGreen;
            this.panelTemp.Controls.Add(this.label1);
            this.panelTemp.Controls.Add(this.pictureBox1);
            this.panelTemp.Controls.Add(this.lblTemperature);
            this.panelTemp.Location = new System.Drawing.Point(183, 121);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(248, 155);
            this.panelTemp.TabIndex = 1;
            this.panelTemp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTemp_Paint);
            this.panelTemp.DoubleClick += new System.EventHandler(this.panelTemp_DoubleClick);
            this.panelTemp.MouseLeave += new System.EventHandler(this.panelTemp_MouseLeave);
            this.panelTemp.MouseHover += new System.EventHandler(this.panelTemp_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sensor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(8, 18);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(169, 31);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature";
            // 
            // panelMoisture
            // 
            this.panelMoisture.BackColor = System.Drawing.Color.LimeGreen;
            this.panelMoisture.Controls.Add(this.label2);
            this.panelMoisture.Controls.Add(this.pictureBox2);
            this.panelMoisture.Controls.Add(this.lblMoisture);
            this.panelMoisture.Location = new System.Drawing.Point(589, 121);
            this.panelMoisture.Name = "panelMoisture";
            this.panelMoisture.Size = new System.Drawing.Size(248, 155);
            this.panelMoisture.TabIndex = 2;
            this.panelMoisture.DoubleClick += new System.EventHandler(this.panelMoisture_DoubleClick);
            this.panelMoisture.MouseLeave += new System.EventHandler(this.panelMoisture_MouseLeave);
            this.panelMoisture.MouseHover += new System.EventHandler(this.panelMoisture_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(167, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblMoisture
            // 
            this.lblMoisture.AutoSize = true;
            this.lblMoisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoisture.Location = new System.Drawing.Point(8, 18);
            this.lblMoisture.Name = "lblMoisture";
            this.lblMoisture.Size = new System.Drawing.Size(118, 31);
            this.lblMoisture.TabIndex = 1;
            this.lblMoisture.Text = "Moisture";
            // 
            // panelLight
            // 
            this.panelLight.BackColor = System.Drawing.Color.LimeGreen;
            this.panelLight.Controls.Add(this.label3);
            this.panelLight.Controls.Add(this.pictureBox3);
            this.panelLight.Controls.Add(this.lblLight);
            this.panelLight.Location = new System.Drawing.Point(589, 360);
            this.panelLight.Name = "panelLight";
            this.panelLight.Size = new System.Drawing.Size(248, 155);
            this.panelLight.TabIndex = 3;
            this.panelLight.DoubleClick += new System.EventHandler(this.panelLight_DoubleClick);
            this.panelLight.MouseLeave += new System.EventHandler(this.panelLight_MouseLeave);
            this.panelLight.MouseHover += new System.EventHandler(this.panelLight_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sensor";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(167, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(8, 18);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(73, 31);
            this.lblLight.TabIndex = 1;
            this.lblLight.Text = "Light";
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDash.Location = new System.Drawing.Point(10, 12);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(168, 45);
            this.btnDash.TabIndex = 4;
            this.btnDash.Text = "Back";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // PnHumSettings
            // 
            this.PnHumSettings.BackColor = System.Drawing.Color.LimeGreen;
            this.PnHumSettings.Controls.Add(this.label4);
            this.PnHumSettings.Controls.Add(this.pictureboxhum);
            this.PnHumSettings.Controls.Add(this.label5);
            this.PnHumSettings.Location = new System.Drawing.Point(183, 360);
            this.PnHumSettings.Name = "PnHumSettings";
            this.PnHumSettings.Size = new System.Drawing.Size(248, 155);
            this.PnHumSettings.TabIndex = 5;
            this.PnHumSettings.DoubleClick += new System.EventHandler(this.PnHumSettings_DoubleClick);
            this.PnHumSettings.MouseLeave += new System.EventHandler(this.PnHumSettings_MouseLeave);
            this.PnHumSettings.MouseHover += new System.EventHandler(this.PnHumSettings_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sensor";
            // 
            // pictureboxhum
            // 
            this.pictureboxhum.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxhum.Image")));
            this.pictureboxhum.Location = new System.Drawing.Point(167, 52);
            this.pictureboxhum.Name = "pictureboxhum";
            this.pictureboxhum.Size = new System.Drawing.Size(78, 81);
            this.pictureboxhum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxhum.TabIndex = 0;
            this.pictureboxhum.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Humidity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 595);
            this.Controls.Add(this.PnHumSettings);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.panelLight);
            this.Controls.Add(this.panelMoisture);
            this.Controls.Add(this.panelTemp);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.panelTemp.ResumeLayout(false);
            this.panelTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMoisture.ResumeLayout(false);
            this.panelMoisture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLight.ResumeLayout(false);
            this.panelLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PnHumSettings.ResumeLayout(false);
            this.PnHumSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxhum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Panel panelMoisture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMoisture;
        private System.Windows.Forms.Panel panelLight;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Panel PnHumSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureboxhum;
        private System.Windows.Forms.Label label5;
    }
}