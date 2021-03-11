using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactsCollection
    {
       public Dictionary<string, Contacts> contactsDictionary = new Dictionary<string, Contacts>();

        public void CreateAddressBook(string name)
        {
            Contacts contacts = new Contacts();
            contactsDictionary.Add(name , contacts);          
        }   
        
        public Contacts GetAddressBook(string name)
        {
            Contacts value = null ;
            if (contactsDictionary.ContainsKey(name))
            {
                value = contactsDictionary[name];
            }
            else
            {
                Console.WriteLine("Name Not Present");
            }
            return value;
        }
    }
}
