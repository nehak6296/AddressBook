using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Person
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public static int Zip  { get; set; }
        public static long PhoneNumber { get; set; }        
        public string Email { get; set; }          
                
    }
    
}
