using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Sept08
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int i;
            for(i=100;i>=50;i--)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
