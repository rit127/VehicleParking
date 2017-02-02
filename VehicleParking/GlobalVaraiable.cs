using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParking
{
    public class GlobalVaraiable
    {
        public static bool dis;
        public static string Username;
        public static string MysqlConnect()
        {
            string path = "MysqlConnection.txt";

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            string myConReader = reader.ReadToEnd();
            return myConReader;
        }
        
        public static string EntityConnectionMysql()
        {
            var entityConnectionStringBuilder = new System.Data.EntityClient.EntityConnectionStringBuilder();
            entityConnectionStringBuilder.Provider = "MySql.Data.MySqlClient";

            //server=localhost;user id=root;password=Sothearith;persistsecurityinfo=True;database=parking
            entityConnectionStringBuilder.ProviderConnectionString = MysqlConnect();
            
            entityConnectionStringBuilder.Metadata = "res://*/Models.VehicleParking.csdl|res://*/Models.VehicleParking.ssdl|res://*/Models.VehicleParking.msl";
            return entityConnectionStringBuilder.ToString();
        }

        
        
    }
    
}
