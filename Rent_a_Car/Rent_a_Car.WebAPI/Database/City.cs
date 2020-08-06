using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class City
    {
        public City()
        {
            Branch = new HashSet<Branch>();
            Customer = new HashSet<Customer>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public string PostCode { get; set; }

        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
