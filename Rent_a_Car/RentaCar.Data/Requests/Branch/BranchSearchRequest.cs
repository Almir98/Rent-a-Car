using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Branch
{
    public class BranchSearchRequest
    {
        public int? CityId { get; set; }
        public string BranchName { get; set; }
    }
}
