using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleParking
{
    static class Program
    {

        public static MySqlConnection MysqlCon = new MySqlConnection(GlobalVaraiable.MysqlConnect());
        public static EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmConfigurations());
            //Application.Run(new frmLogin());
            Application.Run(new frmMainForm());
            //Application.Run(new frmUserController());
        }
    }
}

