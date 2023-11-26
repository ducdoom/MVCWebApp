namespace ManyaffClient
{
    public class User
    {
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string Password { get; set; } = string.Empty;

        public int ViewNum { get; set; } = 0;
    }
}
