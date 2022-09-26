using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Taller.App.Dominio;
 
namespace Taller.App.Persistencia
{
    public class ContextDb: DbContext
    {
         public DbSet<Mecanico> Mecanicos { get; set; }
         public DbSet<Propietario> Propietarios { get; set; }
         public DbSet<Vehiculo> Vehiculos { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SISTEMAS01;Database=master;Trusted_Connection=True;");
            }
        
        }
    }
   
}
