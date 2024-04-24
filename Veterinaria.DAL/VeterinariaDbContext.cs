using Microsoft.EntityFrameworkCore;

namespace Veterinaria.DAL
{
    public class VeterinariaDbContext : DbContext
    {
        public VeterinariaDbContext() { }

        public VeterinariaDbContext(DbContextOptions<VeterinariaDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer();
        }

        public virtual DbSet<Veterinario> Veterinario { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Mascota> Mascotas { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
    }
}
