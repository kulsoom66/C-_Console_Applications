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
        string address; //private by defualt
        public decimal salary;
         
        //Constructor
        public Employee(int id,  string name, int age, string address, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.salary = salary;
        }

        public Employee()
        {

        }

        //function to display information of the employee
        public string getDetails()
        {
            return $"Hi my name is {name}, I am {age} years old, and I work in Code Academy with Salary {salary}";
        }

        //Getters
        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }

        public string getAddress()
        {
            return address;
        }

        //Setters
        public void setName(string name)
        {
            this.name = name;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
    }

   
}
