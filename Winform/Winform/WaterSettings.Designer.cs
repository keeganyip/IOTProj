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
            this.lblActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActivate.Location = new System.Drawing.Point(11, 47);
            this.lblActivate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivate.Name = "lblActivate";
            this.lblActivate.Size = new System.Drawing.Size(156, 20);
            this.lblActivate.TabIndex = 0;
            this.lblActivate.Text = "Activation Threshold:";
            // 
            // tbActivation
            // 
            this.tbActivation.Location = new System.Drawing.Point(213, 47);
            this.tbActivation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbActivation.Name = "tbActivation";
            this.tbActivation.Size = new System.Drawing.Size(116, 20);
            this.tbActivation.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(88, 91);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WaterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(356, 161);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbActivation);
            this.Controls.Add(this.lblActivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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