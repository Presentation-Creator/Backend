using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationCreatorWeb.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Email field is required.")]
        [EmailAddress(ErrorMessage="Email field is not correct.")]
        public string Email { get; set; }
        [Required(ErrorMessage="Phone number field required.")]
        public string Phone { get; set; }
        [Required(ErrorMessage="Password field is required.")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password length must be between 4 and 8 characters long.")]
        public string Password { get; set; }
    }
}
