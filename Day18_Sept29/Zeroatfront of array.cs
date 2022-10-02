using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_Sept29
{
    internal class Zeroatfront_of_array
    {

        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[] { 2,10,0,5,3,0,4,1 };
            int j = 5;
            for ( i = 5; i >= 0; i--)
            {

                if (arr[i]!=0)
                {
                    arr[j]=arr[i];
                    j--;
                }

            }

            for ( i = j; i >= 0; i--)
            {
                arr[j] = 0;
                j--;
            }
            Console.WriteLine("after iteration");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }


        }
            



    }
}
