using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio;

namespace Taller.App.Persistencia
{
    public class RepositorioMecanico
    {
        private readonly ContextDb contextDb;
        public RepositorioMecanico(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        public Mecanico AgregarMecanico(Mecanico mecanico)
        {

            var mecanicoNuevo = this.contextDb.Mecanicos.Add(mecanico);
            this.contextDb.SaveChanges();
            return mecanicoNuevo.Entity;
        }

        public IEnumerable<Mecanico> ObtenerMecanicos()
        {
            return this.contextDb.Mecanicos;
        }

        public Mecanico BuscarMecanico(string id)
        {
            return this.contextDb.Mecanicos.FirstOrDefault(m => m.Id == id);
        }

        public void EliminarMecanico(string id)
        {
            var mecanico = this.contextDb.Mecanicos.FirstOrDefault(m => m.Id == id);
            if (mecanico != null)
            {
                this.contextDb.Mecanicos.Remove(mecanico);
                this.contextDb.SaveChanges();
            }
        }

        public void EditarMecanico(Mecanico mecaniconuevo){
             var mecanicoActual = this.contextDb.Mecanicos.FirstOrDefault(m => m.Id == mecaniconuevo.Id);
            if (mecanicoActual != null)
            { 
                mecanicoActual.Nombre = mecaniconuevo.Nombre;
                mecanicoActual.Telefono = mecaniconuevo.Telefono;
                mecanicoActual.Correo = mecaniconuevo.Correo;
                mecanicoActual.Contrasenia = mecaniconuevo.Contrasenia;
                mecanicoActual.FechaNacimiento = mecaniconuevo.FechaNacimiento;
                mecanicoActual.Ciudad = mecaniconuevo.Ciudad;
            }
            
        }
       
    }

}


