using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            list.Insert(2, 50);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");

            list.Remove(13);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine($"capacity of list is : {list.Capacity}");

            Console.WriteLine("----------------------");

            list.Insert(2, 70);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"capacity of list is : {list.Capacity}");

            Console.WriteLine("----------------------");


        }
    }
}
