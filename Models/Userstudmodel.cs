using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Userstudmodel
    {
        [Required(ErrorMessage = "*")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Enter min 2 character and max 10 character")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "*")]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        [RegularExpression("[0-9]{10}",ErrorMessage ="Enter numeric Number only")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [EmailAddress(ErrorMessage = "Enter a valid Email")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Username can only contain letters and numbers")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }
    }
}

