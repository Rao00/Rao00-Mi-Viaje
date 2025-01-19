using Microsoft.EntityFrameworkCore;
using MvcAgenda.Models;

namespace McvAgenda.Data
{
    public class MvcAgendaContexto : DbContext
    {
        public MvcAgendaContexto(DbContextOptions<MvcAgendaContexto> options) : base(options) { }
        public DbSet<Departamento>? Departamentos { get; set; }
        public DbSet<Empleado>? Empleados { get; set; }
        public DbSet<Tarea>? Tareas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Deshabilitar la eliminación en cascada en todas las relaciones
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
