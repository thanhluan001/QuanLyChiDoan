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

    }
}
