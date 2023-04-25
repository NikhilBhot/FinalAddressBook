namespace AddressBookProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come To AddressBook Project");
            //var addressBooks = new Dictionary<string, List<Contact>>();
            var contacts=new List<Contact>();
            var currentAddressBook = string.Empty;

            while (true)
            {
                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. Display All Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddressBookOperation.AddContact(contacts);
                        break;
                    case "2":
                        AddressBookOperation.DisplayConatct(contacts);
                        break;
                    case "3":
                        AddressBookOperation.EditContact(contacts);
                        break;
                    case "4":
                        AddressBookOperation.DeleteContact(contacts);
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
