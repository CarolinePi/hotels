using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class CommonPrice: IRoomPrice
    {
        public float Price { get; private set; }
        public CommonPrice(float price)
        {
            if (price < 0)
                throw new PriceException("Price lower than 0");
            try
            {
                Console.WriteLine(price);
                var a = 100 / price;
            }
            catch (DivideByZeroException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            Price = price;
            Console.WriteLine("CommonPrice is created");
        }
    }
}
