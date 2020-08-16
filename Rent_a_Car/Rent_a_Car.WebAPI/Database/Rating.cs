using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int RatingValue { get; set; }
        public int? CustomerId { get; set; }
        public int? VehicleId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
