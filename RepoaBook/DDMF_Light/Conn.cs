using System.Data.SqlClient;

namespace RepoaBook
{
    public static class Conn
    {
        
        public static SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection("server=194.255.108.50;database=dbaBook_17;uid=aBook_17;pwd=eGi5YGK3;MultipleActiveResultSets=True");
            return con;
        }

        public static SqlConnection CreateConnection()
        {
            var cn = GetCon();
            cn.Open();
            return cn;
        }
    }
}
