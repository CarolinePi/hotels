using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Loader
    {
        private Customer customer;
        private Admin admin;
        private delegate void AddRoomToHotel(Hotel h, Room r);
        public Loader()
        {
            IRoomPrice commonRoomPrice = new CommonPrice(12);
            IRoomPrice discountedRoomPrice = new DiscountedPrice(commonRoomPrice, 3);
            Room fistRoom = new Room(1, commonRoomPrice, 2);
            Room secondRoom = new Room(2, discountedRoomPrice, 2);
            IList<Room> rooms = new List<Room>() { fistRoom, secondRoom };
            Hotel hotel = new Hotel("Hotel", "Yangelya 7", 4, rooms);
            admin = new Admin("Caroline", "Pospelova", 1000000, hotel);
            customer = new Customer("Ivan", "Portian", "0943423432");
            HotelRoomAdder.OnChange += () => Console.WriteLine("Room is added to Hotel");
        }

        public void DemonstrateUpcastingAndDowncasting()
        {
            IList<User> users = new List<User> { admin, customer };
            foreach(var user in users)
            {
                if (user is Admin)
                {
                    ((Admin)user).PrintIAmAdmin();
                }
            }
        }

        public void DemonstrateRoomSumOperatoroverloading()
        {
            IRoomPrice commoRoomPrice = new CommonPrice(12);
            IRoomPrice discountedRoomPrice = new DiscountedPrice(commoRoomPrice, 3);
            Room firstRoom = new Room(1, commoRoomPrice, 2);

            Room secondRoom = new Room(2, discountedRoomPrice, 4);
            Console.WriteLine(firstRoom.ToString());
            Console.WriteLine(secondRoom.ToString());
            Console.WriteLine((firstRoom + secondRoom).ToString());
        }

        public void DemonstrateDelegate()
        {
            AddRoomToHotel add = HotelRoomAdder.AddRoomToHotel;
            IRoomPrice commoRoomPrice = new CommonPrice(12);
            Room firstRoom = new Room(1, commoRoomPrice, 2);
            add(admin.Hotel, firstRoom);
        }
        public void DemonstratePriceExceptione()
        {
            IRoomPrice commoRoomPrice = new CommonPrice(-12);
        }
        public void DemonstrateSystemExceptione()
        {
            IRoomPrice commoRoomPrice = new CommonPrice(0);
        }

    }
}
