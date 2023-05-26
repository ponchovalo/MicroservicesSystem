using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Servicios.api.Seguridad.Core.Entities;

namespace Servicios.api.Seguridad.Core.Persistance
{
    public class SeguridadContext : IdentityDbContext<Usuario>
    {
        public SeguridadContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
