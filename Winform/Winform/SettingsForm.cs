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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm fl = new mainForm();
            fl.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm fl = new mainForm();
            fl.Show();
        }
    }
}
