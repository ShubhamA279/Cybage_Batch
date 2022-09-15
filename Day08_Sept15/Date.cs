using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day08_Sept15
{
    public class Date
    {
        private int day;
        private string month;
        private int year;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public override string ToString()
        {
            return $" Date: {day} Month : {month} Year :{year}";

        }
    }
}
