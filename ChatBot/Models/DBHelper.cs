using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot.Models
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=(localdb)\\ProjectsV13;" +
                "Initial Catalog=ChatBotDataBase;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            return con;
        }
    }
}
