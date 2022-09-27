using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Sept23
{
    public class Student
    {

        int mark;
        string name;

        public Student(int mark,string name)
        {
            this.mark = mark;
            this.name = name;

        }

        public override string ToString()
        {
            return $"Marks {mark}  Name:{name}";
        }


    }

    public class Clroom: IEnumerable
    {
        Student[] s1;
        
        public Clroom()
        {
            s1 = new Student[3];

            s1[0] = new Student(75, "amit");
            s1[1] = new Student(85, "sumit");
            s1[2] = new Student(80, "pranit");




        }

        public IEnumerator GetEnumerator()
        {
            return s1.GetEnumerator();
        }
    }
}
