namespace Underwriting.Components.Account.Models
{
    public class Mode
    {
        public bool enabled { get; set; } = true;
        public Loader loader { get; set; } = new Loader() { color = "759a5d" };
        public Group group { get; set; } = new Group() { background_color = "759a5d", header = new Header() {color = "F4F4F4" } };
    }
}
