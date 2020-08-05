using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Vehicle
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
        public int BranchId { get; set; }
        public int FuelTypeId { get; set; }
        public int VehicleTypeId { get; set; }
        public int VehicleModelId { get; set; }

        public Branch Branch { get; set; }
        public FuelType FuelType { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public VehicleType VehicleType { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Rating> Rating { get; set; }
    }
}
