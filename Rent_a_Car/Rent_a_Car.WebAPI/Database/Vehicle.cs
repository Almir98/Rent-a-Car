using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Booking = new HashSet<Booking>();
            Comment = new HashSet<Comment>();
            Rating = new HashSet<Rating>();
        }

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
        public int? BranchId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? VehicleModelId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
