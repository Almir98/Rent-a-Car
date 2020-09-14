using System;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentSearchRequest
    {
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? DateOfComment { get; set; }

        public int? CustomerID { get; set; }
        public int? VehicleId { get; set; }
    }
}
