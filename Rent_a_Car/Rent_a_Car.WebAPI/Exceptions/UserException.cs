using System;

namespace Rent_a_Car.WebAPI.Exceptions
{
    public class UserException : Exception
    {
        public UserException(string message) : base(message) { }
    }
}
