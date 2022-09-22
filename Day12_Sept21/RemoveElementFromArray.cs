using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Sept21
{
    public class RemoveElementFromArray
    {

        static void Main(string[] args)
        {
            int pos;
            int[] num1 = new int[5] { 1, 5, 3, 2, 8 };

            Console.WriteLine("Array Elements Before deleting");

            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }

            Console.WriteLine("enter position to delete");
            pos= Convert.ToInt32(Console.ReadLine());


            for (int i = pos - 1; i < 5; i++)
            {
                num1[i] = num1[i + 1];
            }

            Console.WriteLine("number after deletion");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(num1[i]);
            }

        }
    }
}
