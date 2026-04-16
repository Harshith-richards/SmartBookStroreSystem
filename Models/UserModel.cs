using Microsoft.AspNetCore.Identity;

namespace SmartBookStroreSystem.Models
{
    public class UserModel : IdentityUser
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
