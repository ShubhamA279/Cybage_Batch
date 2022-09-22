using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Sept21
{
    public class DuplicateNumArray
    {
        static void Main(string[] args)
        {
            int[] a1= new int[7] { 1,2,3,2,4,3,5 };

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j= i+1; j < a1.Length; j++)
                {
                    if (a1[i] == a1[j])
                    {
                        Console.WriteLine(a1[j]);
                    }
                }

            }



        }
    }
}
