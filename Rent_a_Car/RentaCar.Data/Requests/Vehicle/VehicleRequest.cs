using RentaCar.Data.Requests.VehicleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests
{
    public class VehicleRequest
    {
        public int VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public byte[] Image { get; set; }
        public int VehicleNumber { get; set; }
        public double? DailyPrice { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public string Mileage { get; set; }
        public string Transmission { get; set; }
        public int NumberOfSeats { get; set; }
        public bool? Status { get; set; }

        public VehicleModelRequest VehicleModel { get; set; }
    }
}
