using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactsCollection
    {
        public List<Person> list = null;
        /// <summary>
        /// The contacts dictionary
        /// </summary>
        /// 
        public Dictionary<string,List<Person>>  contactsDictionary = new Dictionary<string, List<Person>>() ;        
        public void CreateAddressBook(string addressBookName)
        {
            list = new List<Person>();       
            contactsDictionary.Add(addressBookName, list);          
        }           
        public List<Person> GetAddressBook(string addressBookName)
        {
            List<Person> value = null ;

            if (contactsDictionary.ContainsKey(addressBookName))
            {
                value = contactsDictionary[addressBookName];
            }
            else
            {
                Console.WriteLine("Address Book is Not Present");
            }
            return value;
        }      

         public void Search ()
         {
            List<List<Person>> list = new List<List<Person>>();

            Console.WriteLine("Enter city or state : ");
            string input = Console.ReadLine();             

            foreach (var addressBookEntry in contactsDictionary)
            {
                list.Add(addressBookEntry.Value.FindAll(p => p.City == input || p.State == input));                
            }
            if (!(list == null))
            {
                foreach (List<Person> addressBook in list)
                {
                    foreach (Person p in addressBook)
                    {
                        Console.WriteLine("FirstName:" + p.FirstName + "   " + "LastName:" + p.LastName + "  " + "Address:" + p.Address + "  " + "City: " + p.City + "  " + "State:" + p.State + "  " + "Zip: " + p.Zip + "  " + "Phone Number: " + p.PhoneNumber);
                    }
                }
            }
            else
            {
                Console.WriteLine("Person not exists..");
            }
        }
    }
}
