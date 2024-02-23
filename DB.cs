using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class DB
    {
        SqlConnection SqlCon = new SqlConnection(@"Server=Drako;database=Hospital;Integrated Security=True");
        
        public void OpenConnection()
        {
            if (SqlCon.State == System.Data.ConnectionState.Closed)
            {
                SqlCon.Open();
            }
        }

        public void CloseConnection()
        {
            if (SqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCon.Close();
            }
        }

        public SqlConnection GetConnection() { return SqlCon; }
    }
}
