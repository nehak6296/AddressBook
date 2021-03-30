using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Person
    {            
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip  { get; set; }
        public string PhoneNumber { get; set; }        
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   FirstName == person.FirstName &&
                   LastName == person.LastName &&
                   Address == person.Address &&
                   City == person.City &&
                   State == person.State &&
                   Zip == person.Zip &&
                   PhoneNumber == person.PhoneNumber &&
                   Email == person.Email;
        }

        public override string ToString()
        {
            return "Person: " + FirstName +"   "+ LastName ;
        }
    }                      
 }    

