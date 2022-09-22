using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Sept21
{
    public class DivideArrayTwoPart
    {
        static void Main(string[] args)
        {
            int k1=0,k2=0;
            int[] ar1 = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] ar2 = new int[3];

            Console.WriteLine("main Array");
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.Write(ar1[i]+" ");
            }

            Console.WriteLine("enter position to divide");
            int pos= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                if(i<pos)
                {
                    ar1[k1++]=ar1[i];
                }
                else
                    ar2[k2++]=ar1[i];
            }

            Console.WriteLine("first array ele");
            for (int i = 0; i < k2; i++)
            {
                Console.WriteLine(ar2[i]);
            }

            Console.WriteLine("second array ele");
            for (int i = 0; i < k1; i++)
            {
                Console.WriteLine(ar1[i]);
            }

            //done
        }

    }
}
