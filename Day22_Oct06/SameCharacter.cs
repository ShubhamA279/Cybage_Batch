using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Oct06
{

    internal class SameCharacter
    {

        public bool Same(string s1, string s2)
        {
            bool isSame = true;

            for (int i1 = 0; i1 < s1.Length; ++i1)
            {
                int i2;

                for (i2 = 0; i2 < s2.Length; ++i2)
                {
                    if (s1[i1] == s2[i2])
                    {
                        break;
                    }
                }

                if (i2 == s2.Length)
                {
                    isSame = false;
                    break;
                }
            }

            return isSame;
        }

        static void Main(string[] args)
        {
            SameCharacter s = new SameCharacter();

            string s1 = "hello";
            string s2 = "hello";


            bool ans = s.Same(s1, s2);

            Console.WriteLine(ans);

        }
    }
}
