using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Sept15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            /*
             // PROPERTY INITILIZER SYNTAX
            s1.Roll_No = 11;
            s1.Name = "Amit";
            s1.Percent = 80.00;

            Console.WriteLine($"Roll_no : {s1.Roll_No}  Name : {s1.Name}  Percent : {s1.Percent}");
            */


            //OBJECT INITILIZER SYNTAX
            // we assign value while creating object
            Student s2 = new Student { Roll_No = 15, Name = "shubham", Percent = 85 };
            Console.WriteLine($"{s2}");
            Console.WriteLine();


            Course c1 = new Course { Id = 1, Name = "Java", Fees = 10000 };
            Console.WriteLine($"{c1}");


            Console.WriteLine();
            Employee e1 = new Employee { EmpId = 20, Name = "Amit", Salary = 50000 };
            Console.WriteLine($"{e1}");



            Console.WriteLine();
            Date d1 = new Date { Day = 20, Month = "Sept", Year = 2022 };
            Console.WriteLine($"{d1}");


            //AUTO IMPLIMENTATION PROPERTY
            // automatically create variable in class
        }
    }
}
