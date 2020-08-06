using System;

namespace RentaCar.Data.Requests.Booking
{
    public class BookingUpsert
    {
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
