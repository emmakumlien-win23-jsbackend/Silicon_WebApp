namespace Silicon_WebApp.Data
{
    public class UserProfile
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImage { get; set; } = "kattbild.svg";
        public string? Biography { get; set; }
    }
}
