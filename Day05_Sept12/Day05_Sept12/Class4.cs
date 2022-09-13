using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            double length, breadth, peri;

            Console.WriteLine("enter length and breadth");
            length=Convert.ToDouble(Console.ReadLine());
            breadth=Convert.ToDouble(Console.ReadLine());

            peri = 2*(length + breadth);

            Console.WriteLine("perimeter of rectangle is :"+peri);

        }
    }
}
