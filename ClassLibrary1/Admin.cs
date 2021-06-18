using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Admin: User
    {
        private int salary;
        public int Salary { get { return salary; } set { salary = value; } }
        public Hotel Hotel { get; set; }

        public Admin(String firstName, String lastName, int salary, Hotel hotel) : base(firstName, lastName)
        {
            this.salary = salary;
            Hotel = hotel;
            Console.WriteLine("Admin created");
        }

        public override void PrintFullName()
        {
            Console.WriteLine("Admin" + FirstName + " " + LastName);
        }
        public void PrintIAmAdmin()
        {
            Console.WriteLine("I am Admin");
        }
    }
}
