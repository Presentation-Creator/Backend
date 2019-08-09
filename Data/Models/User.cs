using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace PresentationCreatorWeb.Data.Models
{
    public enum UserType{
        user = 0,
        admin = 1,
        minister = 2
    }
    public class User 
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public string UserTypesStr { get; set; }
        [NotMapped]
        public UserType[] UserTypes
        {
            get
            {
                return Array.ConvertAll(UserTypesStr.Split(';'), ToUserType);
            }
            set
            {
                UserTypesStr = string.Join(";", value.Select(p => p.ToString()));
            }
        }
        public ICollection<UserFeature> UserFeatures { get; set; }
        public ICollection<Presentation> Presentations { get; set; }
        private UserType ToUserType(string input)
        {
            if (Enum.TryParse(input, out UserType userType))
                return userType;
            throw new ArgumentException($"Input '{input}' can't be parsed to UserType", nameof(input));
        }
    }
}