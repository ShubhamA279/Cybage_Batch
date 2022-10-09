using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_Oct04
{
    public delegate string Mydelegate(string s1);
    public class User
    {
        public string AcceptName(string str1)
        {
           return str1.ToUpper();
            //return str1;
        }
        public string acceptname(string str1)
        {
           return  str1.ToLower();
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            User u1 = new User();

            Mydelegate mydel = new Mydelegate(u1.AcceptName);

            mydel += new Mydelegate(u1.acceptname);

            Delegate[] list = mydel.GetInvocationList();
            foreach (Delegate d in list)
            {
               
                Console.WriteLine(d.DynamicInvoke("Amit"));
            }


            










        }
    }
}
