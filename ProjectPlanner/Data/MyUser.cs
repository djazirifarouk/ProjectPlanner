using Microsoft.AspNetCore.Identity;

namespace ProjectPlanner.Data
{
    public class MyUser : IdentityUser
    {
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}