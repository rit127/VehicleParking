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
                this.BringToFront();
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
        MySqlConnection mysqlCon;
        private void btnTestConnection_Click(object sender, EventArgs e)
        {

            mysqlCon = new MySqlConnection();
            try
            {
                if (!cbConnectionString.Checked)
                {
                    mysqlCon.ConnectionString = "server=" + txtHostName.Text + ";uid=" + txtUserName.Text + ";pwd=" + txtPassword.Text + ";database=" + txtDatabaseName.Text + ";";
                    mysqlCon.Open();
                    MessageBox.Show("Connectio Successful");
                }
                else if (cbConnectionString.Checked)
                {
                    mysqlCon.ConnectionString = txtConnectionString.Text;
                    mysqlCon.Open();
                    MessageBox.Show("Connectio Successful");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed Connections");
            }           
        }

        private void txtSaveConnection_Click(object sender, EventArgs e)
        {
            try
            {
                string StringConnection;
                FileStream fs = new FileStream("MysqlConnection.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                if (!cbConnectionString.Checked)
                {
                    StringConnection = "server=" + txtHostName.Text +";uid=" + txtUserName.Text + ";pwd=" + txtPassword.Text + ";database=" + txtDatabaseName.Text + ";";
                    sw.WriteLine(StringConnection);
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Save Successfully ^_^");
                    this.Close();
                    frmLogin login = new frmLogin();
                    login.Show();
                }
                else if(cbConnectionString.Checked)
                {
                    StringConnection = txtConnectionString.Text;
                    sw.WriteLine(StringConnection);
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Save Successfully ^_^");
                    this.Close();
                    frmLogin login = new frmLogin();
                    login.Show();
                }
                
                
            }
            catch (MySqlException ex)
            {

            }
        }
    }
}
