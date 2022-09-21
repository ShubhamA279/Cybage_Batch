using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Sept20
{
    internal class Array2d
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[3, 4]
            {
                {1,2,3,4 },
                {4,5,6,7 },
                { 10,22,11,44}
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] : {arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
