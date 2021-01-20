namespace Winform
{
    partial class HumiditySettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxHum = new System.Windows.Forms.TextBox();
            this.tbMinHum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Humidity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Humidity:";
            // 
            // tbMaxHum
            // 
            this.tbMaxHum.Location = new System.Drawing.Point(161, 146);
            this.tbMaxHum.Name = "tbMaxHum";
            this.tbMaxHum.Size = new System.Drawing.Size(100, 22);
            this.tbMaxHum.TabIndex = 2;
            // 
            // tbMinHum
            // 
            this.tbMinHum.Location = new System.Drawing.Point(161, 102);
            this.tbMinHum.Name = "tbMinHum";
            this.tbMinHum.Size = new System.Drawing.Size(100, 22);
            this.tbMinHum.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HumiditySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 332);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMinHum);
            this.Controls.Add(this.tbMaxHum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HumiditySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Humidity";
            this.Load += new System.EventHandler(this.HumiditySettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaxHum;
        private System.Windows.Forms.TextBox tbMinHum;
        private System.Windows.Forms.Button btnSave;
    }
}