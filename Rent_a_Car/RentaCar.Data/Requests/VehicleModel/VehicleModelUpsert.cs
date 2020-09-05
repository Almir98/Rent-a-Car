using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.VehicleModel
{
    public class VehicleModelUpsert
    {
        public int? ManufacturerId { get; set; }
        public string ModelName { get; set; }
    }
}
