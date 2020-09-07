using System;
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Rating
{
    public class RatingUpsert
    {
        [Required]
        public int RatingValue { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int VehicleId { get; set; }
        public DateTime? RatingDate { get; set; }
    }
}
