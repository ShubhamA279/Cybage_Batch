using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager m1 = new Manager("managar1", 45000, 250, 5000);
            //m1.CalculateSalary();
            //Console.WriteLine(m1);


            //Employee e1 = new Manager("managar2", 43000, 250, 5000);
            //// association of method with object does at run time
            //e1.CalculateSalary(); // runtime polymorphism
            //Console.WriteLine(e1);


            //Employee e2 = new Employee("emp1", 34000, 200);
            //e2.CalculateSalary();
            //Console.WriteLine(e2);

            //=========================================================
            //Manager manager1 = new Manager("Test", 50000, 500, 2000);
            //manager1.CalculateSalary();
            //Console.WriteLine(manager1);

            //Employee e1 = new Employee("test2", 50000, 500);

            //e1.CalculateSalary();

            //Console.WriteLine(e1);

            SalesManager s1 = new SalesManager("Sm1", 50000, 500, 10000, 2000);
            s1.CalculateSalary();
            Console.WriteLine(s1);


            //=============================================================

            // Abstract class
            Circle c1 = new Circle(2);
            c1.Area();
            Console.WriteLine(c1);

            


            
        }
    }
}
