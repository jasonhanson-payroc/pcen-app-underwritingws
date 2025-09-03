namespace Underwriting.Components.Account.Models
{
    public class Group
    {
        public string background_color { get; set; } = "ffffff";
        public Border border { get; set; } = new Border();
        public Header header { get; set; } = new Header() { background_color = "759a5d" };
        public Shadow shadow { get; set; } = new Shadow();
    }
}
