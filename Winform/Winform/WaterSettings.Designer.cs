namespace Winform
{
    partial class WaterSettings
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
            this.lblActivate = new System.Windows.Forms.Label();
            this.tbActivation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActivate
            // 
            this.lblActivate.AutoSize = true;
            this.lblActivate.Location = new System.Drawing.Point(31, 35);
            this.lblActivate.Name = "lblActivate";
            this.lblActivate.Size = new System.Drawing.Size(141, 17);
            this.lblActivate.TabIndex = 0;
            this.lblActivate.Text = "Activation Threshold:";
            // 
            // tbActivation
            // 
            this.tbActivation.Location = new System.Drawing.Point(34, 55);
            this.tbActivation.Name = "tbActivation";
            this.tbActivation.Size = new System.Drawing.Size(138, 22);
            this.tbActivation.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WaterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 132);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbActivation);
            this.Controls.Add(this.lblActivate);
            this.Name = "WaterSettings";
            this.Text = "WaterSettings";
            this.Load += new System.EventHandler(this.WaterSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivate;
        private System.Windows.Forms.TextBox tbActivation;
        private System.Windows.Forms.Button btnSave;
    }
}