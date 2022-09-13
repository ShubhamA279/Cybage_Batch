using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.WriteLine("enter radius of circle");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * radius * radius;

            Console.WriteLine("area of circle is : "+ area);
        }
    }
}
