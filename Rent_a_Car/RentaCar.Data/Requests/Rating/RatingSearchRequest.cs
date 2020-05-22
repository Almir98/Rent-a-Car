using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Rating
{
    public class RatingSearchRequest
    {
        public string CustomerName { get; set; }
        public string VehicleName { get; set; }
    }
}
