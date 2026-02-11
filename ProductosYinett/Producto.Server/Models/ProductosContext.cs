using Microsoft.EntityFrameworkCore;

namespace Producto.Server.Models
{
    public class ProductosContext : DbContext
    {
        public ProductosContext(DbContextOptions<ProductosContext> options) : base(options)
        {
        }

        public DbSet<Productoss> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productoss>().HasIndex(c => c.Nombre).IsUnique();
        }
    }
}