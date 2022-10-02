using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Sept28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I am Shubham";
            string str2 = "Adding Example for string";
            int num = 27;
            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);

            string str3 = str1.Substring(5);
             string str10= str1.Substring(5,7);
            Console.WriteLine(str3);
            Console.WriteLine(str10);
            
            string str4 = String.Concat(str1, " ", str2," ",num.ToString());
            Console.WriteLine(str4);
            Console.WriteLine("---------");
            char[] chars = str1.ToCharArray(5, 7);
            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }

            string str5 = "Hello";
            Console.WriteLine(str5.ToLower());
            Console.WriteLine(str5.ToUpper());
            
            bool result = str5.Contains("hello");
            Console.WriteLine(result);

            string str6 = "hello Everyone";
            string str7 = " Good Evening";
            string str8 = str6;

            Console.WriteLine("---------");
            Console.WriteLine(str6.GetHashCode());
            Console.WriteLine(str8.GetHashCode());


            bool result1 = str6.Equals(str8);
            bool result2 = str6.Equals(str7);
            Console.WriteLine(result1);
            Console.WriteLine(result2);








        }
    }
}
