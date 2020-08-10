using System;
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Vehicle
{
    public class VehicleUpsert
    {
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public int VehicleNumber { get; set; }
        public byte[] Image { get; set; }
        public double? DailyPrice { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ManufacturerDate { get; set; }
        [Required]
        public string Mileage { get; set; }
        [Required]
        public string Transmission { get; set; }
        [Required]
        public int NumberOfSeats { get; set; }
        public bool? Status { get; set; }
        [Required]
        public int BranchId { get; set; }
        [Required]
        public int FuelTypeId { get; set; }
        [Required]
        public int VehicleTypeId { get; set; }
        [Required]
        public int VehicleModelId { get; set; }
    }
}
