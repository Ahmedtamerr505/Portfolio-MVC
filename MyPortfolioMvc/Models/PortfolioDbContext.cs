using Microsoft.EntityFrameworkCore;

namespace MyPortfolioMvc.Models
{
    public class PortfolioDbContext : DbContext // Changed to PascalCase for consistency
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }

        // Optional: Add a parameterless constructor
        public PortfolioDbContext() { }

        // Define DbSet properties for your database tables
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
