using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class Contacts
    {
        List<Person> list = new List<Person>();
        
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
               
        public void Delete()
        {
            int index = 0;
            bool isFound = false;
            Console.WriteLine("Enter First Name to edit:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name to edit:");
            string lastName = Console.ReadLine();

            foreach (Person person in this.list)
            {
                if (person.FirstName.Equals(firstName) && person.LastName.Equals(lastName))
                {
                    isFound = true;                    
                    break;
                }                
                index++;
            }
            if (isFound == true)
            {
                list.RemoveAt(index);
                Console.WriteLine("Contact deleted...");
                Display();
            }
            else
            {
                Console.WriteLine("Person doesn't exist.");
            }

        }

        public void Display()
        {
            foreach (Person person in list)
            {
                Console.WriteLine("FirstName:" + person.FirstName+"   " + "LastName:" + person.LastName + "  " + "Address:" + person.Address + "  " + "City: " + person.City + "  " + "State:" + person.State + "  " + "Zip: " + person.Zip + "  " + "Phone Number: " + person.PhoneNumber);
                Console.WriteLine("List Count:" + list.Count);
            }
        }

        public void Edit()
        {
            int index = 0;
            bool isFound = false;
            Console.WriteLine("Enter First Name to edit:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name to edit:");
            string lastName = Console.ReadLine();

            foreach (Person person in this.list)
            {
                if (person.FirstName.Equals(firstName) && person.LastName.Equals(lastName))
                {
                    isFound = true;
                    break;
                }
               
                index++;
            }
            if (isFound==true)
            {
                while (true)
                {
                    Console.WriteLine("1.Edit Address \n 2.Edit City \n 3.Edit State \n 4.Edit Zip \n 5.Edit Phone Number \n 6.Exit");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter new Address:");
                            list[index].Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter new City:");
                            list[index].City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new State:");
                            list[index].State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter new Zip:");
                            list[index].Zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter new Phone Number:");
                            list[index].PhoneNumber = Console.ReadLine();
                            break;
                        case 6:
                            break;
                    }
                    if (option == 6)
                    {
                        break;
                    }
                }
                Display();
            }
            else
            {
                Console.WriteLine("Person doesn't exist.");
            }
        }
    }
}
    
