namespace Underwriting.Components.Account.Models
{
    public class Token
    {
        public string env { get; set; }
        public string token_type { get; set; }
        public string access_token { get; set; }
        public string issued_at { get; set; }
        public string expires_in { get; set; }
        public string status { get; set; }
        public string refresh_token { get; set; }
        public string refresh_token_issued_at { get; set; }
        public string refresh_token_expires_in { get; set; }
        public List<string> application_list { get; set; }
        public string scope { get; set; }
    }
}
