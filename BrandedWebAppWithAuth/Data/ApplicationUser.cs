using Microsoft.AspNetCore.Identity;

namespace BrandedWebAppWithAuth.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //extending IdentityUser with custom properties
        public required string FirstName { get; set; } 
        public required string LastName { get; set; }
    }

}
