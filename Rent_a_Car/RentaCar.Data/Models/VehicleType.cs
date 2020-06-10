using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class VehicleType
    {
        public int VehcileTypeId { get; set; }
        public string TypeName { get; set; }
        
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
