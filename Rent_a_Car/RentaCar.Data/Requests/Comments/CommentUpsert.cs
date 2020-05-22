using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentUpsert
    {
        public string Description { get; set; }
        public DateTime DateOfComment { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
    }
}
