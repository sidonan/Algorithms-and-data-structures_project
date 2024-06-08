using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        class Program
        {
            static void Main()
            {
                ContactList phoneBook = new ContactList();
                phoneBook.AddContact("Ivan", "123456789");
                phoneBook.AddContact("Maria", "987654321");

                Console.WriteLine(phoneBook.GetContact("Ivan"));  // Output: Phone number of Ivan: 123456789
                Console.WriteLine(phoneBook.DeleteContact("Maria"));  // Output: Contact Maria deleted.
                Console.WriteLine(phoneBook.GetContact("Maria"));  // Output: Contact not found

                phoneBook.UpdateContact("Ivan", "111111111");  // Update Ivan's phone number
                phoneBook.ListAllContacts();  // List all remaining contacts
                Console.WriteLine($"Total number of contacts: {phoneBook.CountContacts()}");  // Output total number of contacts
                Console.WriteLine(phoneBook.ContactExists("Ivan") ? "Contact Ivan exists." : "Contact Ivan not found.");  // Check if contact exists

                phoneBook.ClearAllContacts();  // Clear all contacts
                phoneBook.ListAllContacts();  // Try to list all contacts (empty)
            }
        }


    }
}
