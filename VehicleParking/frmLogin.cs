using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        MySqlConnection mysqlCon;

        public frmLogin()
        {
            InitializeComponent();
            

            objdb = new parkingEntities(GlobalVaraiable.EntityConnectionMysql());
            this.Hide();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            //Program.MysqlCon.Open();
           // GlobalVaraiable.EntityConnectionMysql();
            
            pk_users user = objdb.pk_users.SingleOrDefault(item => item.username == txtUsername.Text.Trim());

            if (user == null)
            {
                MessageBox.Show("Wrong Username or Password !!!");
            }
            else
            {
                if (user.password == txtPassword.Text)
                {
                    this.Hide();
                    frmMainForm frmMain = new frmMainForm();
                    frmMain.Visible = true;
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password !!!");
                }
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                //string path = "MysqlConnection.txt";
                //mysqlCon = new MySqlConnection();
                //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                //StreamReader reader = new StreamReader(fs);

                //string myConReader = reader.ReadToEnd();
                //mysqlCon.ConnectionString = myConReader;

                //mysqlCon = new MySqlConnection();
                //mysqlCon.Open();

                Program.MysqlCon.Open();
               
            }
            catch (MySqlException mysqlEx)
            {
                frmConfigurations cf = new frmConfigurations();
                cf.Show();
                this.Dispose();
                //this.SendToBack();
                //cf.BringToFront();
            }
        }
    }
}
