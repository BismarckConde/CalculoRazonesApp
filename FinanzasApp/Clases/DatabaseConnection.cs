using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FinanzasApp.Clases
{
    public class DatabaseConnection
    {
        private static readonly string ConnectionString =
          
            System.Configuration.ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
