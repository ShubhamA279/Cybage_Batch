using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int n, sum = 0, rem;

            Console.WriteLine("enter number");
            n=Convert.ToInt32(Console.ReadLine()); ;

            int c = n;

            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;

            }

            if(c==sum)
            {
                Console.WriteLine($"{c} is Palindrome Number");
            }
            else
                Console.WriteLine($"{c} is Not Palindrome Number");
        }
    }
}
