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
    public partial class frmVehicleParking : Form
    {
        public frmVehicleParking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainForm frm = new frmMainForm();
            //frm.setMenu(true);
            frm.setMenu(true);
            this.Dispose();
            
        }

        private void frmVehicleParking_Load(object sender, EventArgs e)
        {

        }
    }
}
