using MascotasApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MascotasApp.Data
{
    public class MascotaContext : IdentityDbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<TipoMascota> TipoMascotas { get; set; }
        public MascotaContext(DbContextOptions dco) : base(dco) {

        }
    }
}