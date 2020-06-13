using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class ManufacturerModel
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        //public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
