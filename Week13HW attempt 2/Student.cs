using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13HW_attempt_2
{
    public class Student:Person
    {


        public Student(int num, string fn, string a, string m, string adv) : base(num, fn, a) 
        {
            Major = m;
         Advisor = adv;
        
        
        }

        public string Major { get; set; }
        public string Advisor { get; set; }
    }
}
