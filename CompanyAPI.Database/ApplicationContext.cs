using CompanyAPI.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CompanyAPI.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Statement> Statements {  get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<News> News { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=admin");
        }
    }
}
