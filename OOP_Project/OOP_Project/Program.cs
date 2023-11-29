namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //default constructor 
            Employee employ1 = new Employee();
            Console.WriteLine("Please enter your name: ");
            //string name = Console.ReadLine();
            //employ1.name = name;

            Console.WriteLine("Enter your age: ");
           //int age = int.Parse(Console.ReadLine());
           //employ1.age = age;

            //Constructor
            Employee employ2 = new Employee(1,"Kulthoom",23, "address",1500);
            Console.WriteLine(employ2.name);
            Console.WriteLine(employ2.getDetails());


            //initilazing an object
            Employee employ3 = new Employee
            {
                name = "Kulthoom",
                age = 23,
                salary = 23,
            };
            employ3.setAddress("Muscat"); //we can not access because it is private, due to that we used setter
        }
    }
}