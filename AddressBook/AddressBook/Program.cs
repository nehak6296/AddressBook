﻿using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            while (true)
            {
                Console.WriteLine("Enter Choice:");
            Console.WriteLine("1.Add Contact \n 2.Edit Contact \n 3.Delete Contact \n 4.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

           
                switch (choice)
                {
                    case 1:
                        AddNewContact a = new AddNewContact();
                        a.AddContact();

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}
