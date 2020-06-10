using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class CustomerRoles
    {
        public int CustomerRolesId { get; set; }
        public int RoleId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Role Role { get; set; }
    }
}
