﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Sept21
{
    public class MaxArrayElement
    {

        static void Main(string[] args)
        {
            int[] num = new int[10] 
            { 1, 2, 5, 4, 3, 9, 8, 6, 10, 7 };

            Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("minimum num:" + num[0]);
            Console.WriteLine("maximum num:" + num[num.Length-1]);

        }
    }
}
