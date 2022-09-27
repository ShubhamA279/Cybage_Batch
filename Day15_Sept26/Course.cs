using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Sept26
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Fees { get; set; }


        
        public override string ToString()
        {
            return $"{Id} : {Name}  :{Fees}";
        }

    }

    public class Student
    {
        public  string Name { get; set; }
        public string City { get; set; }


       
        public override string ToString()
        {
            return $"   Name ={Name} City={City}";
        }

    }
}
