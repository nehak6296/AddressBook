using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;

namespace AddressBook
{
    class CSVHandler
    {
        ContactsCollection contactsCollection = null;

        public CSVHandler(ContactsCollection contactsCollection)
        {
            this.contactsCollection = contactsCollection;
        }
        public void WriteInCsvFile()
        {
            Console.WriteLine("Data written successfully....");
            string exportFile = @"C:\Users\Neha\Desktop\Problems\AddressBook\AddressBook\AddressBook\AddressBook\Utility\Address.csv";

            Console.WriteLine("Enter AddressBook Name");
            string addressBookName = Console.ReadLine();
            var records = contactsCollection.GetAddressBook(addressBookName);
            using (var writer = new StreamWriter(exportFile))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(records);
            }
        }

        public void ReadFromCsv()
        {
            List<Person> addressBook = null;
            string importFile = @"C:\Users\Neha\Desktop\Problems\AddressBook\AddressBook\AddressBook\AddressBook\Utility\Address.csv";
            using (var reader = new StreamReader(importFile))
            using (var csvImport = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                addressBook = csvImport.GetRecords<Person>().ToList();
               
            }
            foreach (Person p in addressBook)
            {
                Console.WriteLine(p.ToString());
            }
            //contactsCollection.contactsDictionary.Add("import", addressBook);
            Console.WriteLine("success");
        }

    }
}  



