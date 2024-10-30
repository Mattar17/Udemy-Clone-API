using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Udemy.Presentation.DTOs
{
    public class RegisterDTO
    {
        public string Username { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email")]
        [Required]
        public string Email { get; set; }
        [PasswordPropertyText]
        [Required]
        public string Password { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
