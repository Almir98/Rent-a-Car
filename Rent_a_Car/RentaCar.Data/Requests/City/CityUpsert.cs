﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.City
{
    public class CityUpsert
    {
        public string CityName { get; set; }
        public string PostCode { get; set; }
    }
}
