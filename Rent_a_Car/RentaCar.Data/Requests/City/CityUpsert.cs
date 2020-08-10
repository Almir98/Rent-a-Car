using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.City
{
    public class CityUpsert
    {
        [Required]
        public string CityName { get; set; }
        [Required]
        public string PostCode { get; set; }
    }
}
