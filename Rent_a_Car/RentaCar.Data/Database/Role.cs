using System;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Database
{
    public partial class Role
    {
        public Role()
        {
            CustomerRoles = new HashSet<CustomerRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<CustomerRoles> CustomerRoles { get; set; }
    }
}
