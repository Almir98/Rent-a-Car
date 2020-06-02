using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.City
{
    public class CitySearchRequest
    {
        public int? CityId { get; set; }
        public string CityName { get; set; }
    }
}
