using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ContactList
    {
        private Node head;

        public ContactList()
        {
            head = null;
        }

   
        public void AddContact(string name, string phoneNumber)
        {
            if (!ContactExists(name))
            {
                Node newNode = new Node(name, phoneNumber);
                newNode.Next = head;
                head = newNode;
                Console.WriteLine($"Contact {name} added with number {phoneNumber}.");
            }
            else
            {
                Console.WriteLine($"Contact with name {name} already exists.");
            }
        }


        public string GetContact(string name)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return $"Phone number of {name}: {current.PhoneNumber}";
                }
                current = current.Next;
            }
            return "Contact not found";
        }

        public string DeleteContact(string name)
        {
            if (head == null)
            {
                return "Contact not found";
            }

            if (head.Name == name)
            {
                head = head.Next;
                return $"Contact {name} deleted.";
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Name == name)
                {
                    current.Next = current.Next.Next;
                    return $"Contact {name} deleted.";
                }
                current = current.Next;
            }

            return "Contact not found";
        }

        
        public void UpdateContact(string name, string newPhoneNumber)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    current.PhoneNumber = newPhoneNumber;
                    Console.WriteLine($"Phone number of contact {name} updated to {newPhoneNumber}.");
                    return;
                } 
                current = current.Next;
            }
            Console.WriteLine($"Contact with name {name} not found.");
        }

       
        public bool ContactExists(string name)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        
        public void ListAllContacts()
        {
            if (head == null)
            {
                Console.WriteLine("Phone book is empty.");
                return;
            }

            Node current = head;
            Console.WriteLine("All contacts:");
            while (current != null)
            {
                Console.WriteLine($"Name: {current.Name}, Number: {current.PhoneNumber}");
                current = current.Next;
            }
        }

       
        public int CountContacts()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

       
        public void ClearAllContacts()
        {
            head = null;
            Console.WriteLine("All contacts deleted.");
        }
    }
     

} 
