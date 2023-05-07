using MatrimonyAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace MatrimonyAPI.Context
{
    public class MatrimonyDbContext:DbContext
    {
        public MatrimonyDbContext(DbContextOptions<MatrimonyDbContext> options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
