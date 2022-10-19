using Microsoft.AspNetCore.Identity;
using System;

namespace IdentityAuth.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
