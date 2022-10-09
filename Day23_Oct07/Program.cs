using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day23_Oct07
{
    public class Test
    {
        public void Run1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void Run2()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            for (int i = 6; i <= 12; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Test test = new Test();
            Thread t1 = new Thread(new ThreadStart(test.Run1));
            Thread t2 = new Thread(new ThreadStart(test.Run2));
            Thread t3 = new Thread(new ThreadStart(test.Run1));
            t2.Name = "Thread2";
            t3.Name = "Thread3";
            t1.Name = "Thread1";
            t1.Start();
            t2.Start();
            t1.Join();
            t3.Start();

           // t1.Priority = ThreadPriority.Lowest;
           // t2.Priority = ThreadPriority.Highest;
           // t3.Priority = ThreadPriority.AboveNormal;
        }

    }

}
