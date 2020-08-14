using System;
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Booking
{
    public class BookingUpdate
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int VehicleId { get; set; }

        public bool? RatingStatus { get; set; }
    }
}
