﻿namespace RentaCar.Data.Requests.Customer
{
    public class CustomerSearchRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public int? CustomerTypeId { get; set; }

    }
}
