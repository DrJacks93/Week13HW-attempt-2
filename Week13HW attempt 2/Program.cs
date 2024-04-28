using System;
using static System.Console;

namespace Week13HW_attempt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Student> stuList = new List<Student>();
            List<Teacher> teachList = new List<Teacher>();

            stuList.Add(new Student(1, "Derek Jackson", "Countryside ln", "Accounting", "Johnson"));
            stuList.Add(new Student(2, "Claire Jackson", "West Palm st", "Education", "Jane"));

            teachList.Add(new Teacher(3, "Jane Doe", "Northwest st", 45000, 20));
            teachList.Add(new Teacher(4, "John smith", "Eleventh st", 40000, 15));

            foreach (Student stu in stuList)
            {
                WriteLine(stu.IdNumber + " " + stu.FullName + " " + stu.Address + " " + stu.Major + " " + stu.Advisor);
            
            }
            foreach(Teacher teach in  teachList) 
            {
                WriteLine(teach.IdNumber + " " + teach.FullName + " " + teach.Address + " " + teach.Salary + " " + teach.YearsOfService);

            
            }

            WriteLine("How many students do you want to enter?");
            int inputAnswer = Convert.ToInt32(ReadLine());

            for (int x = 0; x < inputAnswer; x++)
            {
                WriteLine("Please enter student id number");
                    int idnum = Convert.ToInt32(ReadLine());
                WriteLine("Please enter student full name");
                    string fn = ReadLine();
                WriteLine("Please enter student address");
                    string address = ReadLine();
                WriteLine("Please enter student major");
                string major = ReadLine();
                WriteLine("Please enter student advsior");
                string advisor = ReadLine();
                                             
            }

            WriteLine("How many teachers do you want to enter?");
            int inputResponse = Convert.ToInt32(ReadLine());

            for (int y = 0; y < inputResponse; y++) 
            
            {
                WriteLine("Please enter teacher Id number");
                int idnum = Convert.ToInt32(ReadLine());
                WriteLine("Please enter teacher full name");
                string fn = ReadLine();
                WriteLine("Please enter teacher address");
                string address = ReadLine();
                WriteLine("Please enter teacher salary");
                int s = Convert.ToInt32(ReadLine());
                WriteLine("Please enter teach years of service");
                int yos = Convert.ToInt32(ReadLine());

                                                                          
            }

            WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", "Id Number", "Full Name", "Adress", "Major/Salary", "Advisor/Years of service");
           
            foreach(Student stu in stuList) 
            {
                WriteLine(stu.IdNumber + " " + stu.FullName + " " + stu.Address + " " + stu.Major + " " + stu.Advisor);

            
            }
            
            foreach(Teacher teach in teachList) 
            {
                WriteLine(teach.IdNumber + " " + teach.FullName + " " + teach.Address + " " + teach.Salary + " " + teach.YearsOfService);

            }
            
            ReadKey();



        }
    }
}
