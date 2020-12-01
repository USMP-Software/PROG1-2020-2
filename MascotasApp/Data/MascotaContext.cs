using MascotasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MascotasApp.Data
{
    public class MascotaContext : DbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<TipoMascota> TipoMascotas { get; set; }
        public MascotaContext(DbContextOptions dco) : base(dco) {

        }
    }
}