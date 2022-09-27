using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day14_Sept23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Team team = new Team();

            foreach (Player p in team)
            {
                Console.WriteLine(p);
            }

            Player p1 = new Player(14000, "Rohit");
            Player p2 = new Player(15000, "Virat");
            Player p3 = new Player(10000, "Rahul");


            int result = p2.CompareTo(p3);
            if (result == 1)
            {
                Console.WriteLine("Virat has more runs ");
            }
            else
            {
                Console.WriteLine("Rahul has more runs");
            }
            */

            Clroom c1 = new Clroom();
            foreach (Student s in c1)
            {
                Console.WriteLine(s);
            }












        }
    }
}
