using MySql.Data.MySqlClient;
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
    public partial class frmMainForm : Form
    {
        parkingsEntities objdb;
        public frmMainForm()
        {
            InitializeComponent();

            objdb = new parkingsEntities(GlobalVaraiable.EntityConnectionMysql());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl1.TabPages[1];
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
            Program.MysqlCon.Close();
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

            TabPage tp = tabControl1.TabPages[0];
            tabControl1.SelectedTab = tp;

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //Tab User
        void setGroupBoxEnable(bool tf)
        {
            txtUsername.Enabled = tf;
            txtPassword.Enabled = tf;
            txtConfirmPass.Enabled = tf;
            comboRole.Enabled = tf;
        }

        void setButtomUserEnable(bool tf)
        {
            btnEditUser.Enabled = tf;
            btnDeleteUser.Enabled = tf;
            btnResetUser.Enabled = tf;
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            this.dateToolStripMenuItem.Text = DateTime.Now.ToString();

            //Tab User
            List<pk_users> user = objdb.pk_users.ToList();
            foreach(var item in user)
            {
                dataGridUser.Rows.Add(item.username, item.activate, item.date_register, item.phone, item.role, item.last_login);
            }
            setGroupBoxEnable(false);
            setButtomUserEnable(false);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSetting fst = new frmSetting();
            //fst.MdiParent = this;
            //fst.Show();

            TabPage tp = tabControl1.TabPages[3];
            tabControl1.SelectedTab = tp;

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReport frp = new frmReport();
            //frp.MdiParent = this;
            //frp.Show();

            TabPage tp = tabControl1.TabPages[2];
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


        //User Menu
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if(btnNewUser.Text.Equals("New"))
            {
                btnNewUser.Text = "Create";
                setGroupBoxEnable(true);
                txtUsername.Focus();
                btnEditUser.Enabled = true;
                btnEditUser.Text = "Cancel";
                
            }
            else if(btnNewUser.Text.Equals("Create"))
            {
                try
                {
                    pk_users user = new pk_users();

                    if (txtPassword.Text == txtConfirmPass.Text)
                    {
                        
                        user.username = txtUsername.Text;
                        user.password = txtPassword.Text;
                        user.role = comboRole.Text;
                        user.activate = true;
                        user.active = false;                        
                        
                        user.date_register = DateTime.Now;
                        user.last_login = DateTime.Now;
                        
                        objdb.pk_users.Add(user);
                        objdb.SaveChanges();                        
                        MessageBox.Show("Create User Successfully!!!");
                        //LoadToGrid();

                    }
                }
                catch(MySqlException mysqlEx)
                {

                }
                btnNewUser.Text = "New";

            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if(btnEditUser.Text.Equals("Cancel"))
            {
                btnNewUser.Text = "New";
                btnEditUser.Text = "Edit";
                btnEditUser.Enabled = false;
                btnEditUser.Text = "Update";
                setGroupBoxEnable(false);
                
            }
            else if (btnEditUser.Text.Equals("Update"))
            {
                try
                {
                    pk_users user = new pk_users();
                    objdb.pk_users.First(i => i.Id == user.Id);

                    user.username = txtUsername.Text;
                    user.password = txtPassword.Text;
                    user.password = txtConfirmPass.Text;
                    user.role = comboRole.Text;

                    objdb.SaveChanges();
                    MessageBox.Show("Update Successfully!!!");
                }
                catch (MySqlException mysqlEx)
                {

                }
                btnEditUser.Text = "Edit";
            }
        }

        private void LoadToGrid()
        {

        }        
    }
}
