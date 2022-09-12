using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Sept08
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("enter any number");
            n1=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{n1} * {1} = {n1*i}");
            }
        }
    }
}
