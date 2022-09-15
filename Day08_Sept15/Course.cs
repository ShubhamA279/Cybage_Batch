using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Sept15
{
    public class Course
    {
        private int id;
        private string name;
        private double fees;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        public override string ToString()
        {
            return $"Id : {id} Name: {name} Fees: {fees}";
        }

    }
}
