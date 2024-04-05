using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App_cliente.Models;

namespace App_cliente.Data
{
    public class App_clienteContext : DbContext
    {
        public App_clienteContext (DbContextOptions<App_clienteContext> options)
            : base(options)
        {
        }

        public DbSet<App_cliente.Models.Cliente> Cliente { get; set; } = default!;
    }
}
