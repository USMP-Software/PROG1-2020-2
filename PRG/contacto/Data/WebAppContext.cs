using contacto.Models;
using Microsoft.EntityFrameworkCore;

namespace contacto.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }

        public WebAppContext(DbContextOptions dco) : base(dco) {

        }
    }
}