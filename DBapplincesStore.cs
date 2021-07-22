using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppliancesStore
{
    class DBapplincesStore
    {
        //'Server=xxx;UserId=yyy;Password=zzz;Database=dbdb'

        readonly MySqlConnection Connect = new MySqlConnection("server=localhost; port=3306; username=root; Password=''; database=db_appliances_store");

        public void OpenConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Closed)
                Connect.Open();
        }

        public void CloseConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
                Connect.Close();
        }

        public MySqlConnection GetConnection()
        {
            return Connect;
        }
    }
}
