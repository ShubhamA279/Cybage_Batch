using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Hash
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(91, "Ind");
            ht.Add(1, "USA");
            ht.Add(63, "Aus");
            ht.Add(44, "UK");



            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

        }



    }
}
