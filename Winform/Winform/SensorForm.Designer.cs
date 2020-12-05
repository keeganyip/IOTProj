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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTempSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRFID = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 517);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_Moisture);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_light);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbRFID);
            this.tabPage2.Controls.Add(this.lbDataComms);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.tbtemp);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sensor Values";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_Moisture
            // 
            this.tb_Moisture.Location = new System.Drawing.Point(561, 65);
            this.tb_Moisture.Name = "tb_Moisture";
            this.tb_Moisture.ReadOnly = true;
            this.tb_Moisture.Size = new System.Drawing.Size(181, 22);
            this.tb_Moisture.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Moisture:";
            // 
            // tb_light
            // 
            this.tb_light.Location = new System.Drawing.Point(212, 91);
            this.tb_light.Name = "tb_light";
            this.tb_light.ReadOnly = true;
            this.tb_light.Size = new System.Drawing.Size(181, 22);
            this.tb_light.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Light Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "RFID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(212, 122);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.ReadOnly = true;
            this.tbRFID.Size = new System.Drawing.Size(181, 22);
            this.tbRFID.TabIndex = 11;
            // 
            // lbDataComms
            // 
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.ItemHeight = 16;
            this.lbDataComms.Location = new System.Drawing.Point(97, 158);
            this.lbDataComms.Margin = new System.Windows.Forms.Padding(4);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(656, 260);
            this.lbDataComms.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(561, 91);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbtemp
            // 
            this.tbtemp.Location = new System.Drawing.Point(212, 65);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.ReadOnly = true;
            this.tbtemp.Size = new System.Drawing.Size(181, 22);
            this.tbtemp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temp:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTempSettings);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnRFID);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTempSettings
            // 
            this.btnTempSettings.Location = new System.Drawing.Point(116, 41);
            this.btnTempSettings.Name = "btnTempSettings";
            this.btnTempSettings.Size = new System.Drawing.Size(205, 88);
            this.btnTempSettings.TabIndex = 2;
            this.btnTempSettings.Text = "Temp Settings";
            this.btnTempSettings.UseVisualStyleBackColor = true;
            this.btnTempSettings.Click += new System.EventHandler(this.btnTempSettings_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "buZZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRFID
            // 
            this.btnRFID.Location = new System.Drawing.Point(155, 168);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(75, 23);
            this.btnRFID.TabIndex = 0;
            this.btnRFID.Text = "RFID";
            this.btnRFID.UseVisualStyleBackColor = true;
            this.btnRFID.Click += new System.EventHandler(this.btnRFID_Click);
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 589);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SensorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRFID;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_light;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Moisture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTempSettings;
    }
}

