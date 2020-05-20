using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Database
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
            Comment = new HashSet<Comment>();
            Payment = new HashSet<Payment>();
            Rating = new HashSet<Rating>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int CustomerTypeId { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
