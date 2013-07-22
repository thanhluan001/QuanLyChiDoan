using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstantLibrary
{
    public class ChidoanActivity
    {
        public int ID { get; private set;}

        private int chidoanID { get; set; }
        private int DateTime { get; set; }
        private string description { get; set; }

        public ChidoanActivity(int ID)
        {
            this.ID = ID;
        }
    }
}
