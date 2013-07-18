using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstantLibrary
{
    public class Constant
    {
        public static Dictionary<string, int> chidoanID = SQLCall.getChidoanInfo();

        public static int currentDoanVienID
        {
            get;
            set;
        }

        // get new data if chidoanID object changed
        public static void refreshChidoanList()
        {
            chidoanID = SQLCall.getChidoanInfo();
        }

        /*
        public Constant()
        {
            if (chidoanID == null)
                chidoanID = SQLCall.getChidoanInfo();
        } */       
    }
}
