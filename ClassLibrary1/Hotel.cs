using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Hotel
    {
        public String Name { get; private set; }
        public String Adress { get; private set; }
        public int Stars { get; private set; }
        public IList<Room> Rooms { get; private set; }

        public Hotel(string name, string adress, int stars, IList<Room> rooms)
        {
            Name = name;
            Adress = adress;
            Stars = stars;
            Rooms = rooms;

            Console.WriteLine("hotel created");
        }
    }
}
