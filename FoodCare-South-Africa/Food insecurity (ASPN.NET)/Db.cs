using System.Configuration;
using System.Data.OleDb;

namespace Food_insecurity__ASPN.NET_
{
    public static class Db
    {
        public static OleDbConnection CreateConnection()
        {
            return new OleDbConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}
