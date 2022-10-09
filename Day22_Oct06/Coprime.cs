using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Oct06
{
    internal class Coprime
    {


        public static bool isCoprime(int a, int b)
        {
            int c = 0;
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                    c++;
            }

            if (c == 1)
                return true;
            else
                return false;
        }

        static int CountCoprime(int n)
        {
            int c = 0;

            for (int k = 1; k < n; k++)
            {
                if (isCoprime(k, n))
                    c++;
            }

            return c;
        }

        static void Main(string[] args)
        {
            int result=CountCoprime(3);
            Console.WriteLine(result);
        }
    }
}
