using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Customer: User
    {
        public string Phone { get; set; }
        public Room Room { get; set; }
        public Customer(String firstName, String lastName, string phone) : base(firstName, lastName)
        {
            Phone = phone;
            Console.WriteLine("Customer created");
        }

        public override void PrintFullName()
        {
            Console.WriteLine("Customer" + FirstName + " " + LastName);  
        }
    }
}
