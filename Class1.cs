using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

        public class Node
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public Node Next { get; set; }

            public Node(string name, string phoneNumber)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Next = null;
            }
        }

}
