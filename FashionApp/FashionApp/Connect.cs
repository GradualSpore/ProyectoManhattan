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

        public bool TryConnection(out string Error)
        {
            builder.Server = "201.146.25.42";
            builder.Port = 3306;
            builder.Database = "smartdelivery_smart";
            builder.UserID = "Prueba";
            builder.Password = "GcMSieJWeC8fZJmQ";

            try
            {
                MySqlConnection ms = new MySqlConnection(builder.ToString());
                ms.Open();
                Error = "";
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
        }

        public bool Login()
        {
            return false;
        }


    }
}
