using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Sept14
{
    public class Rectangle
    {
        int length;
        int breadth;
        int peri;

        public Rectangle()
        {
            length = 5;
            breadth = 3;

        }
        public Rectangle(int length,int breadth)
        {
            this.length = length;
            this.breadth = breadth; 
        }

        public void CalcPeri()
        {
            peri = 2 * (length + breadth);

        }
        public string Display()
        {
            return $" perimeter is : {peri}";
        }
        
    }
     
}
