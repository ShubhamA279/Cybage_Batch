using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Sept26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course c1 = new Course()
            //{
            //    Id = 1,
            //    Name = "C#",
            //    Fees = 10000,
            //};
            //Console.WriteLine(c1);
            /*
            Course[] c1 =
           {
               new Course { Id = 1, Name="C#",Fees=10000 },
               
            };

            foreach (Course c in c1)
            {
                Console.WriteLine(c);
            }
            Student[] s1 =
            {
                 new Student { Name = "Amit", City = "Pune" },
                 new Student { Name = "Suraj", City = "Mumbai" },
                 new Student { Name = "Kishor", City = "Nagpur" },
            };

            
            foreach (Student s in s1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------------------");

            Course[] c2 = 
            {
               new Course { Id = 2 , Name="Java",Fees=15000},
              
            };

            foreach (Course c in c2)
            {
                Console.WriteLine(c);
            }
            Student[] s2 =
            {
                 new Student { Name = "parth", City = "London" },
                 new Student { Name = "Amol", City = "France" },
                 
            };

            foreach (Student s in s2)
            {
                Console.WriteLine(s);
            }
            */




            Student[] stud1 = new Student[]
            {
                new Student { Name = "Rahul", City = "Pune" },
               new Student { Name = "Rohan", City = "Mumbai" }
            };

            ArrayList arrList = new ArrayList();
            arrList.Add(
                new Course1
                {
                    Id = 101,
                    Name = "C#",
                    Fees = 1000,
                    Students = new Student1[10],
                    //students = new Student1[10],
                });
            foreach (var item in arrList)
            {
                Console.WriteLine(item);

            }
            //ArrayList al1 = new ArrayList();

            //al1.Add(
            //    new Student1
            //    {
            //        Name = "bit",
            //        City = "pune",
            //    });
            //foreach (var item in al1)
            //{
            //    Console.WriteLine(item);
            //}




        }
    }

    
    
}

