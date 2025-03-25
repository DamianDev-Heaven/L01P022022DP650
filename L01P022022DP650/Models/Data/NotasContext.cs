using Microsoft.EntityFrameworkCore;

namespace L01P022022DP650.Models.Data
{
    public class NotasContext : DbContext
    {
        public NotasContext(DbContextOptions<NotasContext> options) : base(options)
        {
        }

        public DbSet<facultades> Facultades { get; set; }
        public DbSet<materias> Materias { get; set; }
        public DbSet<departamentos> Departamentos { get; set; }
        public DbSet<alumnos> Alumnos { get; set; }
    }
}