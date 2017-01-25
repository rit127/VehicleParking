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
            TabPage tp = tabControl1.TabPages[2];
            tabControl1.SelectedTab = tp;

            //if (uct == null)
            //{
            //    uct = new frmUserController();
            //    uct.MdiParent = this;
            //    uct.Show();
            //    uct.BringToFront();
            //}
            //else
            //{
            //    uct.BringToFront();
            //}

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
            //frmVehicleParking vcp = new frmVehicleParking();
            //vcp.MdiParent = this;
            //vcp.Show();

            TabPage tp = tabControl1.TabPages[1];
            tabControl1.SelectedTab = tp;

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
            //frmSetting fst = new frmSetting();
            //fst.MdiParent = this;
            //fst.Show();

            TabPage tp = tabControl1.TabPages[4];
            tabControl1.SelectedTab = tp;

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReport frp = new frmReport();
            //frp.MdiParent = this;
            //frp.Show();

            TabPage tp = tabControl1.TabPages[3];
            tabControl1.SelectedTab = tp;

        }

        //Setting Menu
        private void btnLogo_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl2.TabPages[0];
            tabControl2.SelectedTab = tp;
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl2.TabPages[1];
            tabControl2.SelectedTab = tp;
        }
    }
}
