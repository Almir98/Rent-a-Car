using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
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
        public int? CustomerTypeId { get; set; }

        public City City { get; set; }
        public CustomerType CustomerType { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Rating> Rating { get; set; }
    }
}
