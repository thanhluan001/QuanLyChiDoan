using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

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

        public static Dictionary<string,int> getChidoanInfo()
        {
            string connStr = GetConnection();
            Dictionary<string, int> result = new Dictionary<string,int>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select * from chidoan.`chidoaninfo`", conn))
                {
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        result.Add(r["name"].ToString(),Convert.ToInt32(r["chidoanID"]));

                        /*if (count)
                        {
                            string format = "MMM d yyyy"; 
                            TermFrom.Text =  ((DateTime)r["termFrom"]).ToString(format);
                            TermTo.Text = ((DateTime)r["termTo"]).ToString(format);
                            OperationalRegionLabel.Text = r["operationRegion"].ToString();

                            count = false;
                        }*/
                    }
                }
            }
            return result;
        }

        public static int getDoanVienCountFromChiDoan(int chidoanID) {

            int result = -1;

            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select count(*) from chidoan.doanvienrecord where chidoanID=@chidoanID", conn))
                {
                    cmd.Parameters.AddWithValue("@chidoanID", chidoanID);

                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    
                }
            }
            return result;
        }

        public static void insertDoanVien(int chidoanID, int name, DateTime dateofbirth, string gender)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("insert into chidoan.doanvienrecord (chidoanID, name, dateofbirth, gender)" +
                                    "values (@chidoanID, @name, @dateofbirth, @gender)", conn))
                {
                    cmd.Parameters.AddWithValue("@chidoanID", chidoanID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}