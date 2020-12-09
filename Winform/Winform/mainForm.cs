using System;
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
        //private Button currentButton;
        //private Random random;
        //private int tempIndex;


        public mainForm()
        {
            InitializeComponent();
        }

        //private void ActivateButton(object btnSender)
        //{
        //    if (btnSender != null)
        //    {
        //        if (currentButton != (Button)btnSender)
        //        {
        //            DisableButton();
        //            currentButton = (Button)btnSender;
        //            currentButton.BackColor = Color.Green;
        //            currentButton.ForeColor = Color.White;
        //            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }
        //    }
        //}

        //private void DisableButton()
        //{
        //    foreach (Control previousBtn in panelMenu.Controls)
        //    {
        //        if (previousBtn.GetType() == typeof(Button))
        //        {
        //            previousBtn.BackColor = Color.ForestGreen;
        //            previousBtn.ForeColor = Color.Gainsboro;
        //            previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }
        //    }
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm fl = new loginForm();
            fl.Show();
        }
    }
}
