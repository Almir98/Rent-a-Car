using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Database
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public decimal? Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
