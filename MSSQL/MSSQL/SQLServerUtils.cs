using System.Data.SqlClient;

namespace MSSQL
{
    class SQLServerUtils
    {
        public static SqlConnection GetDBConnection(string ds, string database, string username, string password)
        {
            string conn_str = @"Data Source=" + ds + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password; ;
            SqlConnection conn = new SqlConnection(conn_str);
            return conn;
        }
    }
}
