using Underwriting.Components.Account.Models;

namespace Underwriting.Components.Account.Models
{
    public class UserRole
    {
        public string user_id { get; set; } = "61d470129b42b0f4965aad74";
        public List<User> users { get; set; } = new List<User>() { new User() {
            id = "61d470129b42b0f4965aad74",
            display_name = "Alyssa Smith",
            email = "asmith1@i3verticals.com",
            role = "underwriter"
        }};
        public List<Role> roles = new List<Role>() { new Role("underwriter"), new Role("manager")};
    }
}
