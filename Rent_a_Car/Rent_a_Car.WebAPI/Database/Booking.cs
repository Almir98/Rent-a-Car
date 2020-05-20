using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Database
{
    public partial class Booking
    {
        public Booking()
        {
            Payment = new HashSet<Payment>();
        }

        public int BookingId { get; set; }
        public int NumberOfDays { get; set; }
        public double? TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Canceled { get; set; }
        public int? Discount { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
