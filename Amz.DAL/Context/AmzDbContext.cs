using Amz.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Amz.DAL.Context
{
    public class AmzDbContext : DbContext
    {
        public AmzDbContext(DbContextOptions<AmzDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AmzDbContext)));
        }
    }
}
