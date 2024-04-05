using App_cliente.Data;
using Microsoft.EntityFrameworkCore;

namespace App_cliente.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new App_clienteContext(serviceProvider.GetRequiredService<DbContextOptions<App_clienteContext>>()))
            {
                if (context.Cliente.Any())
                {
                    return;
                }

                context.Cliente.AddRange(
                    new Cliente
                    {
                        Name = "Maria Lurdes",
                        Contacto = 273645367,
                        Email = "maria@email.com",
                    },

                    new Cliente
                    {
                        Name = "João Silva",
                        Contacto = 364757392,
                        Email = "joao@email.com",
                    },

                   new Cliente
                   {
                       Name = "Joana Maria",
                       Contacto = 463729087,
                       Email = "joana@email.com",
                   },

                   new Cliente
                   {
                       Name = "Lucas Oliveira",
                       Contacto = 124356728,
                       Email = "lucas@email.com",
                   }
                    );
                context.SaveChanges();
            }
        }
    }
}
