using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Sept19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course { Id = 11, Name="test", Fees = 10000 };
             
            
            

            Console.WriteLine(c1.print());

            Student s1 = new Student { Name = "shubham", RollNo = 27, Branch = "electrical" };

            Console.WriteLine(s1.print());
        }
    }
}
