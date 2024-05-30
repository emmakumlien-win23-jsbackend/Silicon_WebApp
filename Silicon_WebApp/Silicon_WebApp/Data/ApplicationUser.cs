using Microsoft.AspNetCore.Identity;

namespace Silicon_WebApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? UserProfileId { get; set; }
        public UserProfile? Profile { get; set; }

        public string? UserAddressId { get; set; }
        public UserAddress? UserAddress { get; set; }
    }
}
