using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
            Comment = new HashSet<Comment>();
            CustomerRoles = new HashSet<CustomerRoles>();
            Payment = new HashSet<Payment>();
            Rating = new HashSet<Rating>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<CustomerRoles> CustomerRoles { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
