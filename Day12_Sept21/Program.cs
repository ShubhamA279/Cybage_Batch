﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Sept21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];


            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1]= new int[] {  3, 4, 5 };
            jaggedArray[2]= new int[] { 5, 6, };

            for (int i = 0; i < jaggedArray.Length; i++)  // for main jagged array row size
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) // for inner jagged array length
                {
                    Console.Write(jaggedArray[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
