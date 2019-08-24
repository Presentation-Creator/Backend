using System;
using System.Collections.Generic;

namespace PresentationCreatorWeb.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string UserTypesStr { get; set; }
    }
}