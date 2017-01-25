using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleParking.Models;

namespace VehicleParking
{
    public partial class frmLogin : Form
    {
        parkingEntities objdb;
        public frmLogin()
        {
            InitializeComponent();
            objdb = new parkingEntities();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //tbluser user = objdb.tblusers.SingleOrDefault(item => item.username == txtUsername.Text);

            //if(user == null)
            //{
            //    MessageBox.Show("Wrong Username or Password !!!");
            //}
            //else
            //{
            //    if(user.password == txtPassword.Text)
            //    {
            //        this.Hide();
            //        frmMainForm frmMain = new frmMainForm();
            //        frmMain.Visible = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong Username or Password !!!");
            //    }
            //}
        }
    }
}
