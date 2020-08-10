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
        [Required]
        public DateTime? OpenTime { get; set; }
        [Required]
        public DateTime? CloseTime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        [Required]
        public int CityId { get; set; }
    }
}
