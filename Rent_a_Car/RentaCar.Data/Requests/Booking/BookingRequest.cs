using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Vehicle;
using System;
using System.Collections.Generic;
using System.Text;


namespace RentaCar.Data.Requests.Booking
{
    public class BookingRequest
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public CustomerRequest Customer { get; set; }
        public VehicleRequest Vehicle { get; set; }

    }
}
