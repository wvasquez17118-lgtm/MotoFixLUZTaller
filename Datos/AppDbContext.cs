using Datos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class AppDbContext : DbContext
    {
        public DbSet<CatMotos> Motos => Set<CatMotos>();
        public DbSet<CatMarca> Marcas => Set<CatMarca>();
        public DbSet<CatModelos> Modelos => Set<CatModelos>();
        public DbSet<CatEstado> Estados => Set<CatEstado>();
        public DbSet<CatTrabajoRealizados> CatTrabajoRealizados => Set<CatTrabajoRealizados>();
        public DbSet<IngresoTaller> IngresoTaller => Set<IngresoTaller>();
        public DbSet<IngresoTallerDetalles> IngresoTallerDetalles => Set<IngresoTallerDetalles>();
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=.;Database=MotoFixLuz;Trusted_Connection=True;TrustServerCertificate=True");
        //@"Server=.\SQLEXPRESS;Database=MotoFixLuz;Trusted_Connection=True;TrustServerCertificate=True"
    }
}