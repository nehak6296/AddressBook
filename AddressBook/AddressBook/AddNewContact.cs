using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddNewContact
    {
       private List<Person> list = new List<Person>();
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
           person.Zip = Console.ReadLine();
           Console.WriteLine("Enter Phone Number");
           person.PhoneNumber = Console.ReadLine();

           Console.WriteLine("Enter Email");
           person.Email = Console.ReadLine(); 

            list.Add(person);
            Display();
        }
        public void Display()
        {
            foreach (Person person in list)
            {
                Console.WriteLine("FirstName"+person.FirstName+ "LastName:" + person.LastName + "  " + "Address:" + person.Address + "  " + "City: " + person.City + "  " + "State:" +person.State +"  "+"Zip: " +person.Zip + "  "+"Phone Number: "+person.PhoneNumber);
            }
        }
    }
}
