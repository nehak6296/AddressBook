using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace AddressBook
{
    class ReadCsvWriteJSON
    {
        ContactsCollection contactsCollection = null;
        public ReadCsvWriteJSON(ContactsCollection contactsCollection)
        {
            this.contactsCollection = contactsCollection;

        }

        public void WriteJson()
        {
            Console.WriteLine("Enter AddressBook Name:");
            string addressBookName = Console.ReadLine();

            string file = @"C:\Users\Neha\Desktop\Problems\AddressBook\AddressBook\AddressBook\AddressBook\Utility\write.json";
            List<Person> addressbook = contactsCollection.GetAddressBook(addressBookName);

            List<Person> personRead = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(file));
            personRead.AddRange(addressbook);

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, personRead);
            }           
        }

    }
}
