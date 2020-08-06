﻿using System.Collections.Generic;

namespace Data.Model
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string PostCode { get; set; }

        public ICollection<Branch> Branch { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}
