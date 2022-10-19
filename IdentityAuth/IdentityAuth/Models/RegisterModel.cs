using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityAuth.Authentication
{
    public class RegisterModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}
