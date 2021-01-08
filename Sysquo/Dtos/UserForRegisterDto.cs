using System;
using System.ComponentModel.DataAnnotations;

namespace Sysquo.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is missing."), EmailAddress(ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required]
        public DateTime SignupTime { get; set; }
    }
}