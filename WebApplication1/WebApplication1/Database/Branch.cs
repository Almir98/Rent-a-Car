using System;
using System.Collections.Generic;

namespace WebApplication1.Database
{
    public partial class Branch
    {
        public Branch()
        {
            BranchVehicle = new HashSet<BranchVehicle>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeofComment { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<BranchVehicle> BranchVehicle { get; set; }
    }
}
