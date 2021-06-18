using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class HotelRoomAdder
    {
        public static event Action OnChange = delegate { };
        public static void AddRoomToHotel(Hotel hotel, Room room)
        {
            hotel.Rooms.Add(room);
            OnChange();
        }
    }
}
