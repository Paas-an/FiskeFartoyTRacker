public class TokenResponse
{
    public string access_token { get; set; }
    public int expires_in { get; set; } // Change this to int or long
    public string token_type { get; set; }
    public string scope { get; set; }
}