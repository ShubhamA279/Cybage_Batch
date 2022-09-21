using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Sept20
{
    public class ArrayOperation
    {

        static void Main(string[] args)
        {
            Console.WriteLine("before sort");
            int[] arr = new int[5] { 10, 20, 30, 50, 40 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("after sort");
            Array.Sort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);

            Console.WriteLine("===========================");

            Array.Reverse(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============================");
            Array.Copy(arr, 0, arr, 0, arr.Length);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


            Array.Clear (arr, 0, arr.Length);
        }

    }
}
