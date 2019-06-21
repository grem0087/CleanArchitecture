using System;

namespace BurgerMarket.Domain.Exceptions
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException()
        {
        }

        public InvalidPriceException(string message)
            : base(message)
        {
        }

        public InvalidPriceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}