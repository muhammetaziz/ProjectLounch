using Microsoft.AspNetCore.Identity;

namespace WorksAndProjects.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfilePhotoUrl { get; set; }=string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string LinkedInUrl { get; set; } = string.Empty;
        public List<string> Skills { get; set; }    
    }

}
