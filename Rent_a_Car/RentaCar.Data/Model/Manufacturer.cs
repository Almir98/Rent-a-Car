using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
