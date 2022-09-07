using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Sept07
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter any number");

            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("select the operation you want to perform");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. division");

            int result=Convert.ToInt32(Console.ReadLine());

            switch(result)
            {
                case 1:

                    Console.WriteLine(" Addition of {0} and {1} is {2}",n1,n2,(n1+n2));
                    break;
                case 2:

                    Console.WriteLine(" Subtraction of {0} and {1} is {2}", n1, n2, (n1-n2));
                    break;
                case 3:

                    Console.WriteLine(" Multiplication of {0} and {1} is {2}", n1, n2, (n1*n2));
                    break;
                case 4:

                    Console.WriteLine(" Division of {0} and {1} is {2}", n1, n2, (n1/n2));
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
             

          

            
        }
    }
}
