using System;
using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage ="Paro uygun gelmir!")]
        public String ConfirmPassword { get; set; }
    }
}
