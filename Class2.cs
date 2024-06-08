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

                Console.WriteLine(phoneBook.GetContact("Ivan")); 
                Console.WriteLine(phoneBook.DeleteContact("Maria")); 
                Console.WriteLine(phoneBook.GetContact("Maria")); 

                phoneBook.UpdateContact("Ivan", "111111111"); 
                phoneBook.ListAllContacts(); 
                Console.WriteLine($"Total number of contacts: {phoneBook.CountContacts()}"); 
                Console.WriteLine(phoneBook.ContactExists("Ivan") ? "Contact Ivan exists." : "Contact Ivan not found."); 

                phoneBook.ClearAllContacts(); 
                phoneBook.ListAllContacts(); 
            }
        }


    }
}
