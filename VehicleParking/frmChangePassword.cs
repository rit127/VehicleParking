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
    public partial class frmChangePassword : Form
    {
        parkingsEntities objdb;
        public frmChangePassword()
        {
            InitializeComponent();
            objdb = new parkingsEntities(GlobalVaraiable.EntityConnectionMysql());
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentUser = GlobalVaraiable.Username;
            if(currentUser == null)
            {

            }
            else
            {
                string Currentpassword = txtOldPassword.Text.Trim();
                pk_users user = objdb.pk_users.First(u => u.username == currentUser);
                if( Currentpassword.Equals(user.password))
                {
                    if(txtNewPassword.Text.Trim() == txtComfirmPassword.Text.Trim())
                    {
                        user.password = txtNewPassword.Text.Trim();
                        objdb.SaveChanges();
                        MessageBox.Show("Your Password Changed Complete !!");
                        txtOldPassword.Text = null;
                        txtNewPassword.Text = null;
                        txtComfirmPassword.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Your Comfirm Password Don't Match");
                    }
                }
                else
                {

                }
            }
        }
    }
}
