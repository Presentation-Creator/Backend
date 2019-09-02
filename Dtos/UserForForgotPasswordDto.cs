using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationCreatorWeb.Dtos
{
    public class UserForForgotPasswordDto
    {
        [Required(ErrorMessage="Email field is required.")]
        [EmailAddress(ErrorMessage="Email field is not correct.")]
        public string Email { get; set; }
    }
}
