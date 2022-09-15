using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Sept15
{
    public class Student
    {
        private int roll_no;
        private string name;
        private double percent;

        public int Roll_No
        {
            get { return roll_no; }
            set { roll_no = value; }
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }
        public double Percent
        {
            get { return percent; }
            set
            {
                percent = value;
            }
        }

        public override string ToString()
        {
            return $" RollNo: {roll_no} Name : {name} Percent :{percent}";
        }







    }
}
