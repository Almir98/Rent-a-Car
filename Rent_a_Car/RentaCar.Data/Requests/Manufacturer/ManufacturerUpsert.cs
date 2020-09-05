using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentaCar.Data.Requests.Manufacturer
{
    public class ManufacturerUpsert
    {
        [Required(AllowEmptyStrings = false)]
        public string ManufacturerName { get; set; }
    }
}
