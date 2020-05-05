using System;
using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Meni Xatirla")]
        public bool RememberMe { get; set; }
    }
}