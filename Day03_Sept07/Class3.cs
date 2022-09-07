using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Sept07
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("enter any three number");
            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());
            n3=Convert.ToInt32(Console.ReadLine());

            if(n1>n2 && n1>n3)
            {
                Console.WriteLine($"{n1} : is greatest");
            }
          else  if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"{n2} : is greatest");
            }
           else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine($"{n3} : is greatest");
            }
        }
    }
}
