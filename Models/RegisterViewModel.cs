using System.ComponentModel.DataAnnotations;

namespace OnlineStoreZaliczenie.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(150, ErrorMessage = "Max 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [StringLength(100, ErrorMessage = "Max 100 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The password must contain at least 8 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm your password.")]
        [Compare("Password", ErrorMessage = "Passwords are not the same.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
