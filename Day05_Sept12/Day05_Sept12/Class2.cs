using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int n1, arm = 0, rem;

            Console.WriteLine("enter any number");
            n1=Convert.ToInt32(Console.ReadLine());

            int c=n1;

            while(n1>0)
            {
                rem = n1 % 10;
                arm = (rem * rem * rem) + arm;
                n1 = n1 / 10;

            }
            if(c==arm)
            {
                Console.WriteLine($"{arm} is : armstrong number");
            }


        }
    }
}
