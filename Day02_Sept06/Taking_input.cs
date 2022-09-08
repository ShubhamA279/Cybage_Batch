using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02_Sept06
{
    internal class Taking_input
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("enter any two numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            int mul = n1 * n2;
            int div = n1 / n2;
            int sub = n1 - n2;
            int mod = n1 % n2;

            Console.WriteLine($"addition is : {sum}");
            Console.WriteLine($"multiplication is : {mul}");
            Console.WriteLine($"division is : {div}");
            Console.WriteLine($"subtraction is : {sub}");
            Console.WriteLine($"remainder is : {mod}");
        }
    }
}

