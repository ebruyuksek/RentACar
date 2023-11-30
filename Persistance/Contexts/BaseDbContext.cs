using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Persistance.Contexts
{
    public class BaseDbContext : DbContext
    {
        //protected IConfiguration Configuration { get; set; } //kontrol et
        public DbSet<Brand> Brands { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            //Configuration = configuration;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Assembly'deki configurasyonları bulur. 
        }

    }
}
