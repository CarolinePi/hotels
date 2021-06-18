using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class PriceException: Exception
    {
        public PriceException()
        {

        }
        public PriceException(string message) : base(message)
        {

        }
        public PriceException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
