using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleParking.AppSocket;
using VehicleParking.Models;

namespace VehicleParking
{
    public partial class frmMainForm : Form
    {
        parkingsEntities objdb;
        private readonly Listener listener;

        public List<Socket> clients = new List<Socket>(); // store all the clients into a list

        public void BroadcastData(string data) // send to all clients
        {
            foreach (var socket in clients)
            {
                try { socket.Send(Encoding.ASCII.GetBytes(data)); }
                catch (Exception) { }
            }
        }

        private void listener_SocketAccepted(Socket e)
        {
            var client = new Client(e);
            client.Received += client_Received;
            client.Disconnected += client_Disconnected;
       
            this.Invoke(new Action(() => {
                string ip = client.Ip.ToString().Split(':')[0];

                //item.Tag = client;
                //clientList.Items.Add(item);
                clients.Add(e);
                Console.WriteLine("listener_SocketAccepted");
            }));
        }

        private void client_Disconnected(Client sender)
        {

            this.Invoke(new Action(() => {
                Console.WriteLine("client_Disconnected");
            }));
            /*this.Invoke(() =>
            {
                for (int i = 0; i < clientList.Items.Count; i++)
                {
                    var client = clientList.Items[i].Tag as Client;
                    if (client.Ip == sender.Ip)
                    {
                       /* txtReceive.Text += "<< " + clientList.Items[i].SubItems[1].Text + " has left the room >>\r\n";
                        BroadcastData(HCTextCmd.RefreshChat + "|" + txtReceive.Text);
                        clientList.Items.RemoveAt(i);
                    }
                }
            });*/
        }

       

        private void client_Received(Client sender, byte[] data)
        {
         
            this.Invoke(new Action(() =>
            {
                var command = Encoding.ASCII.GetString(data);
               
                //Console.WriteLine(client.Ip);
                Console.WriteLine(command+ "-" + sender.Ip);

                //label13.Text = "client_Received";
                /*
                for (int i = 0; i < clientList.Items.Count; i++)
                {
                    var client = clientList.Items[i].Tag as Client;
                    if (client == null || client.Ip != sender.Ip) continue;

                    var command = Encoding.ASCII.GetString(data);
                    Console.WriteLine(client.Ip);
                    Console.WriteLine(command);
                    //var cmd = command[0];
                    //BroadcastData(HCTextCmd.Users + "|" + users.TrimEnd('|'));
                    //BroadcastData(HCTextCmd.RefreshChat + "|" + txtReceive.Text);
                    
                }*/
            }));
        }


        public frmMainForm()
        {
            InitializeComponent();

            objdb = new parkingsEntities(GlobalVaraiable.EntityConnectionMysql());
            listener = new Listener(1000);
            listener.SocketAccepted += listener_SocketAccepted;
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
            txtTel.Enabled = tf;
            comboRole.Enabled = tf;
        }

