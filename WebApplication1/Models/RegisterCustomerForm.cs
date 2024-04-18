using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterCustomerForm
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        

        [RegularExpression("^([569]\\d{7})$")]
        public string PhoneNumber { get; set; }

        [ValidCivilId]
        public string CivilId { get; set; }
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
        
        public string FavoriteColor { get; set; }

    }
}
