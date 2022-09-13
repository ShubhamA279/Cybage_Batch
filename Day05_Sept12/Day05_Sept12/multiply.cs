using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class multiply
    {
        static void Main(string[] args)
        {
            int n1, n2,ans=0;

            Console.WriteLine("enter num1 and num2");
            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());

            while(n2>0)
            {
                ans= n1+ ans;

                n2--;
            }
            Console.WriteLine($"multiplication of number is : {ans}");

        }
    }
}
