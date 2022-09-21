using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Sept19
{
    public class Ref
    {
        static void swap(ref int a,ref int b)
        {
            int temp=a;
            a=b;
            b=temp;

        }
        static void Main(string[] args)
        {
               int a=10, b = 20;

            Console.WriteLine($"before swap a={a}  b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"after swap a={a}  b={b}");

        }
    }
}
