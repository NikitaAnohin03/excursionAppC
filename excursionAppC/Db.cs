using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excursionAppC
{
    class Db
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GCU9OB8\\SQLEXPRESS;Initial Catalog=excurionBase;Integrated Security=True;Encrypt=true;TrustServerCertificate=true");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closedConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
