using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Sept19
{
    public interface Iprintable
    {
        string print();
    }
    public class Course: Iprintable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Fees { get; set; }

        public string print()
        {
            return $"Id : {Id} Name:{Name} Fees: {Fees}";
        }
    }

    public class Student : Iprintable
    {
        public string Name { get; set; }

        public int RollNo { get; set; }

        public string Branch { get; set; }

        public string print()
        {
            return $"Name: {Name} , RollNo: {RollNo}, Branch : {Branch}";
        }
    }
}

