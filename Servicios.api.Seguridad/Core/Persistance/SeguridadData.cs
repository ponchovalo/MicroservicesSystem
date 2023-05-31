using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Servicios.api.Seguridad.Core.Entities;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Servicios.api.Seguridad.Core.Persistance
{
    public class SeguridadData
    {

        public static async Task InsertarUsuario(SeguridadContext context, UserManager<Usuario> userManager)
        {
            if (!userManager.Users.Any())
            {
                var usuario = new Usuario()
                {
                    Nombre = "Ildefonso",
                    Apellido = "Valenzuela",
                    Direccion = "MonteReal",
                    UserName = "ponchovalo",
                    Email = "ponchovalo@outlook.com"

                };
                await userManager.CreateAsync(usuario, "Password123$");
            }
        }
    }
}
