namespace MVCWebApp.Models.ManyAff
{
    public class UserDashboard
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Dashboard Dashboard { get; set; } = new();
    }
}
