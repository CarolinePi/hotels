using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class DiscountedPrice : IRoomPrice
    {
        private IRoomPrice roomPrice;
        private float discount;
        public float Price => (roomPrice.Price - discount);
        public DiscountedPrice(IRoomPrice roomPrice, float discount)
        {
            this.roomPrice = roomPrice;
            this.discount = discount;
            Console.WriteLine("DiscountedPrice is created");
        }

    }
}
