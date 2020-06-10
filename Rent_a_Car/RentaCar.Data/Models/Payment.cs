using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal? Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }
        public int BookingId { get; set; }

        public  Booking Booking { get; set; }
        public  Customer Customer { get; set; }
        public  PaymentType PaymentType { get; set; }
    }
}
