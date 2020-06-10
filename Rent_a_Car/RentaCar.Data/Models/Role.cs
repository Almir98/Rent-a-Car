using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<CustomerRoles> CustomerRoles { get; set; }
    }
}
