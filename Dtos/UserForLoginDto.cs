using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationCreatorWeb.Dtos
{
    public class UserForLoginDto
    {
        [Required(ErrorMessage="فیلد ایمیل اجباری است")]
        [EmailAddress(ErrorMessage="فیلد ایمیل صحیح نیست")]
        public string Email { get; set; }
        [Required(ErrorMessage="فیلد پسورد اجباری است")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "پسورد شما باید بین 4 تا 8 کاراکتر داشته باشد")]
        public string Password { get; set; }
    }
}