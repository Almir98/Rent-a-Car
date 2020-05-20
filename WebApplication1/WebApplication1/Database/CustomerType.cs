using System;
using System.Collections.Generic;

namespace WebApplication1.Database
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customer = new HashSet<Customer>();
        }

        public int CustomerTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
