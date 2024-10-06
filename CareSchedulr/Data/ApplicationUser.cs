using Microsoft.AspNetCore.Identity;

namespace CareSchedulr.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    // should only be 9 chars 
    public string PPSNumber { get; set; }
    // only date 
    public DateTime DOB { get; set; }
}

