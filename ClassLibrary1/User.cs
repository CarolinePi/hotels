using System;

namespace ClassLibrary1
{
    abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void PrintFullName();
    }
}
