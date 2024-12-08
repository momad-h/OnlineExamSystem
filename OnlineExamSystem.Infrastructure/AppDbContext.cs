using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.OnlineExamSystem.Domain.Entities;

namespace OnlineExamSystem.OnlineExamSystem.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }

}
