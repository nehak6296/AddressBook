using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");

            ContactsCollection contactsCollection = new ContactsCollection();
            while (true)
            {
                Console.WriteLine("Enter Preference:");
                Console.WriteLine("1.Create Address Book \n 2.Exit");
                int preference = Convert.ToInt32(Console.ReadLine());
                switch (preference)
                {
                    case 1:
                        Console.WriteLine("Enter Address Book Name: ");
                        string name = Console.ReadLine();
                        contactsCollection.CreateAddressBook(name);
                        Contacts contacts = contactsCollection.GetAddressBook(name);
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
                        break;
                    
                }
                if (preference==2)
                {
                    break;
                }
            }                      
        }
    }
}
