using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Branch
{
    public class BranchSearchRequest
    {
        public string BranchName { get; set; }
        public int? CityId { get; set; }
    }
}
