using System.ComponentModel.DataAnnotations;

namespace SchoolApp.DTO
{
    public class UserLoginDTO
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The username must be between two and fifty characters")]
        public string? Username { get; set; }

        [RegularExpression(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W)^.{8,}$", ErrorMessage = "The password must contain at least one uppercase, one lowercase, one digit and one special character")]
        public string? Password { get; set; }

        public bool KeepLoggedIn { get; set; }
    }
}
