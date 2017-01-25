using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleParking
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl1.TabPages[0];
            tabControl1.SelectedTab = tp;
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl1.TabPages[1];
            tabControl1.SelectedTab = tp;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
