using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_Sept29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Hello Everyone Good Evening");
            // Append  , AppendFormat  , Insert  , Remove , Replace
            float salary = 350000.00f;
            Console.WriteLine(stringBuilder);


            stringBuilder.Append(" My name is Shubham");
            Console.WriteLine(stringBuilder);
            Console.WriteLine("-------------");
            stringBuilder.AppendFormat(" my salary is {0:C}", salary);
            Console.WriteLine(stringBuilder);

            Console.WriteLine("-----------");
            stringBuilder.Insert(15, "Hey!!!");
            Console.WriteLine(stringBuilder);

            stringBuilder.Replace("Shubham", "Siddhey");

            Console.WriteLine(stringBuilder);

            stringBuilder.Remove(15, 20);
            Console.WriteLine(stringBuilder);
        }



    }
}

