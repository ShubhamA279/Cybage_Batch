using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Pune";
            int year = 2022;
            char gender = 'M';
            float salary = 45000.56f;
            double salary1 = 78000.20;

            Console.WriteLine("my current city is : " + city + " year is : " + year + " gender is " + gender +
                " salary : " + salary + " salary1 : " + salary1);

            Console.WriteLine("my current city is : {0} year is : {1}  gender is :  {2} " +
                "salary is : {3} salary1 is : {4} ",city,year,gender,salary,salary1);

            Console.WriteLine($"my current city is : {city}  year is : {year} gender is {gender} " +
                $"salary : {salary} salary1 : {salary}");
        }
    }
}
