using System;
using System.Collections.Generic;

namespace WebApplication1.Database
{
    public partial class BranchVehicle
    {
        public int BranchVehicleId { get; set; }
        public int VehicleId { get; set; }
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
