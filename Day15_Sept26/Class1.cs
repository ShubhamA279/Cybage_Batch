using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Sept26
{
    public class Student1
    {
        public string Name { get; set; }


        public string City { get; set; }


        public override string ToString()
        {
            return $"Name {Name} City {City}";
        }

    }

    public class Course1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

        public Student1 [] Students { get; set; } 
        public override string ToString()
        {
            return $"Id{Id} ; {Name} ; {Fees}";
        }



    }
}
