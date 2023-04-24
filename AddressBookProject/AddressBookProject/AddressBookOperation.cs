using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    public class AddressBookOperation
    {
        //UC-02
        /*Ability to add a new Contact to Address Book
         */
        public static void AddContact(List<Contact> contacts)
        {
            Console.Write("Enter First Name: ");
            var firstname = Console.ReadLine(); 
            Console.Write("Enter Last Name: ");
            var lastname = Console.ReadLine();
            Console.Write("Enter Address: ");
            var address = Console.ReadLine();
            Console.Write("Enter city: ");
            var city = Console.ReadLine();
            Console.Write("Enter state: ");
            var state = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            var zip = Console.ReadLine();
            Console.Write("Enter phone number: ");
            var phoneNumber = Console.ReadLine();
            Console.Write("Enter email address: ");
            var emailAddress = Console.ReadLine();

            if (contacts.Any(c => c.FirstName == firstname && c.LastName==lastname && c.PhoneNumber == phoneNumber && c.EmailAddress == emailAddress))
            {
                Console.WriteLine("Contact already exists!");
                return;
            }

            contacts.Add(new Contact
            {
                FirstName = firstname,
                LastName=lastname,
                Address=address,
                City = city,
                State = state,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress,
            }); ;

            Console.WriteLine("Contact added successfully!");
        }

        //Diplay All Contact Store In List
        public static void DisplayConatct(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"Last Name: {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"Ciry: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.EmailAddress}");
                Console.WriteLine();
            }
        }
    }
}
