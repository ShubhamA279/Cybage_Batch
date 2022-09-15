using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Sept15
{
    public class Employee
    {
        private int empid;
        private string name;
        private double salary;

        public int EmpId
        {
            get { return empid; }   
            set { empid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public override string ToString()
        {
            return $"Empid : {empid} Name: {name} Salary: {salary}";

        }
    }
}
