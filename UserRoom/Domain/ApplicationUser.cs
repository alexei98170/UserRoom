using Microsoft.AspNetCore.Identity;

namespace UserRoom.Domain
{
    public class ApplicationUser : IdentityUser // We extend the base IdentityUser in case we need to add more properties later
    {
        public bool IsBlocked { get; set; }
    }
}
