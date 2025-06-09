using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HoloSouls_PDKR_NSPD
{
    internal class DBConfig
    {
        public static string dbServer = "localhost";
        public static string dbUser = "root";
        public static string dbName = "nasipadang_db";
        public static string dbPass = "";

        public static string ConnStr => $"server={dbServer};user={dbUser};database={dbName};password={dbPass};";
    }
}
