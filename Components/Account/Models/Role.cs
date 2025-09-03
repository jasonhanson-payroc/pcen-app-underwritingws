namespace Underwriting.Components.Account.Models
{
    public class Role
    {
        public Role(string roleId) 
        {
            if(roleId.ToLower() == "manager")
            {
                permissions = new List<string> { "assignable", "manager", "reports.run.all", "notes.visible.all", "history.visible" };
                rank = 1;
                id = "manager";
            }

            if(roleId.ToLower() == "underwriter")
            {
                permissions = new List<string> { "assignable", "reports.run.all", "history.visible" };
                rank = 1;
                id = roleId.ToLower();
            }
        }

        public int rank { get; set; } = 1;
        public string id { get; set; }
        public List<string> permissions { get; set; }
    }
}
