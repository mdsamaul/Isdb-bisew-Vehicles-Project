using Microsoft.EntityFrameworkCore;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class VichecleDbContext:DbContext
    {
        public VichecleDbContext(DbContextOptions<VichecleDbContext> options):base(options) { }
        public virtual DbSet<Bank>? Banks { get; set; }
        public virtual DbSet<Chat>? Chats { get; set; }
        public virtual DbSet<Company>? Companies{ get; set; }

    }
}
