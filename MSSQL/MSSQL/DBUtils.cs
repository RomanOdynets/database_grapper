using System.Data.SqlClient;

namespace MSSQL
{
    class DBUtils
    {
        public static SqlConnection GetDB()
        {
            string ds = "192.168.1.200";
            string database = "lessons25"; // TODO
            string username = "test";
            string pass = "test123";

            return SQLServerUtils.GetDBConnection(ds, database, username, pass);
        }
    }
}
