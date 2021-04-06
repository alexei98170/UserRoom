using Microsoft.EntityFrameworkCore;
using UserRoom.Domain;

namespace UserRoom.Models
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
