using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Sept21
{
    public class Course
    {
       public int Id { get; set; }

        public string Name { get; set; }

        public int Fees { get; set; }



        public override string ToString()
        {
            return $"Course Details : {Id}  {Name}  {Fees}";
        }
    }
}
