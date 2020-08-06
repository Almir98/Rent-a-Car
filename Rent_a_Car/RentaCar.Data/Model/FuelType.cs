using System.Collections.Generic;

namespace Data.Model
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }

        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
