using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Sept28
{
    public class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public List<Lones> Lones1 = new List<Lones>();
    }
    public class Department
    {
        public int Did { get; set; }
        public string Dname { get; set; }

        public List<Emp> Employees = new List<Emp>();
    }
    public class Lones
    {
        public string LoneName { get; set; }
    }
    public class Account
    {
        public string AccName { get; set; }

        public List<Department> Departments = new List<Department>();
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            List<Account> AccName = new List<Account>()
            {
                new Account
                {
                    AccName = "Account Type",

                    Departments =
                    {
                        new Department
                        {
                            Did = 101,
                            Dname = "HR",
                            Employees =
                            {
                                new Emp
                                {
                                    EmpId = 1,
                                    EmpName = "User1",
                                    Lones1 =
                                    {
                                        new Lones
                                        {
                                            LoneName = "Car",
                                        }
                                    }
                                },
                                new Emp
                                {
                                    EmpId = 2,
                                    EmpName = "User2",
                                    Lones1 =
                                    {
                                        new Lones
                                        {
                                            LoneName = "HomeLone",
                                        }
                                    }
                                },

                            }
                        },

                        //new Department
                        //{
                        //    Did=101,Dname="Development",
                        //    Employees={
                        //        new Emp{EmpId=3,EmpName="User3"},
                        //        new Emp{EmpId=4,EmpName="User4"},
                        //        new Emp{EmpId=5,EmpName="User5"},
                        //    }
                        //},

                    }



                }

            
            };
            Console.WriteLine("Account type");
            foreach (var v in AccName)
            {
                Console.WriteLine($"{v.AccName}");
                foreach (Department d in v.Departments)
                {
                    Console.WriteLine($"\t{d.Did} {d.Dname}");
                    foreach (Emp e in d.Employees)
                    {
                        Console.WriteLine($"\t\t{e.EmpId}   {e.EmpName}");
                        foreach (Lones l in e.Lones1)
                        {
                            Console.WriteLine($"\t\t\t{l.LoneName}");
                        }
                    }
                }

            }
        }
    }


}

        
    

