using System;

namespace RentaCar.Data.Requests.Booking
{
    public class BookingSearchRequest
    {
        public int? CustomerID { get; set; }
        public string FirstName { get; set; }
        public int? VehicleID { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public string LastName { get; set; }
    }
}
