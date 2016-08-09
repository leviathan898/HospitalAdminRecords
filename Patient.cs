using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andyCheung_B8IT117
{
    //inherit Person Class
    public class Patient : Person
    {
        //get and set ID property
        public int ID { get; set; }

        //format properties into string with override ToString
        public override string ToString()
        {
            return string.Format(ID + "\t" + Title + "\t" + FName + "\t" + LName + "\t" + DOB + "\t" + Email + "\t" + Phone);
        }
    }
}
