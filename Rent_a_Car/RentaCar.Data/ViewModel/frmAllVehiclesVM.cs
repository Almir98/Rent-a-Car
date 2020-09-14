using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.ViewModel
{
    public class frmAllVehiclesVM
    {
        public int VehicleId { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public byte[] Image { get; set; }
        public string RegistrationNumber { get; set; }
        public string Mileage { get; set; }
        public string Transmission { get; set; }
        public int NumberOfSeats { get; set; }
        public string FuelName { get; set; }
        public string BranchName { get; set; }
    }
}
