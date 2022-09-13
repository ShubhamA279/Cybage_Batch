using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Sept13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date date = new Date();
            //date.AssignValue();

            //date.DisplayValue();

            //Console.WriteLine(date.DisplayValue());

            Student student = new Student();
            student.AcceptValue();
            student.DisplayValue();
            string data= student.DisplayValue();
            Console.WriteLine(data);


            Console.WriteLine();
            Console.WriteLine();

            Employee Emp = new Employee();
            Emp.AcceptValue();
            Emp.PrintValue();

        }


    }
}
