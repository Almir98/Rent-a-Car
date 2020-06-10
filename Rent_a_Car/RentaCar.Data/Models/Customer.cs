using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int CityId { get; set; }

        public  City City { get; set; }
        public  ICollection<Booking> Booking { get; set; }
        public  ICollection<MComment> Comment { get; set; }
        public  ICollection<CustomerRoles> CustomerRoles { get; set; }
        public  ICollection<Payment> Payment { get; set; }
        public  ICollection<Rating> Rating { get; set; }
    }
}
