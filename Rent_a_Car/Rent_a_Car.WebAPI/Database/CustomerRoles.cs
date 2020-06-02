using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class CustomerRoles
    {
        public int CustomerRolesId { get; set; }
        public int RoleId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Role Role { get; set; }
    }
}
