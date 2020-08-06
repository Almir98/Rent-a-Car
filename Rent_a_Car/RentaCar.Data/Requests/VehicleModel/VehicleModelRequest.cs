using RentaCar.Data.Requests.Manufacturer;

namespace RentaCar.Data.Requests.VehicleModel
{
    public class VehicleModelRequest
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int? ManufacturerId { get; set; }
        public ManufacturerRequest Manufacturer { get; set; }
    }
}
