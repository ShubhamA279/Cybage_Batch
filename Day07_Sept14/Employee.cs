using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Sept14
{
    public class Employee
    {
        int empid;
        string empname;
        float basic_salary;
        float travel_allowances;
        float home_allowances;
        float total_Salary;
        float pf=2000f;


        public Employee()
        {
            empid = 146;
            empname = "Ankit";
            basic_salary = 40000f;
            travel_allowances = 5500f;
            home_allowances = 3000f;
            

        }

        public Employee(int empid,string empname,float basic_salary,float travel_allowances,float home)
        {
            this.empid = empid;
            this.empname = empname; 
            this.basic_salary = basic_salary;   
            this.travel_allowances = travel_allowances;
            this.home_allowances = home;

        }

        public void CalculateSalary()
        {
            total_Salary = ( basic_salary + travel_allowances + home_allowances  - pf);

            
        }

        public string DispValue()
        {
            return $" empid {this.empid} \n empname {this.empname} \n total salary {total_Salary}";
        }

    }

}
