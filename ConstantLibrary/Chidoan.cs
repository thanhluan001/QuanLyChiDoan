using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstantLibrary
{
    public class Chidoan
    {
        public int ID { get; private set; }

        public string name { get; set; }
        public DateTime? fromTerm { get; set; }
        public DateTime? toTerm { get; set; }
        public string operatingRegion { get; set; }
        public int parent_chidoan { get; set; }

        public Chidoan(int ID)
        {
            this.ID = ID;
        }

        public static void addNewChidoanActivity(int chidoanID, DateTime date, string description)
        {
            SQLCall.addNewChidoanActivity(chidoanID, date, description);
        }

        public static void refreshChidoanList()
        {
            Constant.chidoanID = SQLCall.getChidoanInfo();
        }

        /*
        public static Chidoan getChidoanInfo(int ID)
        {

        }
        */
    }
}
