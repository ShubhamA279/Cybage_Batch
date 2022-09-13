using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0;

            Console.WriteLine("enter any number");
            num=Convert.ToInt32(Console.ReadLine());
            int i;
            for( i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine($"{num} is : Prime");
            }
            else
                Console.WriteLine($"{num}not prime number");
            ;
        }
    }
}
