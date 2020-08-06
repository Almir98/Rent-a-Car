using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.Requests.VehicleModel;
using System;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentRequest
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime DateOfComment { get; set; }

        public CustomerRequest Customer { get; set; }
        public VehicleRequest Vehicle { get; set; }
        public VehicleModelRequest VehicleModel { get; set; }
        public ManufacturerRequest Manufacturer { get; set; }
    }
}