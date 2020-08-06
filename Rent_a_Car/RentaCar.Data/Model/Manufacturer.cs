using System.Collections.Generic;

namespace Data.Model
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
