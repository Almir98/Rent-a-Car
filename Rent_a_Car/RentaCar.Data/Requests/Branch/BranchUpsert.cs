using System;
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Branch
{
    public class BranchUpsert
    {
        [Required(AllowEmptyStrings = false)]
        public string BranchName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Adress { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        [Required]
        public int CityId { get; set; }
    }
}
