using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customer = new HashSet<Customer>();
        }

        public int CustomerTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
