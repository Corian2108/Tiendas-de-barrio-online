using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoIntegrador.Models.Perfil> Perfil { get; set; }

        public DbSet<ProyectoIntegrador.Models.CompraCliente> CompraCliente { get; set; }

        public DbSet<ProyectoIntegrador.Models.Persona> Persona { get; set; }
    }
}
