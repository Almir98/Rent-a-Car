using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
