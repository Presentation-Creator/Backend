using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationCreatorWeb.Dtos
{
    public class UserForForgotPasswordDto
    {
        [Required(ErrorMessage="فیلد ایمیل اجباری است")]
        [EmailAddress(ErrorMessage="فیلد ایمیل صحیح نیست")]
        public string Email { get; set; }
    }
}
