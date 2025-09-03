namespace Underwriting.Components.Account.Models
{
    public class PluginRequestModel
    {
        public string timezone { get; set; } = "America/Chicago";
        public UserRole user_roles { get; set; } = new UserRole();
        public Appearance appearance { get; set; } = new Appearance();
    }
}
