using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lava_X
{
    class SqlConn
    {
        SqlConnection cnn;

        public SqlConn(string connectionString)
        {
            cnn = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
            if (cnn.State == System.Data.ConnectionState.Closed)
                cnn.Open();
            return true;

            }
        }
    }
}
