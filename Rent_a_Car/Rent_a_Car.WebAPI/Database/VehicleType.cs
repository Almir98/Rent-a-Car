using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Database
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int VehcileTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
