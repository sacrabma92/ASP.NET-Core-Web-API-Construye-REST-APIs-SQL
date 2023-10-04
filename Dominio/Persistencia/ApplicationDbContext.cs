using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options ) : base ( options )
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuracion de la llave compuesta de la tabla CursoInstructor
            modelBuilder.Entity<CursoInstructor>().HasKey(x => new { x.InstructorId, x.CursoId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<CursoInstructor> CursoInstructor { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Precio> Precio { get; set; }
    }
}
