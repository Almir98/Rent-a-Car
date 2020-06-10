using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public partial class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public string TypeName { get; set; }

        public  ICollection<Payment> Payment { get; set; }
    }
}
