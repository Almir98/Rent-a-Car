using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Customer
{
    public class CustomerUpsert
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int CityId { get; set; }
    }
}
