using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstantLibrary
{
    public class Chidoan
    {
        public int ID { get; private set; }

        string name { get; set; }
        DateTime? fromTerm { get; set; }
        DateTime? toTerm { get; set; }
        string operatingRegion { get; set; }
        string parent_chidoan { get; set; }

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
