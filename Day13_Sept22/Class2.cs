using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Class2
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(10); // same like arraylist // added data on top
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            queue.Dequeue(); // first in first out

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            queue.Peek();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
