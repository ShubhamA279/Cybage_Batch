using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Sept14
{
    public class Student
    {
        int roll_no;
        string name;
        int sub1, sub2, sub3;
        float total ,percent;

        public Student()
        {
            roll_no = 15;
            name = "Ankit";
            sub1 = 80;
            sub2 = 90;
            sub3 = 85;    
        }

        public Student(int roll_no,string name,int sub1,int sub2,int sub3)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.sub1= sub1;
            this.sub2= sub2;
            this.sub3= sub3;
        }

        public  void CalculatePercent()
        {
            total = (float)(sub1+sub2+sub3);


            percent =  (total/3.0f);

        }
        public string DisplayValue()
        {
            return $" roll_no is: {this.roll_no} \n name is: {this.name} \n percentage is: {percent}";
        }


    }
}
