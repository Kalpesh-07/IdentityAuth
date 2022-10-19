using System;
using System.Collections.Generic;

namespace IdentityAuth.Models
{
    public class UserDTO
    {
        public UserDTO(string fullName,string userId, string email, string userName, DateTime dateCreated, List<string> roles)
        {
            FullName = fullName;
            UserId = userId;
            Email = email;
            UserName = userName;
            DateCreated = dateCreated;
            Roles = roles;
        }
        public string FullName { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
    }
}
