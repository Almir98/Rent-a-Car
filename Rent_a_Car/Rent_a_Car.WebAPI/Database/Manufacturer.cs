using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Database
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            VehicleModel = new HashSet<VehicleModel>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
