using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            
            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. List Contacts");
                Console.WriteLine("3. Search Contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter contact name: ");
                        string name = Console.ReadLine();
                        
                        Console.Write("Enter contact phone number: ");
                        string phoneNumber = Console.ReadLine();
                        
                        Console.Write("Enter contact email: ");
                        string email = Console.ReadLine();
                        
                        contacts.Add(new Contact(name, phoneNumber, email));
                        
                        Console.WriteLine("\nContact added successfully.\n");
                        break;
                    
                    case 2:
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("\nNo contacts found.\n");
                        }
                        else
                        {
                            Console.WriteLine("List of Contacts:\n");
                            foreach (Contact contact in contacts)
                            {
                                Console.WriteLine(contact);
                            }
                            Console.WriteLine();
                        }
                        break;
                        
                    case 3:
                        Console.Write("Enter search query: ");
                        string query = Console.ReadLine();
                        
                        List<Contact> searchResults = contacts.FindAll(
                            delegate(Contact contact)
                            {
                                return contact.Name.Contains(query) ||
                                       contact.PhoneNumber.Contains(query) ||
                                       contact.Email.Contains(query);
                            });
                        
                        if (searchResults.Count == 0)
                        {
                            Console.WriteLine("\nNo matching contacts found.\n");
                        }
                        else
                        {
                            Console.WriteLine("Matching Contacts:\n");
                            foreach (Contact contact in searchResults)
                            {
                                Console.WriteLine(contact);
                            }
                            Console.WriteLine();
                        }
                        break;
                    
                    case 4:
                        Console.WriteLine("\nGoodbye!");
                        return;
                    
                    default:
                        Console.WriteLine("\nInvalid choice.\n");
                        break;
                }
            }
        }
    }
    
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        
        public override string ToString()
        {
            return String.Format("{0}\nPhone: {1}\nEmail: {2}\n", Name, PhoneNumber, Email);
        }
    }
}
