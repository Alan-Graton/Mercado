using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSQL
{
    public class StrConexao
    {
        public SqlConnection GetConnection()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-EHRV87U\\SQLEXPRESS;Initial Catalog=DB_Mercado;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection == null || connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
