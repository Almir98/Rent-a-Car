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
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int CityId { get; set; }

        public List<int> Role { get; set; } = new List<int>();
    }
}
