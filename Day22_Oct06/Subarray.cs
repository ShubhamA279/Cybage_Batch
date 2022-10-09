using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Oct06
{
    internal class Subarray
    {
        public int LongestSubarray(int[] arr1)
        {
            //int[] arr1 = new int[] { 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0 };
            int longestlen = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                int zero = 0, one = 0;
                for (int j = i; j < arr1.Length; j++)
                {
                    if (arr1[j] == 0)
                        zero++;
                    else if (arr1[j] == 1)
                        one++;

                    if (zero == one)
                    {
                        // print(arr, i, j);
                        if (longestlen < j - i + 1)
                            longestlen = j - i + 1;
                    }

                }
            }
            return longestlen;
        }

        static void Main(string[] args)
        {
            Subarray s1 = new Subarray();
            int[] arr1 = new int[] { 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0 };

            int res =s1.LongestSubarray(arr1);

            Console.WriteLine(res);
        }
    }
}
