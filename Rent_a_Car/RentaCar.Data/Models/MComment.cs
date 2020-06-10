using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class MComment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime DateOfComment { get; set; }
        
        public int CustomerId { get; set; }
        public  Customer Customer { get; set; }
        
        public int VehicleId { get; set; }
        public  Vehicle Vehicle { get; set; }
    }
}
