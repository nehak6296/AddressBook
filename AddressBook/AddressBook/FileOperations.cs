using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    class FileOperations
    {
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\Neha\Desktop\Problems\AddressBook\AddressBook\AddressBook\AddressBook\AddressBook.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists...");
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("File dont  exists...");
            }
        }
        public static void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\Neha\Desktop\Problems\AddressBook\AddressBook\AddressBook\AddressBook\AddressBook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists...");

                using (StreamWriter sr = File.AppendText(path))
                {
                    Console.WriteLine("Enter Address Book Name:");
                    sr.Write("Book Name  : ");
                    string AddressBookName = Console.ReadLine();
                    sr.WriteLine(AddressBookName);
                    Console.WriteLine("Enter First Name");
                    sr.Write("First Name  : ");
                    string Fname = Console.ReadLine();
                    sr.WriteLine(Fname);
                    Console.WriteLine("Enter Last Name");
                    sr.Write("Last Name  : ");
                    string Lname = Console.ReadLine();
                    sr.WriteLine(Lname);

                    sr.Close();
                    Console.WriteLine(File.ReadAllText(path));
                }
            }
            else
            {
                Console.WriteLine("File dont  exists...");
            }
        }
    }
}
