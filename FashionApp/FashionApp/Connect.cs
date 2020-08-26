using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace FashionApp
{
    class Connect
    {
        string usr;
        string pass;

        public Connect(string user, string password)
        {
            usr = user;
            pass = password;
        }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public bool TryConnection(out string Error)
        {
            builder.Server = "201.146.25.42";
            builder.Port = 3306;
            builder.Database = "basepruebaapp";
            builder.UserID = usr;
            builder.Password = pass;

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

    }
}
