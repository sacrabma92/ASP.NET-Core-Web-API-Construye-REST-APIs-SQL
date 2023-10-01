using Microsoft.EntityFrameworkCore;

namespace NETCORE
{
    internal class ApplicationDbContext : DbContext
    {
        private const string connectionString = @"Server=localhost;Database=CursoOnline;User ID=sa;Password=12345;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new { ci.CursoId, ci.InstructorId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<CursoInstructor> CursoInstructor { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
    }
}
