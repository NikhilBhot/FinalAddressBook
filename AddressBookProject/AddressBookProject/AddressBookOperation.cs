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
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.EmailAddress}");
                Console.WriteLine();
            }
        }
        /*UC-03
         * Ability to edit existing contact person using their
         */
        public static void EditContact(List<Contact> contacts)
        {
            Console.Write("Enter First name of contact to edit: ");
            var name = Console.ReadLine();
            var contact = contacts.FirstOrDefault(c => c.FirstName == name);

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.Write("Enter new phone number (leave blank to keep existing value): ");
            var phoneNumber = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                contact.PhoneNumber = phoneNumber;
            }

            Console.Write("Enter new email address (leave blank to keep existing value): ");
            var emailAddress = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(emailAddress))
            {
                contact.EmailAddress = emailAddress;
            }

            Console.Write("Enter new city (leave blank to keep existing value): ");
            var city = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(city))
            {
                contact.City = city;
            }

            Console.Write("Enter new state (leave blank to keep existing value): ");
            var state = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(state))
            {
                contact.State = state;
            }

            Console.WriteLine("Contact updated successfully!");
        }
        /*UC-04
         * Ability to delete a person using person's name - Use Console to delete a person
         */
        public static void DeleteContact(List<Contact> contacts)
        {
            Console.Write("Enter name of contact to delete: ");
            var name = Console.ReadLine();
            var contact = contacts.FirstOrDefault(c => c.FirstName == name);

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            contacts.Remove(contact);
            //deleteFromJson(contacts, contact);

            Console.WriteLine("Contact deleted successfully!");
        }
        //UC-06,UC-07,UC-08
       public static string UseAddressBook(Dictionary<string, List<Contact>> addressBooks)
        {
            Console.Write("Enter name of address book: ");
            var addressBookName = Console.ReadLine();

            if (!addressBooks.ContainsKey(addressBookName))
            {
                addressBooks[addressBookName] = new List<Contact>();
            }

            Console.WriteLine($"Using address book: {addressBookName}");
            return addressBookName;
        }
    }
}
