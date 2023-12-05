namespace OOP_Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PhoneBook phonebook1 = new PhoneBook(3);
            phonebook1.SetEntry(0,"Kulthoom", 2);
            phonebook1.SetEntry(1, "Saba", 3);

            Console.WriteLine("The index of kulthoom is: " + phonebook1.getNumber("Kulthoom"));


           
        }
    }
}