namespace Underwriting.Components.Account.Models
{
    public class Appearance
    {
        public string font_family { get; set; } = "Roboto, Arial";
        public Loader loader { get; set; } = new Loader();
        public int border_radius { get; set; } = 4;
        public Button primary_button { get; set; } = new Button();
        public Button secondary_button { get; set; } = new Button();
        public Button tab_button_active { get; set; } = new Button() { background_color_hover = "" };
        public Group group { get; set; } = new Group() { background_color = "ffffff", header = new Header() { background_color = "759a5d", font_size = 14 } };
        public Mode dark_mode { get; set; } = new Mode() { group = new Group() { background_color = "", border = new Border() { color = "" }, shadow = null, header = new Header() { color = "f4f4f4", font_size = null } } };
    }
}