        void setTextBoxUserToNull()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            txtTel.Text = "";
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            dateToolStripMenuItem.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void getCamera()
        {
            try
            {
                ImageViewer viewer = new ImageViewer();
                Capture capture = new Capture("rtsp://admin:123456@172.16.101.224:554/live/ch1"); //create a camera captue
                Application.Idle += new EventHandler(delegate (object senders, EventArgs ee)
                {  //run this until application closed (close button click on image viewer)
                    try
                    {
                        
                        var c = capture.QuerySmallFrame();
                        if (c == null)
                        {
                            return;
                           // capture.Stop();
                           // capture.Start();
                        }
                        else
                        {
                            viewer.Image = c;//draw the image obtained from camera               
                            picLiveCamOut.Image = viewer.Image.Bitmap;
                        }

                    }
                    catch (Exception ex)
                    {
                        //Thread.Sleep(5000);
                        viewer.Image = capture.QueryFrame();//draw the image obtained from camera               
                        picLiveCamOut.Image = viewer.Image.Bitmap;
                    }

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {

            //listener.Start();


            this.asToolStripMenuItem.Text = GlobalVaraiable.Username;
            comboRole.SelectedIndex = 1;
            //Set Time Clock
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();

            //Tab User
            List<pk_users> user = objdb.pk_users.ToList();
            foreach(var item in user)
            {
                dataGridUser.Rows.Add(item.username, item.role, item.phone, item.last_login , item.activate , "Reset");
            }
            dataGridUser.ClearSelection();

            //Tab Price
            var price = objdb.pk_config_log.ToList();
            foreach (var item in price)
            {
                dataGridVehiclePrice.Rows.Add(item.Id, item.key, item.value, item.update_date);
            }
            dataGridVehiclePrice.Sort(this.Id, ListSortDirection.Descending);


            //Live Cam
            getCamera();
            


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
            if(btnNewUser.Text.Equals("Save"))
            {
                try
                {
                    pk_users user = new pk_users();
                    if (txtUsername.Text.Trim().Equals("") || txtUsername.Text.Trim().Count() < 5)
                    {
                        MessageBox.Show("Please Input Username and Username is more that 5 character");
                        txtUsername.Focus();
                    }
                    else if(txtPassword.Text.Trim().Equals("") /*|| txtPassword.Text.Trim().Count() < 5*/)
                    {
                        MessageBox.Show("Please Input Password");
                        txtPassword.Focus();
                    }
                    else if(txtConfirmPass.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please Input Comfrim Password");
                        txtConfirmPass.Focus();
                    }
                    else
                    {
                        if(!txtConfirmPass.Text.Equals(txtPassword.Text))
                        {
                            MessageBox.Show("Your Confirm Password not match");
                            txtConfirmPass.Focus();
                        }
                        else
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
                            dataGridUser.Rows.Add(user.username, user.role, user.phone,  user.last_login , user.activate);
                            MessageBox.Show("Create User Successfully!!!");
                            setTextBoxUserToNull();
                        }
                    }                                       
                }
                catch (MySqlException mysqlEx)
                {

                }
            }
            else
            {
                try
                {
                    if (txtPassword.Text == txtConfirmPass.Text)
                    {
                        int i = dataGridUser.SelectedRows[0].Index;
                        DataGridViewRow dgv = dataGridUser.Rows[i];
                        string dgvusername = dgv.Cells[0].Value.ToString();
                        var user = objdb.pk_users.First(z => z.username == dgvusername);
                        if (txtPassword.Text == txtConfirmPass.Text)
                        {
                            //Update Row Selected to Database
                            user.username = txtUsername.Text;
                            user.password = txtPassword.Text;
                            user.phone = txtTel.Text;
                            user.role = comboRole.Text;
                            user.activate = true;
                            objdb.SaveChanges();

                            //Update to DataGrid
                            dataGridUser.Rows[i].SetValues(user.username, user.role, user.phone, user.last_login, user.activate);

                            //Set Enable DataGrid
                            dataGridUser.Enabled = true;
                            //Set Group Box Value to Null
                            setTextBoxUserToNull();
                            btnNewUser.Text = "Save";
                            MessageBox.Show("Update Complete");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your password is not match !! ");
                    }
                }
                catch (MySqlException mysqlEx)
                {

                }
            }
            //    if (btnNewUser.Text.Equals("New"))
            //    {
            //        btnNewUser.Text = "Create";
            //        setTextBoxUserToNull();
            //        setGroupBoxEnable(true);
            //        txtUsername.Focus();
            //        btnEditUser.Enabled = true;
            //        btnDeleteUser.Enabled = false;
            //        btnResetUser.Enabled = false;
            //        btnEditUser.Text = "Cancel";

                //    }
                //    else if (btnNewUser.Text.Equals("Create"))
                //    {
                //        try
                //        {
                //            pk_users user = new pk_users();

                //            if (txtPassword.Text == txtConfirmPass.Text)
                //            {
                //                user.username = txtUsername.Text;
                //                user.password = txtPassword.Text;
                //                user.role = comboRole.Text;
                //                user.activate = true;
                //                user.active = false;

                //                user.date_register = DateTime.Now;
                //                user.last_login = DateTime.Now;

                //                objdb.pk_users.Add(user);
                //                objdb.SaveChanges();
                //                dataGridUser.Rows.Add(user.username, user.activate, user.date_register, user.phone, user.role, user.last_login);

                //                btnEditUser.Text = "Edit";
                //                btnEditUser.Enabled = false;
                //                MessageBox.Show("Create User Successfully!!!");
                //                setTextBoxUserToNull();
                //                setGroupBoxEnable(false);
                //                btnNewUser.Text = "New";
                //                //LoadToGrid();

                //            }
                //            else if (txtPassword.Text != txtConfirmPass.Text)
                //            {
                //                MessageBox.Show("Your Comfirm Password Not Match");
                //                txtConfirmPass.Focus();
                //            }
                //            else if (txtUsername.Text == null && txtPassword.Text == null && txtConfirmPass.Text == null && comboRole.Text == null)
                //            {
                //                MessageBox.Show("Please Fill the empty Field");
                //            }
                //        }
                //        catch (MySqlException mysqlEx)
                //        {

                //        }

                //    }
                //    else if (btnNewUser.Text == "Cancel")
                //    {
                //        btnNewUser.Text = "New";
                //        btnEditUser.Text = "Edit";
                //        setButtomUserEnable(false);
                //        setTextBoxUserToNull();
                //        setGroupBoxEnable(false);
                //        dataGridUser.Enabled = true;
                //    }
                //    else if (btnNewUser.Text == "Clear")
                //    {
                //        btnNewUser.Text = "New";
                //        setTextBoxUserToNull();
                //        setButtomUserEnable(false);
                //    }
                //
            }

        private void LoadToGrid()
        {

        }

        private void eXToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNewUser.Text = "Update";
            int i = dataGridUser.SelectedRows[0].Index;
            DataGridViewRow dgv = dataGridUser.Rows[i];
            string dgvusername = dgv.Cells[0].Value.ToString();
            var user = objdb.pk_users.First(z => z.username == dgvusername);

            try
            {
                //Get Data From DataGrid to TextBox for Edit
                txtUsername.Text = dgv.Cells[0].Value.ToString();
                txtPassword.Text = user.password;
                txtConfirmPass.Text = user.password;
                              
                comboRole.Text = dgv.Cells[1].Value.ToString();
                txtTel.Text = dgv.Cells[2].Value.ToString();
               
            }catch(Exception ex)
            {
                txtTel.Text = "";
            }


        }

        private void dataGridUser_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearchUser_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchUser.Text;
            if(search =="")
            {
                dataGridUser.Rows[0].Cells[0].Selected = true;
            }
            for (int i = 0; i < (dataGridUser.Rows.Count); i++)
            {
                if (dataGridUser.Rows[i].Cells["Column1"].Value.ToString().StartsWith(search, true, CultureInfo.InvariantCulture))
                {
                    dataGridUser.Rows[i].Cells[0].Selected = true;
                    return; // stop looping
                }
                else
                {
                    dataGridUser.ClearSelection();
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dataGridReport.Rows.Clear();
            string FromDate = dtpFromDate.Value.ToShortDateString();
            string ToDate = dtpToDate.Value.ToShortDateString();

            List<pk_vehicle_out> report = objdb.pk_vehicle_out.ToList();

            foreach(var item in report)
            {
                string db_date_out = item.date_out.ToShortDateString();
                if(Convert.ToDateTime(db_date_out) >= Convert.ToDateTime(FromDate)  && Convert.ToDateTime(db_date_out) <= Convert.ToDateTime(ToDate))
                {
                    dataGridReport.Rows.Add(item.ticket_id , item.date_out.ToShortDateString() , item.date_out.ToShortTimeString());
                }                
            }


            labTotal_Out.Text = dataGridReport.RowCount.ToString();
            labTotal_Income.Text = (dataGridReport.RowCount * 500).ToString();
        }

        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setTextBoxUserToNull();
            btnNewUser.Text = "Save";
            int i = dataGridUser.SelectedRows[0].Index;
            DataGridViewRow dgv = dataGridUser.Rows[i];
            string dgvusername = dgv.Cells[0].Value.ToString();
            var user = objdb.pk_users.First(z => z.username == dgvusername);

            if (e.ColumnIndex == dataGridUser.Columns["Reset"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to reset this user??", "Warming", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    user.password = "12345678";
                    objdb.SaveChanges();
                    MessageBox.Show("Default Password of User : " + dgvusername + " is 12345678.");
                    setTextBoxUserToNull();
                    dataGridUser.ClearSelection();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else if(e.ColumnIndex == dataGridUser.Columns["Activate"].Index && e.RowIndex >= 0)
            {
                bool getCheck = Convert.ToBoolean(dgv.Cells[4].Value);
                if(getCheck)
                {
                    user.activate = false;
                    objdb.SaveChanges();

                    dgv.Cells[4].Value = !getCheck;
                }
                else
                {
                    user.activate = true;
                    objdb.SaveChanges();

                    dgv.Cells[4].Value = !getCheck;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            Program.MysqlCon.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            pk_config_log price = new pk_config_log();
            pk_config configPrice = objdb.pk_config.First(item => item.Id == 1);
            price.config_id = 1;
            price.key = "vehicle_price";
            price.value = txtVehiclePrice.Text;
            price.update_date = DateTime.Now;
            objdb.pk_config_log.Add(price);

            configPrice.value = price.value;
            objdb.SaveChanges();
            
            dataGridVehiclePrice.Rows.Insert(0 , price.Id, price.key , price.value , price.update_date);
            dataGridVehiclePrice.ClearSelection();
            dataGridVehiclePrice.Rows[0].Selected = true;
            


        }

        private void changePasswordToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmChangePassword fcp = new frmChangePassword();
            fcp.Show();
            fcp.BringToFront();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string searchForTickeetNumber = textBox1.Text;
            var Record = objdb.pk_vehicle_out.First(item => item.ticket_id == searchForTickeetNumber);

            LabDateTimeOut.Text = Record.date_out.ToShortDateString();
        }

        private void btnRefreshCam_Click(object sender, EventArgs e)
        {
            
        }
    }
}
