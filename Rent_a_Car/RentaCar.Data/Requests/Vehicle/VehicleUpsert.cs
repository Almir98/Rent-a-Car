using System;

namespace RentaCar.Data.Requests.Vehicle
{
    public class VehicleUpsert
    {
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
    }
}
