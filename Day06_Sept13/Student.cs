using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Sept13
{
    public class Student
    {
        int roll_no;
        string name,city;
        int age;
        string branch;




        public void AcceptValue()
        {
            roll_no = 27;
            name = "Amit";
            city = "Ratnagiri";
            age = 24;
            branch = "Electrical";
        }

        public string DisplayValue()

        {
            return $"Roll No is : {roll_no} Name is :{name} City is :{city} Age is : {age} Branch :{branch}" ;
        //    return $"{name}";
        //    return $"{city}";
        //    return $"{age}";
        //    return $"{branch}";
        }
    }
}
