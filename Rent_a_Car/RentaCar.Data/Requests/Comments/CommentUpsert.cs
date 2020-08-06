using System;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentUpsert
    {
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        public string Description { get; set; }
        public DateTime DateOfComment { get; set; }
    }
}
