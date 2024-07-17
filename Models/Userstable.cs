using System;


namespace RegistrationForm.Models
{
    public partial class Userstable
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
