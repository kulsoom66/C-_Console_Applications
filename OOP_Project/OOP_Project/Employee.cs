using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Employee
    {
        //instance variables
        public int id;
        public string name;
        public int age;
        public decimal salary;

        //Constructor
        public Employee(int id,  string name, int age, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public Employee()
        {

        }
    }

   
}
