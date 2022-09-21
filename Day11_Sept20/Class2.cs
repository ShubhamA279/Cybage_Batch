using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Sept20
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string[] names = new string[3] { "shubham", "ankit", "darshan" };

            Console.WriteLine("before sort");
            foreach (string i in names)
                Console.WriteLine(i);

            Console.WriteLine("after sort");
            Array.Sort(names);
            foreach (string i in names)
                Console.WriteLine(i);

            Console.WriteLine("==================");
            Array.Reverse(names);
            foreach(string i in names)
                Console.WriteLine(i);
            Array.Clear(names, 0, names.Length);

            Console.WriteLine("========================");
            Console.WriteLine("Copy Value");
            Array.Copy(names, 0, names, 0, names.Length);
            foreach (string i in names)
                Console.WriteLine(i);
        }
    }
}
