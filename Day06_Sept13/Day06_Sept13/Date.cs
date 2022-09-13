using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Sept13
{
    public class Date
    {
        int date, year;
        string month;

        public void AssignValue()
        {
            date = 13;
            month = "sept";
            year = 2022;

        }
        public string DisplayValue()
        {
            return $" Date is : {date}  / {month}   / {year}";
        }

    }
}
