using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
