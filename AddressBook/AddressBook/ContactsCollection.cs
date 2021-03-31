using System;
using System.Collections.Generic;
using System.Linq;
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
        public Dictionary<string, List<Person>> contactsDictionary = new Dictionary<string, List<Person>>();

        public Dictionary<string, List<Person>> cityDictionary = new Dictionary<string, List<Person>>();
        public Dictionary<string, List<Person>> stateDictionary = new Dictionary<string, List<Person>>();

        public void CreateAddressBook(string addressBookName)
        {
            list = new List<Person>();
            contactsDictionary.Add(addressBookName, list);
        }
        public List<Person> GetAddressBook(string addressBookName)
        {
            List<Person> value = null;

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

        public void SearchPersonInSameCityOrState()
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
                        Console.WriteLine("FirstName:" + p.FirstName + "   " + "LastName:" + p.LastName + "  " + "City: " + p.City + "  " + "State:" + p.State);
                    }
                }
            }
            else
            {
                Console.WriteLine("Person not exists..");
            }
        }
        public void ViewPersonByCityOrState()
        {
            List<List<Person>> cityList = new List<List<Person>>();
            List<List<Person>> stateList = new List<List<Person>>();
            List<Person> listToBeAdded = new List<Person>();

            Console.WriteLine("Enter city or state : ");
            string input = Console.ReadLine();

            foreach (var addressBookEntry in contactsDictionary)
            {
                cityList.Add(addressBookEntry.Value.FindAll(p => p.City == input));
                stateList.Add(addressBookEntry.Value.FindAll(p => p.State == input));
            }

            if (cityList.Count > 0)
            {
                foreach (List<Person> AddressBook in cityList)
                {
                    foreach (Person p in AddressBook)
                    {
                        listToBeAdded.Add(p);
                    }
                }
                if (!(cityDictionary.ContainsKey(input)))
                {
                    cityDictionary.Add(input, listToBeAdded);
                }

                Console.WriteLine("Persons from City : " + input);
                foreach (KeyValuePair<string, List<Person>> pair in cityDictionary)
                {
                    foreach (Person p in pair.Value)
                    {
                        if (p.City == input)
                        {
                            Console.WriteLine("FirstName:" + p.FirstName + "   " + "LastName:" + p.LastName + "  " + "City: " + p.City + "  " + "State:" + p.State);

                        }
                    }
                }
                Console.WriteLine("Total Persons in city :"+cityList.Count);
            }
            else if (stateList.Count > 0)
            {
                foreach (List<Person> AddressBook in cityList)
                {
                    foreach (Person p in AddressBook)
                    {
                        listToBeAdded.Add(p);
                    }
                }
                if (!(stateDictionary.ContainsKey(input)))
                {
                    stateDictionary.Add(input, listToBeAdded);
                }
                Console.WriteLine("Persons from State : " + input);
                foreach (KeyValuePair<string, List<Person>> pair in stateDictionary)
                {
                    foreach (Person p in pair.Value)
                    {
                        if (p.State == input)
                        {
                            Console.WriteLine("FirstName:" + p.FirstName + "   " + "LastName:" + p.LastName + "  " + "City: " + p.City + "  " + "State:" + p.State);

                        }
                    }
                }
                Console.WriteLine("Total Persons in State :" + stateList.Count);
            }

        }
        public void PrintNameInAlphabeticalOrder()
        {
            Console.WriteLine("Enter Book Name:");
            string AddressBookName = Console.ReadLine();

            if (contactsDictionary.ContainsKey(AddressBookName))
            {
                List<Person> AddressBook = GetAddressBook(AddressBookName);
                
                Console.WriteLine("Book Name : " + AddressBookName);

                var peopleInOrder = AddressBook.OrderBy(person => person.FirstName);

                foreach (Person person in peopleInOrder)
                {
                    Console.WriteLine("All Details :" + person.ToString());
                }
            }
            else
            {
                Console.WriteLine("AddressBook Not Found!");
            }
        }
        public void SortByCityStateOrZip()
        {
            Console.WriteLine("Enter Book Name:");
            string AddressBookName = Console.ReadLine();

            Console.WriteLine("Enter 1.City \n 2.State \n 3.Zip :");
            int input = Convert.ToInt32(Console.ReadLine());            

            if (contactsDictionary.ContainsKey(AddressBookName))
            {

                List<Person> AddressBook = GetAddressBook(AddressBookName);

                Console.WriteLine("Book Name : " + AddressBookName);

                switch (input) {
                    case 1:
                        var peopleByCity = AddressBook.OrderBy(person => person.City);
                        foreach (Person person in peopleByCity)
                        {
                            Console.WriteLine(" City:" + person.ToString());
                        }
                        break;
                    case 2:
                        var peopleByState = AddressBook.OrderBy(person => person.State);
                        foreach (Person person in peopleByState)
                        {
                            Console.WriteLine("State:" + person.ToString());
                        }
                        break;
                    case 3:
                        var peopleByZip = AddressBook.OrderBy(person => person.Zip);
                        foreach (Person person in peopleByZip)
                        {
                            Console.WriteLine("Zip :" + person.ToString());
                        }
                        break;
                    default:
                        break;
                } 
            }
            else
            {
                Console.WriteLine("AddressBook Not Found!");
            }
        }          

    }
}
