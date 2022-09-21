using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    abstract public class Shape
    {
        public abstract void Area();// by default virtual

    }
    public class Circle : Shape
    {

        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void Area()   // override method
        {
            result = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"Area of Circle is {result}";
        }

    }
}