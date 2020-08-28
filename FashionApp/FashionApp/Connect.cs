using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySqlConnector;

namespace FashionApp
{
    class Connect
    {
        string correo;
        string pass;

        public Connect(string user, string password)
        {
            correo = user;
            pass = password;
        }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public bool Login(out string Error)
        {
            builder.Server = "201.146.25.42";
            builder.Port = 3306;
            builder.Database = "smartdelivery_smart";
            builder.UserID = "Prueba";
            builder.Password = "GcMSieJWeC8fZJmQ";

            MySqlConnection ms = new MySqlConnection(builder.ToString());
            string query = "SELECT * FROM tbl_users WHERE correo='" + correo + "' AND password='" + pass + "'";
            MySqlCommand comando = new MySqlCommand(query, ms);
            MySqlDataReader lector;

            try
            {
                ms.Open();
                lector = comando.ExecuteReader();
                Error = "";
                if (lector.HasRows){return true;}
                else{return false;}
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
        }
    }
}
