using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day09
{
    public class Employee
    {
        protected int id;
        private static int count = 0;
        protected string name;
        protected double bs, hra, da, pt, pf, total, netpaid;

        public Employee(string name,double bs,double pt)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
            this.pt = pt;

        }
        public static int DisplayCount()
        {
            return count;
        }
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da ;
            netpaid = total - (pf + pt);
        }

        public override string ToString()
        {
            return $"Employee Id {id} Employee name {name} , total salary {total} & " +
                $"Net paid {netpaid}";
        }

    }

    public class Manager : Employee
    {
        private double ta;
        //public Manager() : base() // call constructor
        //{
        //    ta = 0.0;
        //}
        public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt) //call const of base class
        {
            this.ta = ta;
        }
        public override void CalculateSalary()  //To hide implementation
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da + ta;
            netpaid = total - (pf + pt);
        }
        public override string ToString()
        {
            return $"Manager Id {id} Manager name {name} , total salary {total} & Net paid {netpaid}";
        }


    }
   
    public class SalesManager : Employee
    {
        private double comm, bonus;
        public SalesManager(string name, double bs, double pt, double comm,
            double bonus) : base(name, bs, pt) 
        {
            this.comm = comm ;
            this.bonus = bonus ;
        }
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da +comm + bonus;
            netpaid = total - (pf + pt);
        }
        public override string ToString()
        {
            return $"SalesManager Id {id} SalesManager name {name} , " +
                $"total salary {total} & Net paid {netpaid}";
        }
    }
}
