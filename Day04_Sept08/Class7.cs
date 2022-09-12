using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Sept08
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("enter range");
            int range = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=range;i++)
            {
                Console.WriteLine(n1);

                n3 = n1 + n2;

                n1 = n2;
                n2 = n3;
            }

        }
    }
}
