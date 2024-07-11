using Microsoft.EntityFrameworkCore;
using System.Reflection;
using PostableRESTfulApi.Models;

namespace PostableRESTfulApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Buscamos todas las clases que hereden de IEntityTypeConfiguration<T> y las aplicamos a la base de datos
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<User> Users => Set<User>();
    }
}
