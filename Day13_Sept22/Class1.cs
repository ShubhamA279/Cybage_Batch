using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();  // first data goto last position

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            stack.Pop(); // last in first out // last added element delete first
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            stack.Peek();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            
        }
    }
}
