using System.ComponentModel.DataAnnotations;

namespace RentaCar.Data.Requests.Customer
{
    public class CustomerUpsert
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }

        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

        [Required]
        public int CustomerTypeId { get; set; }
        [Required]
        public int CityId { get; set; }
    }
}
