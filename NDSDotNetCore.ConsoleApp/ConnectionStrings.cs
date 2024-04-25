using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSDotNetCore.ConsoleApp
{
    internal class ConnectionStrings
    {

        public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder() 
        { 
            DataSource = "NADI",
            InitialCatalog = "NDSDotNetCore",
            UserID = "sa",
            Password = "sa@123",
            TrustServerCertificate = true,

        };
    }
}
