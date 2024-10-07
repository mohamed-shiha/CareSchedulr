using Microsoft.AspNetCore.Identity;

namespace CareSchedulr.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; }

    // should only be 9 chars 
    public string PPSNumber { get; set; }
    // only date 
    public DateTime DOB { get; set; }
}

