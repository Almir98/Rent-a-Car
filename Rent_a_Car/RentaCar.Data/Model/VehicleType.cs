using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Models
{
    public class VehicleType
    {
        public int VehcileTypeId { get; set; }
        public string TypeName { get; set; }
        
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
