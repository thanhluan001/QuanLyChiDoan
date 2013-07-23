using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstantLibrary
{
    public class ChidoanActivity
    {
        public int ID { get; private set;}

        public int chidoanID { get; set; }
        public DateTime time { get; set; }
        public string description { get; set; }

        public ChidoanActivity(int ID)
        {
            this.ID = ID;
        }

        public ChidoanActivity(int ID, DateTime time, string description)
        {
            this.ID = ID;
            this.time = time;
            this.description = description;
        }
    }
}
