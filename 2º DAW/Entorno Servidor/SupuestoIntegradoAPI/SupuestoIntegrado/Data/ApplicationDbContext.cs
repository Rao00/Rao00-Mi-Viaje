using SupuestoIntegrado.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SupuestoIntegrado.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public DbSet<Imagenes> ImagenesProductos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Carritos> Carritos { get; set; }

        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carritos>()
                .HasKey(p => new { p.ProductosId, p.UsuariosId });
            modelBuilder.Entity<Usuarios>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Productos>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Imagenes>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Imagenes>()
                .HasAlternateKey(p => p.url);
            modelBuilder.Entity<Roles>()
                .HasKey(p => p.Id);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
