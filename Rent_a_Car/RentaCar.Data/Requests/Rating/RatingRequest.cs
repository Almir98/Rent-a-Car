using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Rating
{
    public class RatingRequest
    {
        public int RatingValue { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
    }
}
