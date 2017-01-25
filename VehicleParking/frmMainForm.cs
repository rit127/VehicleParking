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
    public partial class frmMainForm : Form
    {
        
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        frmUserController uct = null;
        private void userControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uct == null)
            {
                uct = new frmUserController();
                uct.MdiParent = this;
                uct.Show();
                uct.BringToFront();
            }
            else
            {
                uct.BringToFront();
            }

            //GlobalVaraiable.dis = true;

            //if(GlobalVaraiable.dis == true)
            //{
            //    uct = new frmUserController();
            //    uct.MdiParent = this;
            //    uct.WindowState = FormWindowState.Maximized;
            //    uct.Show();
            //}
            //else
            //{
            //    uct.BringToFront();
            //}

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setMenu(bool tf)
        {
            vehicleParkingToolStripMenuItem.Enabled = tf;
        }
        private void vehicleParkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //setMenu(false);
            frmVehicleParking vcp = new frmVehicleParking();
            vcp.MdiParent = this;
            vcp.Show();

            
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            this.dateToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting fst = new frmSetting();
            fst.MdiParent = this;
            fst.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frp = new frmReport();
            frp.MdiParent = this;
            frp.Show();
        }
    }
}
