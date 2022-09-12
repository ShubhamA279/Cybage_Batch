using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Sept08
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            //factorial

            int num,i;
            Console.WriteLine("enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for(i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine($"factorial of {num} is : " +fact);
                  

        }
    }
}
