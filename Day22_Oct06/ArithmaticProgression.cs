using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Oct06
{
    class ArithmeticProgression
    {
        static void PrintAP(int a, int d, int n)
        {
            int NthValue = a + (n - 1) * d;

            //for (int i = a; i <= NthValue; i = i + d)
           // {
                Console.Write("{0} ", NthValue);
            //}
        }
        static void Main(string[] args)
        {
            // tn = a+(n-1)d
            int a, n,b, d;

            Console.WriteLine("Enter the total count of numbers to print: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the starting number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            d = b - a;

            PrintAP(a, d, n);
        }
    }








}
