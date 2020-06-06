using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Models
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }

        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
