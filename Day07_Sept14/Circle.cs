using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Sept14
{
    public class Circle
    {
        double radius;
        double area;
        double pi=3.14;

        public Circle()
        {
           radius = 2;
        }
        public Circle(double radius)
        {
            this.radius=radius;
            
        }

        public void CalcArea()
        {
            area = (pi * radius * radius);
            
        }
        public string DispValue()
        {
            return $" area of circle : {area}";
        }

    }
}
