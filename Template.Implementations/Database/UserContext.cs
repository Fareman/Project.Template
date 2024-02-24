namespace Template.Implementations.Database
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Template.Domain.Entities;

    public class UserContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public UserContext(DbContextOptions options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("SQLite"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Database.EnsureCreated();
        }
    }
}
