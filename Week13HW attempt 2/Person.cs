using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13HW_attempt_2
{
    public class Person
    {

        public Person(int idNum, string fullName, string address) 
        {
            IdNumber = idNum;
            FullName = fullName;
            Address = address;
       
        }

        public int IdNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }


    }
}
