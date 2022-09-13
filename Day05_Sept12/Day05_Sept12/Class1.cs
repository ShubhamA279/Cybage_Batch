using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Sept12
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int i,j;
            for ( i = 2; i < 100; i++)
            {
                int count = 0;
                for ( j = 2; j < 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        count++;

                        break;
                    }
                    


                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
