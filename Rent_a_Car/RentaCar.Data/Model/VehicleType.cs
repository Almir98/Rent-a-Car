using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class VehicleType
    {
        public int VehcileTypeId { get; set; }
        public string TypeName { get; set; }

        public  ICollection<Vehicle> Vehicle { get; set; }
    }
}
