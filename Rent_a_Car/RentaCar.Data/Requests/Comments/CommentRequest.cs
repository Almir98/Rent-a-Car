using RentaCar.Data.Requests.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentRequest
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime DateOfComment { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        public CustomerRequest Customer { get; set; }
    }
}