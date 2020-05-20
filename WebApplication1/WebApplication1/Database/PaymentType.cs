using System;
using System.Collections.Generic;

namespace WebApplication1.Database
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Payment = new HashSet<Payment>();
        }

        public int PaymentTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
    }
}
