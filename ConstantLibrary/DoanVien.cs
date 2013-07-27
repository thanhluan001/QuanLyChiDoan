using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstantLibrary
{
    public class DoanVien
    {
        public int ID { get; private set; } 

        public string name { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string gender { get; set; }
        public string religion { get; set; }
        public string race { get; set; }
        public string currentAddress { get; set; }
        public string education { get; set; }
        public DateTime? DoanEntryDate { get; set; }
        public DateTime? DangEntryDate { get; set; }
        public string responsibility { get; set; }
        public string chidoan { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string professionalLevel { get; set; }
        public string politicalLevel { get; set; }
        public int imageID { get; set; }

        public DoanVien(int ID)
        {
            this.ID = ID;
        }

        public static List<DoanVien> getAllDoanvien()
        {
            return SQLCall.getAllDoanVien();

        }
    }
}
