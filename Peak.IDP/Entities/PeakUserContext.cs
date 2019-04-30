using Microsoft.EntityFrameworkCore;

namespace Peak.IDP.Entities
{
    public class PeakUserContext : DbContext
    {
        public PeakUserContext(DbContextOptions<PeakUserContext> options)
           : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
