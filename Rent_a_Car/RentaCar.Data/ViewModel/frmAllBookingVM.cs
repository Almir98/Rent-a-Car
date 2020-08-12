using System;

namespace RentaCar.Data.ViewModel
{
    public class frmAllBookingVM
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public float? DailyPrice { get; set; }
    }
}
