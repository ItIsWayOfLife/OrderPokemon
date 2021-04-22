using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
