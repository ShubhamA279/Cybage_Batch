using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Sept19
{
    
    public class ParamsKey
    {
        static void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void AcceptNum(params int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
        static void Main(string[] args)
        {
            AcceptNames("amit", "shubham", "ankit");
            AcceptNames("darshan", "vivek");

            AcceptNum(1, 2, 3);
        }
    }
}
