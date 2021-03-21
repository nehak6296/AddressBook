using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");

            ContactsCollection contactsCollection = new ContactsCollection();
            Contacts contacts = new Contacts(contactsCollection);

            while (true)
            {
                Console.WriteLine("Enter Preference:");
                Console.WriteLine("1.Create Address Book \n 2.Search Person \n 3.Exit");
                int preference = Convert.ToInt32(Console.ReadLine());
                switch (preference)
                {
                    case 1:
                        Console.WriteLine("Enter Address Book Name: ");
                        string name = Console.ReadLine();
                        contactsCollection.CreateAddressBook(name);
                        List<Person> list = contactsCollection.GetAddressBook(name);
                        while (true)
                        {
                            Console.WriteLine("Enter Choice:");
                            Console.WriteLine("1.Add Contact \n 2.Edit Contact \n 3.Delete Contact \n 4.Exit");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {

                                case 1:
                                    contacts.AddContact();
                                    break;
                                case 2:
                                    contacts.Edit();
                                    break;
                                case 3:
                                    contacts.Delete();
                                    break;
                                case 4:
                                    break;
                            }
                            if (choice == 4)
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        contactsCollection.Search();
                        break;
                    case 3:
                        break;

                    
                }
                if (preference==3)
                {
                    break;
                }
            }                      
        }
    }
}
