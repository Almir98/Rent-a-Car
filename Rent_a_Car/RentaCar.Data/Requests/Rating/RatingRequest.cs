using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.VehicleModel;
using System;
using System.Collections.Generic;
using System.Text;

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
        
        //public int CustomerId { get; set; }
        //public int VehicleId { get; set; }
    }
}
