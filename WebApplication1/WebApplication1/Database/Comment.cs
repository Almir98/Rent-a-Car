using System;
using System.Collections.Generic;

namespace WebApplication1.Database
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeofComment { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
