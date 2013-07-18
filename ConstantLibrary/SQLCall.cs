using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Drawing;

namespace ConstantLibrary
{
    public class SQLCall
    {
        public static string server = "localhost";
        public static string user = "devuser";
        public static string pwd = "devuser";
        public static string database = "chidoan";

        public static string GetConnection()
        {
            return String.Format("server={0};pwd={1};user={2};database={3};", server, pwd, user, database);
            //return ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;            
        }

        public static void insertChidoanInfo(string name, DateTime termTo, DateTime termFrom, string operatingRegion, int chidoanParent)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("insert into chidoan.chidoaninfo (name, termTo, termFrom, operationRegion, chidoan_parent) " +
                                                        "values (@name, @termTo, @termFrom, @operationRegion, @chidoanParent)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@termTo", termTo.Date);
                    cmd.Parameters.AddWithValue("@termFrom", termFrom.Date);
                    cmd.Parameters.AddWithValue("@operationRegion", operatingRegion);
                    cmd.Parameters.AddWithValue("@chidoanParent", chidoanParent);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool isSignInSucessful(string username, string password)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select count(*) from chidoan.account " +
                                                    "where username=@username and password=@password", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    
                    int r = Convert.ToInt32( cmd.ExecuteScalar());

                    if (r == 1) return true;
                    else return false;
                }
            }
            // code not reachable at this location
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

        public static void updateDoanVienPersonalInfo(int doanvienID, int chidoanID, string name, DateTime dateofbirth, string gender, string religion, string race, string imageID)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("update chidoan.doanvienrecord " +
                                    "set chidoanID=@chidoanID, name=@name, dateofbirth=@dateofbirth, " + 
                                    "gender=@gender, religion=@religion, race=@race, imageID=@imageID " +                                    
                                    "where ID=@doanvienID ", conn))
                {
                    cmd.Parameters.AddWithValue("@chidoanID", chidoanID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@religion", religion);
                    cmd.Parameters.AddWithValue("@race", race);
                    cmd.Parameters.AddWithValue("@imageID", imageID);
                    cmd.Parameters.AddWithValue("@doanvienID", doanvienID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void insertDoanVienPersonalInfo(int chidoanID, string name, DateTime dateofbirth, string gender, string religion, string race, string imageID)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("insert into chidoan.doanvienrecord (chidoanID, name, dateofbirth, gender, religion, race, imageID)" +
                                    "values (@chidoanID, @name, @dateofbirth, @gender, @religion, @race, @imageID)", conn))
                {
                    cmd.Parameters.AddWithValue("@chidoanID", chidoanID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@religion", religion);
                    cmd.Parameters.AddWithValue("@race", race);
                    cmd.Parameters.AddWithValue("@imageID", imageID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void updateDoanVienContactInfo(int ID, string currentaddress, string telephone, string email)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("update chidoan.doanvienrecord " +
                                    "set currentaddress=@currentaddress, telephone=@telephone, email=@email " +
                                    "where ID=@ID" , conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@currentaddress", currentaddress);
                    cmd.Parameters.AddWithValue("@telephone", telephone);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int getImageID()
        {
            int result = -1;
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select imageID from chidoan.image order by imageID DESC limit 1", conn))
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return result;
        }

        public static int getIDDoanVien()
        {
            int result = -1;
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select ID from chidoan.doanvienrecord order by ID DESC limit 1", conn))
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar() );
                }
            }
            return result;
        }

        public static void updateEducationLevel(int ID, string educationLevel, string professionalLevel, 
                                            string politicalLevel, string responsibility,
                                            DateTime DoanEntryDate, DateTime DangEntryDate)
        {
            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            { 
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("update chidoan.doanvienrecord " +
                                    "set education=@educationLevel, professionalLevel=@professionalLevel, politicalLevel=@politicalLevel, " +
                                    "DoanEntryDate=@DoanEntryDate, DangEntryDate=@DangEntryDate, Responsibility=@responsibility " + 
                                    "where ID=@ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@educationLevel", educationLevel);
                    cmd.Parameters.AddWithValue("@professionalLevel", professionalLevel);
                    cmd.Parameters.AddWithValue("@politicalLevel", politicalLevel);
                    cmd.Parameters.AddWithValue("@DoanEntryDate", DoanEntryDate);
                    cmd.Parameters.AddWithValue("@DangEntryDate", DangEntryDate);
                    cmd.Parameters.AddWithValue("@responsibility", responsibility);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string ifEmptyThenNull(string input)
        {
            return input == string.Empty ? null : input;
        }

        public static Bitmap loadImage(int doanvienID)
        {
            byte[] rawData;
            UInt32 fileSize;
            Bitmap resultImage = null;

            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select data, size from chidoan.image " +
                                    "where doanvienID=@doanvienID", conn))
                {
                    cmd.Parameters.AddWithValue("@doanvienID", doanvienID);

                    MySqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        fileSize = r.GetUInt32("size");                        
                        rawData = new byte[fileSize];

                        r.GetBytes(0, 0, rawData, 0, (int) fileSize);

                        MemoryStream ms = new MemoryStream(rawData);
                        resultImage = new Bitmap(ms);
                        ms.Close();
                        ms.Dispose(); 
                        
                    }
                }
            }
            return resultImage;
        }

        public static void saveBlob(int doanvienID, string imageString) {

            FileStream fs = new FileStream(imageString, FileMode.Open);
            int size = (int) fs.Length;
            byte[] bytes = new byte[size];
            fs.Read(bytes, 0, size);
            fs.Close();

            string connStr = GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("insert into chidoan.image (data, size)" +
                                    "values ( @avataimage, @size ) ", conn))
                {
                    cmd.Parameters.AddWithValue("@avataimage", bytes);
                    cmd.Parameters.AddWithValue("@size", size);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}