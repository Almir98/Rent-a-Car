using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class FuelType
    {
        public FuelType()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
