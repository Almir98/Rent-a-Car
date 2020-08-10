using System;
using System.Collections.Generic;
using System.Text;
using RentaCar.Data.Requests.City;

namespace RentaCar.Data.Requests.Customer
{
    public class CustomerRequest
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public CityRequest City { get; set; }

    }
}
