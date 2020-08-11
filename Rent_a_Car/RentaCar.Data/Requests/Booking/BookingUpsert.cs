using System;
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Booking
{
    public class BookingUpsert
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int VehicleId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public bool? RatingStatus { get; set; }
        public bool? CommentStatus { get; set; }
    }
}
