using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            Program p = new Program();
            p.AddContact();
        }

        public void AddContact()
        {
            Person person = new Person();
            Console.WriteLine("Enter First Name");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            AddressBook.Person.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            AddressBook.Person.PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email");
            person.Email = Console.ReadLine();
        }
    }
}
