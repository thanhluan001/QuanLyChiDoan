using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyChiDoan
{
    class SQLCall
    {
        public static string server = "localhost";
        public static string user = "devuser";
        public static string pwd = "devuser";
        public static string database = "chidoan";

        public static string GetConnection()
        {
            return String.Format("server={0};pwd={1};user={2};database={3};", server, pwd, user, database);
        }
    }
}
