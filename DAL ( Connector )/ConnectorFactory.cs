using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOModel;
using System.Data;
using System.Configuration;

using System.Data.SqlClient;
namespace DALConnector
{
    public class ConnectorFactory
    {
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ToString());
        public static void openConnectDB()
        {
            try
            {
                conn.Open();
            }
            catch(SqlException)
            {

            }
        }
        public static void closeConnectDB()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException)
            {

            }
        }
    }
}
