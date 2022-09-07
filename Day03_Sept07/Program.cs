using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Sept07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("enter year");
            year= Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("leap year");

            }
            else if(year%400==0)
                Console.WriteLine("leap year");
            else
                Console.WriteLine("not leap year");


            
        }
    }
}
