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

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
    }
}
