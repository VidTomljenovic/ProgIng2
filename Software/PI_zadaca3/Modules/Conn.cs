using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_zadaca3.Modules
{
    public static class Conn
    {
        public static string GetConnectionString()
        {
            string serverName = "31.147.206.65";
            string databaseName = "PI2324_vtomljeno_DB";
            string userName = "PI2324_vtomljeno_User";
            string password = "lfrJZvR=";

            return $"Server={serverName};Database={databaseName};User Id={userName};Password={password};";
        }

    }
}
