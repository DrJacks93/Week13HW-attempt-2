using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13HW_attempt_2
{
    public class Teacher : Person
    {
        public Teacher(int id, string fn, string a, double s, int yos) : base(id, fn, a)
        { 
            Salary = s;
            YearsOfService = yos;
        
        }
        public double Salary
        { 
         get; set;
                      
        }

        public int YearsOfService
        {
            get; set;
        
        }

    }
}
