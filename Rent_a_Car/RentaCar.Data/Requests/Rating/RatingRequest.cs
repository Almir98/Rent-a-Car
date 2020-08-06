using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.Requests.VehicleModel;

namespace RentaCar.Data.Requests.Rating
{
    public class RatingRequest
    {
        public int RatingId { get; set; }
        public int RatingValue { get; set; }

        public CustomerRequest Customer { get; set; }
        public VehicleRequest Vehicle { get; set; }
        public VehicleModelRequest VehicleModel { get; set; }
        public ManufacturerRequest Manufacturer { get; set; }
    }
}
