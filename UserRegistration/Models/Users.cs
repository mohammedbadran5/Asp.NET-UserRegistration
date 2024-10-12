using Microsoft.AspNetCore.Identity;

namespace UserRegistration.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
