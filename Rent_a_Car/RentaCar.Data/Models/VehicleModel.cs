using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class VehicleModel
    {

        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
