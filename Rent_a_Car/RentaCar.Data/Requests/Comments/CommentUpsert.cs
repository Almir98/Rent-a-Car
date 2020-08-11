using System;
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentUpsert
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int VehicleId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        [Required]
        public DateTime DateOfComment { get; set; }
        public bool? CommentStatus { get; set; }

    }
}
