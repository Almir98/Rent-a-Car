using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Customer
{
    public class CustomerLoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
