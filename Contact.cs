using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Contact
    {
        class Collection {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string State { get; set; }
            public string Address { get; set; }
            public string Zip { get; set; }
            public string City { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

        }

        public string FirstName;
        public string LastName;
        public string State;
        public string Address;
        public string Zip;
        public string City;
        public string PhoneNumber;
        public string Email;


        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}\n{Address}\n{City}, {State} {Zip}\nPhone: {PhoneNumber}\nEmail: {Email}\n";
        }

    }
}
