using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Room
    {
        public int Number { get; set; }
        public IRoomPrice Price { get; set; }
        public int BedNumber { get; set; }

        public Room(int number, IRoomPrice price, int bedNumber)
        {
            Number = number;
            Price = price;
            BedNumber = bedNumber;
            Console.WriteLine("Room created");
        }

        public static Room operator+(Room o, Room n)
        {
            return new Room(o.Number, o.Price, o.BedNumber + n.BedNumber);
        }
        public override string ToString()
        {
            return "Room " + Number + "BedNumber " + BedNumber;
        }

    }
}
