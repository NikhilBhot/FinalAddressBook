﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    public class Contact
    {
        //UC-01
        /*
         * Ability to create a Contacts in Address Book with first and last names, 
         * address, city, state, zip, phone number and email...
         */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}

