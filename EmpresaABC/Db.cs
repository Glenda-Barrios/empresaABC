using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace crud
{
    class Db
    {
        public static MySqlConnection cn()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "clientes";
            MySqlConnection con = new MySqlConnection(builder.ToString());

            return con;
        }
    }
}
