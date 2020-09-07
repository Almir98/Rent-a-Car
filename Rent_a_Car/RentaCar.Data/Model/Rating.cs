﻿using System;

namespace Data.Model
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int RatingValue { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public DateTime RatingDate { get; set; }



        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
