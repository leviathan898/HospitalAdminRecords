using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andyCheung_B8IT117
{
    public class Person
    {
        //get set properties to be inherited by other classes
        public EnumTitles Title { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string DOB { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
