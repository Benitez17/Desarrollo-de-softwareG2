using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio;

namespace Taller.App.Persistencia
{
    public class RepositorioPropietario
    {
        private readonly ContextDb contextDb;
        public RepositorioPropietario(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        public Propietario AgregarPropietario(Propietario propietario)
        {
            var propietarioNuevo = this.contextDb.Propietarios.Add(propietario);
            this.contextDb.SaveChanges();
            return propietarioNuevo.Entity;
        }
        public IEnumerable<Propietario> ObtenerPropietarios()
        {
            return this.contextDb.Propietarios;
        }

        public Propietario BuscarPropietario(string id)
        {
            return this.contextDb.Propietarios.FirstOrDefault(u => u.Id == id);
        }

        public void EliminarPropietario(string id)
        {
            var propietario = this.contextDb.Propietarios.FirstOrDefault(u => u.Id == id);
            if (propietario != null)
            {
                this.contextDb.Propietarios.Remove(propietario);
                this.contextDb.SaveChanges();
            }
        }
        public void EditarPropietario(Propietario propietarionuevo){
             var propietarioActual = this.contextDb.Propietarios.FirstOrDefault(u => u.Id == propietarionuevo.Id);
            if (propietarioActual != null)
            { 
                propietarioActual.Nombre = propietarionuevo.Nombre;
                propietarioActual.Telefono = propietarionuevo.Telefono;
                propietarioActual.Correo = propietarionuevo.Correo;
                propietarioActual.Ciudad = propietarionuevo.Ciudad;
            }
            
        }

    }
}

