using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }
        public string Type { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
