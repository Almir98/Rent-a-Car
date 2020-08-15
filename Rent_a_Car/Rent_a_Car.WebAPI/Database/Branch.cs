using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Branch
    {
        public Branch()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
