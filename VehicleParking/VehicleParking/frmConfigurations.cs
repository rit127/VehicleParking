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
    public partial class frmConfigurations : Form
    {
        public frmConfigurations()
        {
            InitializeComponent();
        }

        private void frmConfigurations_Load(object sender, EventArgs e)
        {
            txtConnectionString.Enabled = false;
        }
        void setEnable (bool ck)
        {
            txtDatabaseName.Enabled = ck;
            txtHostName.Enabled = ck;
            txtUserName.Enabled = ck;
            txtPassword.Enabled = ck; 
        }
        private void cbConnectionString_CheckedChanged(object sender, EventArgs e)
        {
            if(cbConnectionString.Checked)
            {
                txtConnectionString.Enabled = true;
                setEnable(false);
                txtConnectionString.Focus();
            }
            else
            {
                txtConnectionString.Enabled = false;
                setEnable(true);
                txtDatabaseName.Focus();
            }
        }
    }
}
